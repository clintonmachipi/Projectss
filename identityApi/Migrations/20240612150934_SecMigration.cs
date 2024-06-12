using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace identityApi.Migrations
{
    /// <inheritdoc />
    public partial class SecMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2cc13d6a-6302-454a-b665-6ed0190951b5", null, "admin", "seller" },
                    { "5ecd3116-130b-4a6b-b2f8-e291389f58c7", null, "client", "client" },
                    { "d3d337a9-6821-48b9-bc1f-06c46c8ee3e8", null, "seller", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cc13d6a-6302-454a-b665-6ed0190951b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ecd3116-130b-4a6b-b2f8-e291389f58c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d337a9-6821-48b9-bc1f-06c46c8ee3e8");
        }
    }
}
