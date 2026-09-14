using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment10._3.Migrations
{
    /// <inheritdoc />
    public partial class SeedCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Make", "Mileage", "Model", "Price", "VIN", "Year" },
                values: new object[,]
                {
                    { 1, "Silver", "Honda", 42000, "Accord", 18500m, "1HGCM82633A004352", 2019 },
                    { 2, "Blue", "Ford", 27500, "F-150", 34900m, "1FTFW1ET5EKF51234", 2021 },
                    { 3, "White", "Tesla", 15200, "Model 3", 38750m, "5YJ3E1EA7KF317890", 2022 },
                    { 4, "Red", "Toyota", 68000, "Prius", 14200m, "JTDKN3DU0A0123456", 2017 },
                    { 5, "Black", "BMW", 51000, "328i", 21300m, "WBA3A5C51CF256789", 2018 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
