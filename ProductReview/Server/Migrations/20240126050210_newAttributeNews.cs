using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductReview.Server.Migrations
{
    /// <inheritdoc />
    public partial class newAttributeNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f269b0d-ae58-40ec-a7b3-47afb8af2704", "AQAAAAIAAYagAAAAEAln3/HgDaAarYpFi/3i6n/2dQLggLBB/vq74M2nsW8udi1XNT7fnn8iFmlrj2ec2A==", "5462e527-ba73-47ca-bb4f-980f8f4f96e7" });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 577, DateTimeKind.Local).AddTicks(868), new DateTime(2024, 1, 26, 13, 2, 10, 577, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 577, DateTimeKind.Local).AddTicks(910), new DateTime(2024, 1, 26, 13, 2, 10, 577, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 577, DateTimeKind.Local).AddTicks(912), new DateTime(2024, 1, 26, 13, 2, 10, 577, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 577, DateTimeKind.Local).AddTicks(914), new DateTime(2024, 1, 26, 13, 2, 10, 577, DateTimeKind.Local).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(8367), new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(8381), new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(9261), new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(9263), new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "DateCreated", "DateUpdated" },
                values: new object[] { "Apple has confirmed that they will not have iphone 16 and will jump to 17", new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(9441), new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "DateCreated", "DateUpdated" },
                values: new object[] { "Samsung's Z fold 6 design leaked and it looks amazing", new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(9444), new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(8889), new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(8892), new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(9092), new DateTime(2024, 1, 26, 13, 2, 10, 527, DateTimeKind.Local).AddTicks(9093) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "News");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae4b344b-9262-4f1c-aeb6-63ae9396ba57", "AQAAAAIAAYagAAAAECgZbY0oJAN/OhkhhskJLsLIAzl0jSZI9UF2sQ9G3XmprzuQ2jKAs7dSl7oaiJHsGA==", "1229b476-520b-4281-8411-99a3d67e49fe" });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 824, DateTimeKind.Local).AddTicks(6011), new DateTime(2024, 1, 24, 16, 39, 30, 824, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 824, DateTimeKind.Local).AddTicks(6027), new DateTime(2024, 1, 24, 16, 39, 30, 824, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 824, DateTimeKind.Local).AddTicks(6029), new DateTime(2024, 1, 24, 16, 39, 30, 824, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 824, DateTimeKind.Local).AddTicks(6030), new DateTime(2024, 1, 24, 16, 39, 30, 824, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3142), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3159), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3560), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3563), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(4137), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(4139), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(4335), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(4337), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3766), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3769), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3950), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3954), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(3954) });
        }
    }
}
