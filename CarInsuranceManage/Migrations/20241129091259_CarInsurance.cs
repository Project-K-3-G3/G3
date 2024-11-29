using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarInsuranceManage.Migrations
{
    /// <inheritdoc />
    public partial class CarInsurance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BannerImages",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    image = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    link = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    sort_order = table.Column<int>(type: "INTEGER", nullable: false),
                    status = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerImages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyExpenses",
                columns: table => new
                {
                    expense_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    expense_type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    expense_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    expense_amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyExpenses", x => x.expense_id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    report_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    report_type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    generated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.report_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    username = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    full_name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    phone_number = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    address = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    user_type = table.Column<string>(type: "TEXT", nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    user_id = table.Column<int>(type: "INTEGER", nullable: false),
                    full_name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    phone_number = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    address = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customer_id);
                    table.ForeignKey(
                        name: "FK_Customers_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginLogs",
                columns: table => new
                {
                    log_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    user_id = table.Column<int>(type: "INTEGER", nullable: false),
                    login_time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ip_address = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginLogs", x => x.log_id);
                    table.ForeignKey(
                        name: "FK_LoginLogs_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    comment_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    comment_text = table.Column<string>(type: "TEXT", nullable: false),
                    rating = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.comment_id);
                    table.ForeignKey(
                        name: "FK_Comments_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    full_name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    phone = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    subject = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    message = table.Column<string>(type: "TEXT", nullable: false),
                    date_added = table.Column<DateTime>(type: "TEXT", nullable: false),
                    date_modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    status = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contacts_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerSupportRequests",
                columns: table => new
                {
                    support_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    support_type = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    support_description = table.Column<string>(type: "TEXT", nullable: false),
                    support_payment = table.Column<string>(type: "TEXT", nullable: false),
                    support_status = table.Column<string>(type: "TEXT", nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    resolved_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    resolved_by = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSupportRequests", x => x.support_id);
                    table.ForeignKey(
                        name: "FK_CustomerSupportRequests_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerSupportRequests_Users_resolved_by",
                        column: x => x.resolved_by,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    notification_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    message_type = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    message_content = table.Column<string>(type: "TEXT", nullable: false),
                    sent_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    is_read = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.notification_id);
                    table.ForeignKey(
                        name: "FK_Notifications_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    vehicle_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    vehicle_name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    vehicle_model = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    vehicle_version = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    body_number = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    engine_number = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    vehicle_rate = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.vehicle_id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estimates",
                columns: table => new
                {
                    estimate_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    vehicle_id = table.Column<int>(type: "INTEGER", nullable: false),
                    policy_type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    warranty = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    estimate_amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estimates", x => x.estimate_id);
                    table.ForeignKey(
                        name: "FK_Estimates_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estimates_Vehicles_vehicle_id",
                        column: x => x.vehicle_id,
                        principalTable: "Vehicles",
                        principalColumn: "vehicle_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InsurancePolicies",
                columns: table => new
                {
                    policy_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    vehicle_id = table.Column<int>(type: "INTEGER", nullable: false),
                    policy_number = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    policy_start_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    policy_end_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    policy_type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    policy_amount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsurancePolicies", x => x.policy_id);
                    table.ForeignKey(
                        name: "FK_InsurancePolicies_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsurancePolicies_Vehicles_vehicle_id",
                        column: x => x.vehicle_id,
                        principalTable: "Vehicles",
                        principalColumn: "vehicle_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialInsuranceRequests",
                columns: table => new
                {
                    request_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    vehicle_id = table.Column<int>(type: "INTEGER", nullable: false),
                    request_type = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    request_description = table.Column<string>(type: "TEXT", nullable: false),
                    request_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialInsuranceRequests", x => x.request_id);
                    table.ForeignKey(
                        name: "FK_SpecialInsuranceRequests_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecialInsuranceRequests_Vehicles_vehicle_id",
                        column: x => x.vehicle_id,
                        principalTable: "Vehicles",
                        principalColumn: "vehicle_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleImages",
                columns: table => new
                {
                    image_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    vehicle_id = table.Column<int>(type: "INTEGER", nullable: false),
                    image_type = table.Column<string>(type: "TEXT", nullable: false),
                    image_path = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    uploaded_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleImages", x => x.image_id);
                    table.ForeignKey(
                        name: "FK_VehicleImages_Vehicles_vehicle_id",
                        column: x => x.vehicle_id,
                        principalTable: "Vehicles",
                        principalColumn: "vehicle_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    claim_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    policy_id = table.Column<int>(type: "INTEGER", nullable: false),
                    claim_number = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    accident_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    place_of_accident = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    insured_amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    claimable_amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.claim_id);
                    table.ForeignKey(
                        name: "FK_Claims_InsurancePolicies_policy_id",
                        column: x => x.policy_id,
                        principalTable: "InsurancePolicies",
                        principalColumn: "policy_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceHistories",
                columns: table => new
                {
                    history_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    policy_id = table.Column<int>(type: "INTEGER", nullable: false),
                    change_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    change_type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    old_value = table.Column<string>(type: "TEXT", nullable: false),
                    new_value = table.Column<string>(type: "TEXT", nullable: false),
                    changed_by = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceHistories", x => x.history_id);
                    table.ForeignKey(
                        name: "FK_InsuranceHistories_InsurancePolicies_policy_id",
                        column: x => x.policy_id,
                        principalTable: "InsurancePolicies",
                        principalColumn: "policy_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsuranceHistories_Users_changed_by",
                        column: x => x.changed_by,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    payment_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    policy_id = table.Column<int>(type: "INTEGER", nullable: false),
                    bill_number = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    payment_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    payment_amount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.payment_id);
                    table.ForeignKey(
                        name: "FK_Payments_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_InsurancePolicies_policy_id",
                        column: x => x.policy_id,
                        principalTable: "InsurancePolicies",
                        principalColumn: "policy_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BannerImages",
                columns: new[] { "id", "image", "link", "sort_order", "status" },
                values: new object[] { 1, "/images/banner1.jpg", "https://example.com", 1, true });

            migrationBuilder.InsertData(
                table: "CompanyExpenses",
                columns: new[] { "expense_id", "created_at", "expense_amount", "expense_date", "expense_type" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "report_id", "description", "generated_at", "report_type" },
                values: new object[] { 1, "Annual performance report", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Report" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "user_id", "address", "created_at", "email", "full_name", "password", "phone_number", "user_type", "username" },
                values: new object[,]
                {
                    { 1, "123 Main St", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John Doe", "hashed_password1", "1234567890", "Customer", "john_doe" },
                    { 2, "456 Elm St", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.admin@example.com", "Jane Admin", "hashed_password2", "0987654321", "Employee", "jane_admin" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "customer_id", "address", "full_name", "phone_number", "user_id" },
                values: new object[] { 1, "123 Main St", "John Doe", "1234567890", 1 });

            migrationBuilder.InsertData(
                table: "LoginLogs",
                columns: new[] { "log_id", "ip_address", "login_time", "user_id" },
                values: new object[] { 1, "192.168.1.1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "comment_id", "comment_text", "created_at", "customer_id", "rating", "status" },
                values: new object[] { 1, "Excellent service!", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, "Active" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "id", "customer_id", "date_added", "date_modified", "email", "full_name", "message", "phone", "status", "subject" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John Doe", "What is covered under the policy?", "1234567890", true, "Policy Query" });

            migrationBuilder.InsertData(
                table: "CustomerSupportRequests",
                columns: new[] { "support_id", "created_at", "customer_id", "resolved_at", "resolved_by", "support_description", "support_payment", "support_status", "support_type" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, "Question about policy details", "Paid", "Open", "Policy Inquiry" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "notification_id", "customer_id", "is_read", "message_content", "message_type", "sent_at" },
                values: new object[] { 1, 1, false, "Your payment is due soon", "Payment Reminder", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "vehicle_id", "body_number", "customer_id", "engine_number", "vehicle_model", "vehicle_name", "vehicle_rate", "vehicle_version" },
                values: new object[] { 1, "1234ABCD", 1, "ENG5678", "2020", "Toyota Corolla", 20000m, "LE" });

            migrationBuilder.InsertData(
                table: "Estimates",
                columns: new[] { "estimate_id", "created_at", "customer_id", "estimate_amount", "policy_type", "vehicle_id", "warranty" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1500m, "Comprehensive", 1, "1 Year" });

            migrationBuilder.InsertData(
                table: "InsurancePolicies",
                columns: new[] { "policy_id", "customer_id", "policy_amount", "policy_end_date", "policy_number", "policy_start_date", "policy_type", "vehicle_id" },
                values: new object[] { 1, 1, 1500m, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "POL123456", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comprehensive", 1 });

            migrationBuilder.InsertData(
                table: "SpecialInsuranceRequests",
                columns: new[] { "request_id", "customer_id", "request_date", "request_description", "request_type", "status", "vehicle_id" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extend policy coverage by 6 months", "Extended Coverage", "Pending", 1 });

            migrationBuilder.InsertData(
                table: "VehicleImages",
                columns: new[] { "image_id", "description", "image_path", "image_type", "uploaded_at", "vehicle_id" },
                values: new object[] { 1, "Front view of Toyota Corolla", "/images/vehicle1.jpg", "Vehicle", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Claims",
                columns: new[] { "claim_id", "CreatedAt", "accident_date", "claim_number", "claimable_amount", "insured_amount", "place_of_accident", "policy_id" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLAIM001", 1400m, 1500m, "Highway 1", 1 });

            migrationBuilder.InsertData(
                table: "InsuranceHistories",
                columns: new[] { "history_id", "change_date", "change_type", "changed_by", "new_value", "old_value", "policy_id" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Policy Created", 1, "Comprehensive Policy - $1500", "", 1 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "payment_id", "bill_number", "customer_id", "payment_amount", "payment_date", "policy_id" },
                values: new object[] { 1, "BILL123", 1, 1500m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Claims_policy_id",
                table: "Claims",
                column: "policy_id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_customer_id",
                table: "Comments",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_customer_id",
                table: "Contacts",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_user_id",
                table: "Customers",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSupportRequests_customer_id",
                table: "CustomerSupportRequests",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSupportRequests_resolved_by",
                table: "CustomerSupportRequests",
                column: "resolved_by");

            migrationBuilder.CreateIndex(
                name: "IX_Estimates_customer_id",
                table: "Estimates",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Estimates_vehicle_id",
                table: "Estimates",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceHistories_changed_by",
                table: "InsuranceHistories",
                column: "changed_by");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceHistories_policy_id",
                table: "InsuranceHistories",
                column: "policy_id");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_customer_id",
                table: "InsurancePolicies",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_vehicle_id",
                table: "InsurancePolicies",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_LoginLogs_user_id",
                table: "LoginLogs",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_customer_id",
                table: "Notifications",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_customer_id",
                table: "Payments",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_policy_id",
                table: "Payments",
                column: "policy_id");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialInsuranceRequests_customer_id",
                table: "SpecialInsuranceRequests",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialInsuranceRequests_vehicle_id",
                table: "SpecialInsuranceRequests",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImages_vehicle_id",
                table: "VehicleImages",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_customer_id",
                table: "Vehicles",
                column: "customer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BannerImages");

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CompanyExpenses");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "CustomerSupportRequests");

            migrationBuilder.DropTable(
                name: "Estimates");

            migrationBuilder.DropTable(
                name: "InsuranceHistories");

            migrationBuilder.DropTable(
                name: "LoginLogs");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "SpecialInsuranceRequests");

            migrationBuilder.DropTable(
                name: "VehicleImages");

            migrationBuilder.DropTable(
                name: "InsurancePolicies");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
