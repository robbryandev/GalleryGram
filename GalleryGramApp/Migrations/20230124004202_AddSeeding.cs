using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalleryGram.Migrations
{
    public partial class AddSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16322769-f263-48cd-88c4-50b160efe4df", 0, "0c40b4fc-c895-462a-af09-4dfdfc915d95", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEEJUloTvSxUPLIb7TXwdvJ8UTtT6kkkYEa/tVAzI17D9cSW+EHqmMM4RS94LmEL9+w==", null, false, "48040892-e4ca-4a67-8508-71de07d08b45", false, "robert@gmail.com" },
                    { "7e8ea7dc-e779-4594-94b0-6b3efb0bf16d", 0, "656aa313-1e50-4c8e-9308-16a3709933e6", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEC5Bdm2ctFuOsOAjqPgqHHhfpbh+f6TwZE4d2wTaKYnmklKok6FwO6eTRuVZ6KIflw==", null, false, "0c25c040-a5a0-428d-80ba-261fe7b61d1a", false, "david@gmail.com" },
                    { "b70a4e33-2d6b-466c-b3de-ef108c8db215", 0, "3f443686-f603-4917-835c-5a40ab139422", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEF2Nn/yhXx4zgIS5OWvzPFVNAgkp3rmP5TsAWLDeCYqaynp9+3i8sidTYsyiEk053w==", null, false, "9314f3cf-b80e-46ed-b7b6-5d5b78fa1435", false, "lucas@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "picture_id", "fileName", "user_id" },
                values: new object[,]
                {
                    { 1, "https://via.placeholder.com/600/92c952", "7e8ea7dc-e779-4594-94b0-6b3efb0bf16d" },
                    { 2, "https://via.placeholder.com/600/771796", "7e8ea7dc-e779-4594-94b0-6b3efb0bf16d" },
                    { 3, "https://via.placeholder.com/600/24f355", "7e8ea7dc-e779-4594-94b0-6b3efb0bf16d" },
                    { 4, "https://via.placeholder.com/600/d32776", "16322769-f263-48cd-88c4-50b160efe4df" },
                    { 5, "https://via.placeholder.com/600/f66b97", "16322769-f263-48cd-88c4-50b160efe4df" },
                    { 6, "https://via.placeholder.com/600/56a8c2", "16322769-f263-48cd-88c4-50b160efe4df" },
                    { 7, "https://via.placeholder.com/600/b0f7cc", "16322769-f263-48cd-88c4-50b160efe4df" },
                    { 8, "https://via.placeholder.com/600/54176f", "16322769-f263-48cd-88c4-50b160efe4df" },
                    { 9, "https://via.placeholder.com/600/51aa97", "16322769-f263-48cd-88c4-50b160efe4df" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16322769-f263-48cd-88c4-50b160efe4df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e8ea7dc-e779-4594-94b0-6b3efb0bf16d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b70a4e33-2d6b-466c-b3de-ef108c8db215");

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 9);
        }
    }
}
