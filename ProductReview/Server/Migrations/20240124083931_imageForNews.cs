using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductReview.Server.Migrations
{
    /// <inheritdoc />
    public partial class imageForNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(4335), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(4336), null });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(4337), new DateTime(2024, 1, 24, 16, 39, 30, 775, DateTimeKind.Local).AddTicks(4338), null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "News");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0d1b6ac-b17d-4e7e-a3b7-412bd49358f8", "AQAAAAIAAYagAAAAENq8eO/xJuFJv2gANbnwtXJO2j4LyIeXqi5gQSljDMoDvRO4Xcku66B1IFpjdv0KKw==", "ec34844f-c1fe-4776-ac5b-2d06c3fa4d96" });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 887, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 1, 23, 11, 3, 12, 887, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 887, DateTimeKind.Local).AddTicks(287), new DateTime(2024, 1, 23, 11, 3, 12, 887, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 887, DateTimeKind.Local).AddTicks(289), new DateTime(2024, 1, 23, 11, 3, 12, 887, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 887, DateTimeKind.Local).AddTicks(293), new DateTime(2024, 1, 23, 11, 3, 12, 887, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(8458), new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(8477), new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(8761), new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(8763), new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(9265), new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(9268), new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(9421), new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(9423), new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(8937), new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(8940), new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(9110), new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(9114), new DateTime(2024, 1, 23, 11, 3, 12, 838, DateTimeKind.Local).AddTicks(9114) });
        }
    }
}
