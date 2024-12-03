using Microsoft.EntityFrameworkCore;
using CarInsuranceManage.Models; // Thay thế bằng namespace của bạn
using CarInsuranceManage.Database; // Thay thế bằng namespace của bạn

var builder = WebApplication.CreateBuilder(args);

// Thêm dịch vụ MVC vào container
builder.Services.AddControllersWithViews();

// Thêm cấu hình routing để URL luôn viết chữ thường
builder.Services.AddRouting(options => options.LowercaseUrls = true);

// Cấu hình DbContext để sử dụng MySQL
builder.Services.AddDbContext<CarInsuranceDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                     new MySqlServerVersion(new Version(8, 0, 33)))); // Đảm bảo phiên bản đúng với MySQL của bạn

// Xây dựng ứng dụng
var app = builder.Build();

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
