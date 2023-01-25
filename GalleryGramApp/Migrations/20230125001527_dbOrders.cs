using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalleryGram.Migrations
{
    public partial class dbOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbOrders",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    confirmation_id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cost = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbOrders", x => x.order_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07b65ed7-2e38-48aa-8b53-2a8ac1c09a14", 0, "18b3af8b-db75-41fa-9372-04b9a21870cc", null, false, false, null, null, "ROBERT@GMAIL.COM", "AQAAAAEAACcQAAAAENHr2MVXV8XhDsPUnM5e4B8y7jTCqwJgdB1rzaWf6wQUrV5HkGFZ6vmpA7Y7HdpEXA==", null, false, "e57883c7-3b9c-4764-b946-91da5b65cfd1", false, "robert@gmail.com" },
                    { "10b0264f-6519-4e74-92d5-691c1550ee2e", 0, "e72c1efd-8afa-483e-afd3-6ba457f3258e", null, false, false, null, null, "LUCAS@GMAIL.COM", "AQAAAAEAACcQAAAAEN1fD+vuPJLWeY1tDW6MDFjFQAhwiJa8SjQy6C4UGvr0y/CkKIvIpDOqU29DzXr35A==", null, false, "2b1df124-7843-4177-a874-5c353d75243f", false, "lucas@gmail.com" },
                    { "689c3af3-0b75-47fa-953f-3dd4b885629c", 0, "4f0a4b05-743f-4153-8142-62dcfe7b05f1", null, false, false, null, null, "DAVID@GMAIL.COM", "AQAAAAEAACcQAAAAEA1xUH4qhlhH2+S0JY8CqjxQ4CmOS3zd9QXt3i63/GAJbjtlLDOB1Q60uAo6YLTGtw==", null, false, "95e307d0-e2d8-4199-8c98-0e5ebbef14b0", false, "david@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "picture_id", "fileName", "user_id" },
                values: new object[,]
                {
                    { 1, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg", "689c3af3-0b75-47fa-953f-3dd4b885629c" },
                    { 2, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/npm/npm-original-wordmark.svg", "689c3af3-0b75-47fa-953f-3dd4b885629c" },
                    { 3, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/msdos/msdos-original.svg", "689c3af3-0b75-47fa-953f-3dd4b885629c" },
                    { 4, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/markdown/markdown-original.svg", "07b65ed7-2e38-48aa-8b53-2a8ac1c09a14" },
                    { 5, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/linkedin/linkedin-original.svg", "07b65ed7-2e38-48aa-8b53-2a8ac1c09a14" },
                    { 6, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jquery/jquery-original.svg", "07b65ed7-2e38-48aa-8b53-2a8ac1c09a14" },
                    { 7, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jest/jest-plain.svg", "10b0264f-6519-4e74-92d5-691c1550ee2e" },
                    { 8, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original.svg", "10b0264f-6519-4e74-92d5-691c1550ee2e" },
                    { 9, "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg", "10b0264f-6519-4e74-92d5-691c1550ee2e" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbOrders");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07b65ed7-2e38-48aa-8b53-2a8ac1c09a14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10b0264f-6519-4e74-92d5-691c1550ee2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "689c3af3-0b75-47fa-953f-3dd4b885629c");

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
