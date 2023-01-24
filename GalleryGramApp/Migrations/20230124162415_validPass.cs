using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalleryGram.Migrations
{
    public partial class validPass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9614434b-cfbf-4c64-80e6-bdd29a0c14cd", 0, "76b357d9-4d35-4e6c-a841-ae5c3e8a3f6d", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEM/WuiQ6zsdqGD/7gCnbkaMfHkBBCTllTYg7vCvK12RqvJMR8HlBrM6OT4ut6lCU8A==", null, false, "5205ff62-9ecf-408f-a276-1eea1231001c", false, "david@gmail.com" },
                    { "e3175f9a-ee87-42f6-a2f1-0db1daf2ef2f", 0, "12fbd3aa-9bae-47e6-a889-7aa061eac212", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEOpOKnoVDZN1pxAWyRSFwNvjXxnuJnIuttCcEmJhqWHWNWwxL9Zd8kRGYuDiiKeBsA==", null, false, "f56654de-a5a1-4894-b055-7dd51162d734", false, "robert@gmail.com" },
                    { "f1f2fe98-e656-4132-8e5b-d5d331f20388", 0, "2b323654-95b3-4eff-9e80-15927e8a9e72", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEFMLxnJ8zMLCLpAavQLjwCPfDBXFbJDroXJaGpotkN4OgV3QItIB0XWcuKDuUDMyWA==", null, false, "1132fb17-f1bc-44cf-b6ef-3ea5e5702f9d", false, "lucas@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 1,
                column: "user_id",
                value: "9614434b-cfbf-4c64-80e6-bdd29a0c14cd");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 2,
                column: "user_id",
                value: "9614434b-cfbf-4c64-80e6-bdd29a0c14cd");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 3,
                column: "user_id",
                value: "9614434b-cfbf-4c64-80e6-bdd29a0c14cd");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 4,
                column: "user_id",
                value: "e3175f9a-ee87-42f6-a2f1-0db1daf2ef2f");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 5,
                column: "user_id",
                value: "e3175f9a-ee87-42f6-a2f1-0db1daf2ef2f");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 6,
                column: "user_id",
                value: "e3175f9a-ee87-42f6-a2f1-0db1daf2ef2f");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 7,
                column: "user_id",
                value: "e3175f9a-ee87-42f6-a2f1-0db1daf2ef2f");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 8,
                column: "user_id",
                value: "e3175f9a-ee87-42f6-a2f1-0db1daf2ef2f");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 9,
                column: "user_id",
                value: "e3175f9a-ee87-42f6-a2f1-0db1daf2ef2f");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9614434b-cfbf-4c64-80e6-bdd29a0c14cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3175f9a-ee87-42f6-a2f1-0db1daf2ef2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1f2fe98-e656-4132-8e5b-d5d331f20388");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16322769-f263-48cd-88c4-50b160efe4df", 0, "0c40b4fc-c895-462a-af09-4dfdfc915d95", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEEJUloTvSxUPLIb7TXwdvJ8UTtT6kkkYEa/tVAzI17D9cSW+EHqmMM4RS94LmEL9+w==", null, false, "48040892-e4ca-4a67-8508-71de07d08b45", false, "robert@gmail.com" },
                    { "7e8ea7dc-e779-4594-94b0-6b3efb0bf16d", 0, "656aa313-1e50-4c8e-9308-16a3709933e6", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEC5Bdm2ctFuOsOAjqPgqHHhfpbh+f6TwZE4d2wTaKYnmklKok6FwO6eTRuVZ6KIflw==", null, false, "0c25c040-a5a0-428d-80ba-261fe7b61d1a", false, "david@gmail.com" },
                    { "b70a4e33-2d6b-466c-b3de-ef108c8db215", 0, "3f443686-f603-4917-835c-5a40ab139422", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEF2Nn/yhXx4zgIS5OWvzPFVNAgkp3rmP5TsAWLDeCYqaynp9+3i8sidTYsyiEk053w==", null, false, "9314f3cf-b80e-46ed-b7b6-5d5b78fa1435", false, "lucas@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 1,
                column: "user_id",
                value: "7e8ea7dc-e779-4594-94b0-6b3efb0bf16d");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 2,
                column: "user_id",
                value: "7e8ea7dc-e779-4594-94b0-6b3efb0bf16d");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 3,
                column: "user_id",
                value: "7e8ea7dc-e779-4594-94b0-6b3efb0bf16d");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 4,
                column: "user_id",
                value: "16322769-f263-48cd-88c4-50b160efe4df");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 5,
                column: "user_id",
                value: "16322769-f263-48cd-88c4-50b160efe4df");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 6,
                column: "user_id",
                value: "16322769-f263-48cd-88c4-50b160efe4df");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 7,
                column: "user_id",
                value: "16322769-f263-48cd-88c4-50b160efe4df");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 8,
                column: "user_id",
                value: "16322769-f263-48cd-88c4-50b160efe4df");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 9,
                column: "user_id",
                value: "16322769-f263-48cd-88c4-50b160efe4df");
        }
    }
}
