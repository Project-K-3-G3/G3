using Microsoft.EntityFrameworkCore;
using CarInsuranceManage.Models;
using CarInsuranceManage.Database; // Thay đổi theo namespace của dự án của bạn.

var builder = WebApplication.CreateBuilder(args);

// Cấu hình DbContext với SQLite
builder.Services.AddDbContext<CarInsuranceDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CarInsuranceDb"))); // Sử dụng connection string từ appsettings.json hoặc trực tiếp

// Thêm dịch vụ MVC vào container
builder.Services.AddControllersWithViews();

// Thêm cấu hình routing để URL luôn viết chữ thường
builder.Services.AddRouting(options => options.LowercaseUrls = true);

// Xây dựng ứng dụng
var app = builder.Build();

// Đảm bảo database đã được tạo và dữ liệu mẫu được thêm vào
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<CarInsuranceDbContext>();
    dbContext.Database.Migrate();  // Áp dụng migrations và seed data
}

// Cấu hình HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();  // Cấu hình cho phép phục vụ các tài nguyên tĩnh như hình ảnh, CSS, JS

app.UseRouting();

// Cấu hình cho phép xác thực và ủy quyền (nếu có)
app.UseAuthorization();  // Nếu sử dụng xác thực, cần gọi UseAuthentication() trước

// Cấu hình Route cho các controller
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Chạy ứng dụng
app.Run();
