using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalleryGram.Migrations
{
    public partial class AddLikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b46ef72-0615-4da7-84e9-8c3cb49f2659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e8b26c-14bb-49ab-9705-7aafde4c52be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf4fb2e-dcda-495d-bd7f-9e91bbf3da81");

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    like_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    picture_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.like_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0e841f3a-9ee5-46e2-8561-cab8f7535527", 0, "929cecd9-d501-41c4-b2d3-d0b3efd0b67d", null, false, false, null, null, "LUCAS@GMAIL.COM", "AQAAAAEAACcQAAAAEGZy+D2b//ulBaJdYi1vtXbVlnGqIRHEbUG9k8pkuflTjAfK49dl2trzdC/2/Dm7Ag==", null, false, "73a5e53e-f625-49fc-ade9-e1a400704e76", false, "lucas@gmail.com" },
                    { "8014bb8d-85c6-4c1c-afc9-48a3f372b896", 0, "fd0b5dd8-8681-461a-8279-7e3a7443e532", null, false, false, null, null, "ROBERT@GMAIL.COM", "AQAAAAEAACcQAAAAEFJIYxGpNb+xXwLnOLIhnBTQCi6H4MSAyYR50SwOtO0VPSYRnag0Bw6tzsKzZ2mKCg==", null, false, "a5ce41f5-1065-4ae8-85bd-e24330c35c69", false, "robert@gmail.com" },
                    { "cf9e094a-0e5f-4714-bf67-b79d209e6a26", 0, "4bf7774a-506f-4a81-be1f-ce9297598bb8", null, false, false, null, null, "DAVID@GMAIL.COM", "AQAAAAEAACcQAAAAEIaocmm30r+vOAI4z4SZkYPNKB9KZSZLsc4rJ4p0S9kLIvooBKZJr7Qg/hlbOGDhwQ==", null, false, "cccef78f-1e55-4564-a09a-5d12f9add460", false, "david@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 1,
                column: "user_id",
                value: "cf9e094a-0e5f-4714-bf67-b79d209e6a26");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 2,
                column: "user_id",
                value: "cf9e094a-0e5f-4714-bf67-b79d209e6a26");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 3,
                column: "user_id",
                value: "cf9e094a-0e5f-4714-bf67-b79d209e6a26");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 4,
                column: "user_id",
                value: "8014bb8d-85c6-4c1c-afc9-48a3f372b896");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 5,
                column: "user_id",
                value: "8014bb8d-85c6-4c1c-afc9-48a3f372b896");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 6,
                column: "user_id",
                value: "8014bb8d-85c6-4c1c-afc9-48a3f372b896");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 7,
                column: "user_id",
                value: "0e841f3a-9ee5-46e2-8561-cab8f7535527");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 8,
                column: "user_id",
                value: "0e841f3a-9ee5-46e2-8561-cab8f7535527");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 9,
                column: "user_id",
                value: "0e841f3a-9ee5-46e2-8561-cab8f7535527");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e841f3a-9ee5-46e2-8561-cab8f7535527");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8014bb8d-85c6-4c1c-afc9-48a3f372b896");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf9e094a-0e5f-4714-bf67-b79d209e6a26");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5b46ef72-0615-4da7-84e9-8c3cb49f2659", 0, "0656a155-1af2-4380-8f87-2301a5309ff9", null, false, false, null, null, "ROBERT@GMAIL.COM", "AQAAAAEAACcQAAAAEF6me+SFAnHf04CuRjN78R3UBKMWeSKiBs/Dj50T9hIJrGxZgp4xBvEQlCyDBaBv1Q==", null, false, "b2b4314b-6954-4276-bab8-463c4b8f8523", false, "robert@gmail.com" },
                    { "69e8b26c-14bb-49ab-9705-7aafde4c52be", 0, "73f007d2-2e21-44b0-960b-840db5365e92", null, false, false, null, null, "DAVID@GMAIL.COM", "AQAAAAEAACcQAAAAEIUTTKK2bvaMBN8fTbK/CUHXnZdh/kAkvPOwhGdFA2GeGmrnKkau6K9pBv7XnZRGUg==", null, false, "c3ff6bfc-c4ac-45fc-936f-261bc984bc79", false, "david@gmail.com" },
                    { "ddf4fb2e-dcda-495d-bd7f-9e91bbf3da81", 0, "6da13257-23d8-443a-9876-4213d117edb5", null, false, false, null, null, "LUCAS@GMAIL.COM", "AQAAAAEAACcQAAAAEEhunaGYnv8tffs+jeOyl2S5ztr3shcRehnLr2A8OlSgKKmSgoEBIKJLRo+SrzxE+A==", null, false, "fdefa8b3-c47d-4048-ac21-c5885c256d01", false, "lucas@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 1,
                column: "user_id",
                value: "69e8b26c-14bb-49ab-9705-7aafde4c52be");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 2,
                column: "user_id",
                value: "69e8b26c-14bb-49ab-9705-7aafde4c52be");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 3,
                column: "user_id",
                value: "69e8b26c-14bb-49ab-9705-7aafde4c52be");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 4,
                column: "user_id",
                value: "5b46ef72-0615-4da7-84e9-8c3cb49f2659");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 5,
                column: "user_id",
                value: "5b46ef72-0615-4da7-84e9-8c3cb49f2659");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 6,
                column: "user_id",
                value: "5b46ef72-0615-4da7-84e9-8c3cb49f2659");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 7,
                column: "user_id",
                value: "ddf4fb2e-dcda-495d-bd7f-9e91bbf3da81");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 8,
                column: "user_id",
                value: "ddf4fb2e-dcda-495d-bd7f-9e91bbf3da81");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 9,
                column: "user_id",
                value: "ddf4fb2e-dcda-495d-bd7f-9e91bbf3da81");
        }
    }
}
