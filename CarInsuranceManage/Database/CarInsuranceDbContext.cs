using CarInsuranceManage.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CarInsuranceManage.Database
{
    public class CarInsuranceDbContext : DbContext
    {
        public CarInsuranceDbContext(DbContextOptions<CarInsuranceDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleImage> VehicleImages { get; set; }
        public DbSet<Estimate> Estimates { get; set; }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<CompanyExpense> CompanyExpenses { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<LoginLog> LoginLogs { get; set; }
        public DbSet<InsuranceHistory> InsuranceHistories { get; set; }
        public DbSet<SpecialInsuranceRequest> SpecialInsuranceRequests { get; set; }
        public DbSet<CustomerSupportRequest> CustomerSupportRequests { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<BannerImage> BannerImages { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=carinsurance.db");
            }
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     // Dữ liệu mẫu cho bảng Users
        //     modelBuilder.Entity<User>().HasData(
        //         new User { user_id = 1, username = "john_doe", password = "hashed_password", full_name = "John Doe", email = "john.doe@example.com", phone_number = "1234567890", address = "123 Main St, Springfield", user_type = "Customer", created_at = DateTime.Now },
        //         new User { user_id = 2, username = "admin", password = "hashed_password", full_name = "Admin User", email = "admin@example.com", phone_number = "0987654321", address = "456 Admin St, Springfield", user_type = "Employee", created_at = DateTime.Now }
        //     );

        //     // Dữ liệu mẫu cho bảng Customers
        //     modelBuilder.Entity<Customer>().HasData(
        //         new Customer { customer_id = 1, user_id = 1, full_name = "John Doe", phone_number = "1234567890", address = "123 Main St, Springfield" },
        //         new Customer { customer_id = 2, user_id = 2, full_name = "Admin User", phone_number = "0987654321", address = "456 Admin St, Springfield" }
        //     );

        //     // Dữ liệu mẫu cho bảng Vehicles
        //     modelBuilder.Entity<Vehicle>().HasData(
        //         new Vehicle { vehicle_id = 1, customer_id = 1, vehicle_name = "Toyota Camry", vehicle_model = "2022", vehicle_version = "XLE", body_number = "ABC123", engine_number = "XYZ456", vehicle_rate = 20000 },
        //         new Vehicle { vehicle_id = 2, customer_id = 2, vehicle_name = "Honda Accord", vehicle_model = "2021", vehicle_version = "Sport", body_number = "DEF789", engine_number = "LMN123", vehicle_rate = 18000 }
        //     );

        //     // Dữ liệu mẫu cho bảng VehicleImages
        //     modelBuilder.Entity<VehicleImage>().HasData(
        //         new VehicleImage { image_id = 1, vehicle_id = 1, image_type = "Vehicle", image_path = "/images/vehicle1.jpg", description = "Front view of Toyota Camry", uploaded_at = DateTime.Now },
        //         new VehicleImage { image_id = 2, vehicle_id = 2, image_type = "Vehicle", image_path = "/images/vehicle2.jpg", description = "Side view of Honda Accord", uploaded_at = DateTime.Now }
        //     );

        //     // Dữ liệu mẫu cho bảng Estimates
        //     modelBuilder.Entity<Estimate>().HasData(
        //         new Estimate { estimate_id = 1, customer_id = 1, vehicle_id = 1, policy_type = "Comprehensive", warranty = "2 Years", estimate_amount = 5000, created_at = DateTime.Now },
        //         new Estimate { estimate_id = 2, customer_id = 2, vehicle_id = 2, policy_type = "Third Party", warranty = "1 Year", estimate_amount = 3000, created_at = DateTime.Now }
        //     );

        //     // Dữ liệu mẫu cho bảng InsurancePolicies
        //     modelBuilder.Entity<InsurancePolicy>().HasData(
        //         new InsurancePolicy { policy_id = 1, customer_id = 1, vehicle_id = 1, policy_number = "POL12345", policy_start_date = DateTime.Now, policy_end_date = DateTime.Now.AddYears(1), policy_type = "Comprehensive", policy_amount = 5000 },
        //         new InsurancePolicy { policy_id = 2, customer_id = 2, vehicle_id = 2, policy_number = "POL67890", policy_start_date = DateTime.Now, policy_end_date = DateTime.Now.AddYears(1), policy_type = "Third Party", policy_amount = 3000 }
        //     );

        //     // Dữ liệu mẫu cho bảng Payments
        //     modelBuilder.Entity<Payment>().HasData(
        //         new Payment { payment_id = 1, customer_id = 1, policy_id = 1, bill_number = "BILL12345", payment_date = DateTime.Now, payment_amount = 5000 },
        //         new Payment { payment_id = 2, customer_id = 2, policy_id = 2, bill_number = "BILL67890", payment_date = DateTime.Now, payment_amount = 3000 }
        //     );

        //     // Dữ liệu mẫu cho bảng Claims
        //     modelBuilder.Entity<Claim>().HasData(
        //         new Claim { claim_id = 1, policy_id = 1, claim_number = "CLAIM12345", accident_date = DateTime.Now, place_of_accident = "Main St, Springfield", insured_amount = 5000, claimable_amount = 4500 },
        //         new Claim { claim_id = 2, policy_id = 2, claim_number = "CLAIM67890", accident_date = DateTime.Now, place_of_accident = "Oak St, Springfield", insured_amount = 3000, claimable_amount = 2500 }
        //     );

        //     // Dữ liệu mẫu cho bảng CompanyExpenses
        //     modelBuilder.Entity<CompanyExpense>().HasData(
        //         new CompanyExpense { expense_id = 1, expense_type = "Advertising", expense_date = DateTime.Now, expense_amount = 1000, created_at = DateTime.Now },
        //         new CompanyExpense { expense_id = 2, expense_type = "Salaries", expense_date = DateTime.Now, expense_amount = 5000, created_at = DateTime.Now }
        //     );

        //     // Dữ liệu mẫu cho bảng Reports
        //     modelBuilder.Entity<Report>().HasData(
        //         new Report { report_id = 1, report_type = "Financial Report", generated_at = DateTime.Now, description = "Q1 2024 financial performance" },
        //         new Report { report_id = 2, report_type = "Claim Report", generated_at = DateTime.Now, description = "Claims data for 2024" }
        //     );

        //     // Dữ liệu mẫu cho bảng LoginLogs
        //     modelBuilder.Entity<LoginLog>().HasData(
        //         new LoginLog { log_id = 1, user_id = 1, login_time = DateTime.Now, ip_address = "192.168.1.1" },
        //         new LoginLog { log_id = 2, user_id = 2, login_time = DateTime.Now, ip_address = "192.168.1.2" }
        //     );

        //     // Dữ liệu mẫu cho bảng InsuranceHistory
        //     modelBuilder.Entity<InsuranceHistory>().HasData(
        //         new InsuranceHistory { history_id = 1, policy_id = 1, change_date = DateTime.Now, change_type = "Policy Created", old_value = "", new_value = "Comprehensive - 5000", changed_by = 1 },
        //         new InsuranceHistory { history_id = 2, policy_id = 2, change_date = DateTime.Now, change_type = "Policy Created", old_value = "", new_value = "Third Party - 3000", changed_by = 2 }
        //     );

        //     // Dữ liệu mẫu cho bảng SpecialInsuranceRequests
        //     modelBuilder.Entity<SpecialInsuranceRequest>().HasData(
        //         new SpecialInsuranceRequest { request_id = 1, customer_id = 1, vehicle_id = 1, request_type = "Coverage Extension", request_description = "Extend coverage for 1 more year", request_date = DateTime.Now, status = "Pending" }
        //     );

        //     // Dữ liệu mẫu cho bảng CustomerSupportRequests
        //     modelBuilder.Entity<CustomerSupportRequest>().HasData(
        //         new CustomerSupportRequest
        //         {
        //             support_id = 1,
        //             customer_id = 1,
        //             support_type = "Claim Assistance",
        //             support_description = "Need help with claim process",
        //             support_payment = "Unpaid", // Giá trị của support_payment có thể là 'Paid' hoặc 'Unpaid' tùy theo yêu cầu
        //             support_status = "Open", // 'Open', 'Closed', 'Pending'
        //             created_at = DateTime.Now,
        //             resolved_at = null, // chưa được giải quyết, nên là null
        //             resolved_by = 2 // Giả sử user_id = 2 (Admin) đã giải quyết
        //         },
        //         new CustomerSupportRequest
        //         {
        //             support_id = 2,
        //             customer_id = 2,
        //             support_type = "Policy Inquiry",
        //             support_description = "Ask about policy coverage",
        //             support_payment = "Paid", // Trạng thái thanh toán đã được xử lý
        //             support_status = "Closed", // Đã được giải quyết
        //             created_at = DateTime.Now.AddDays(-2), // Ngày tạo cách đây 2 ngày
        //             resolved_at = DateTime.Now, // Đã giải quyết ngay hôm nay
        //             resolved_by = 1 // Giả sử user_id = 1 (Customer Service) đã giải quyết
        //         },
        //         new CustomerSupportRequest
        //         {
        //             support_id = 3,
        //             customer_id = 1,
        //             support_type = "Refund Request",
        //             support_description = "Request for refund due to policy change",
        //             support_payment = "Pending", // Trạng thái thanh toán vẫn đang chờ xử lý
        //             support_status = "Pending", // Đang chờ giải quyết
        //             created_at = DateTime.Now.AddDays(-1), // Ngày tạo cách đây 1 ngày
        //             resolved_at = null, // Chưa được giải quyết
        //             resolved_by = 2 // Đang chờ giải quyết bởi admin
        //         }
        //     );

        //     // Dữ liệu mẫu cho bảng Notifications
        //     modelBuilder.Entity<Notification>().HasData(
        //         new Notification { notification_id = 1, customer_id = 1, message_type = "Policy Update", message_content = "Your policy has been updated", sent_at = DateTime.Now, is_read = false },
        //         new Notification { notification_id = 2, customer_id = 2, message_type = "Payment Reminder", message_content = "Your payment is due", sent_at = DateTime.Now, is_read = false }
        //     );

        //     // Dữ liệu mẫu cho bảng Contacts
        //     modelBuilder.Entity<Contact>().HasData(
        //         new Contact { id = 1, customer_id = 1, full_name = "Jane Doe", email = "jane.doe@example.com", phone = "1122334455", subject = "Claim Inquiry", message = "I have a question about my claim", date_added = DateTime.Now, date_modified = DateTime.Now, },
        //         new Contact { id = 2, customer_id = 2, full_name = "Mark Smith", email = "mark.smith@example.com", phone = "2233445566", subject = "Policy Query", message = "Can I change my policy type?", date_added = DateTime.Now, date_modified = DateTime.Now, }
        //     );

        //     // Dữ liệu mẫu cho bảng BannerImages
        //     modelBuilder.Entity<BannerImage>().HasData(
        //         new BannerImage { id = 1, image = "/images/banner1.jpg", link = "https://example.com", sort_order = 1, },
        //         new BannerImage { id = 2, image = "/images/banner2.jpg", link = "https://example2.com", sort_order = 2, }
        //     );

        //     // Dữ liệu mẫu cho bảng Comments
        //     modelBuilder.Entity<Comment>().HasData(
        //         new Comment { comment_id = 1, customer_id = 1, comment_text = "Great policy, very affordable!", rating = 5, created_at = DateTime.Now, status = "Active" },
        //         new Comment { comment_id = 2, customer_id = 2, comment_text = "The claim process was very smooth.", rating = 4, created_at = DateTime.Now, status = "Archived" }
        //     );
        // }

    }

}
