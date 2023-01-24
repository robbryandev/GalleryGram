using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalleryGram.Migrations
{
    public partial class normalizeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "1297989c-328c-481f-b8de-f3b8399c2837", 0, "7c62fea3-8e27-4a59-bda8-8785f15bdfa8", null, false, false, null, null, "LUCAS@GMAIL.COM", "AQAAAAEAACcQAAAAEMLcPoxHfWtOWosvwNnKp65U0eup3pXh5uwB5pCqDsCFD7mwfHD0V3dH4NoKH0N1Eg==", null, false, "786f16ca-960b-4175-b5ed-da73a2093212", false, "lucas@gmail.com" },
                    { "2f8a9373-7eb6-4dc0-8e81-525196fac675", 0, "e374fc31-01da-445e-8611-f85cdcbe2de3", null, false, false, null, null, "ROBERT@GMAIL.COM", "AQAAAAEAACcQAAAAELeysjklznfkTsUYdwup8OYN/JjfAvbHW4VHZm3Kg+qFVr0sI7GyPETJ3RbvcgDlFQ==", null, false, "d93ee0f5-b369-4603-a6fe-0cd1dc681ae7", false, "robert@gmail.com" },
                    { "b820f18d-8849-48ab-bcea-dcda0f2e431c", 0, "340911e1-d017-448c-81f2-8ec4b96984a6", null, false, false, null, null, "DAVID@GMAIL.COM", "AQAAAAEAACcQAAAAEOufNIUUCb35yqbXtcgz7RfYQ2A/mDoA27KJzCPTRC/8LquZAskLNEyBCKw4RE9W/Q==", null, false, "013641af-a96d-4f68-8ab9-39d24331efe3", false, "david@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 1,
                column: "user_id",
                value: "b820f18d-8849-48ab-bcea-dcda0f2e431c");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 2,
                column: "user_id",
                value: "b820f18d-8849-48ab-bcea-dcda0f2e431c");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 3,
                column: "user_id",
                value: "b820f18d-8849-48ab-bcea-dcda0f2e431c");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 4,
                column: "user_id",
                value: "2f8a9373-7eb6-4dc0-8e81-525196fac675");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 5,
                column: "user_id",
                value: "2f8a9373-7eb6-4dc0-8e81-525196fac675");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 6,
                column: "user_id",
                value: "2f8a9373-7eb6-4dc0-8e81-525196fac675");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 7,
                column: "user_id",
                value: "2f8a9373-7eb6-4dc0-8e81-525196fac675");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 8,
                column: "user_id",
                value: "2f8a9373-7eb6-4dc0-8e81-525196fac675");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 9,
                column: "user_id",
                value: "2f8a9373-7eb6-4dc0-8e81-525196fac675");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297989c-328c-481f-b8de-f3b8399c2837");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f8a9373-7eb6-4dc0-8e81-525196fac675");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b820f18d-8849-48ab-bcea-dcda0f2e431c");

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
    }
}
