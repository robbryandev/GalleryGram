using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalleryGram.Migrations
{
    public partial class differentImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76eda766-b4fa-4389-a8e6-c4fe85be42b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "810e1de1-a854-4f5e-bb32-cf597c60c163");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f7949b4-c254-4616-ac70-f5560eeeedf2");

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
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg", "69e8b26c-14bb-49ab-9705-7aafde4c52be" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 2,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/npm/npm-original-wordmark.svg", "69e8b26c-14bb-49ab-9705-7aafde4c52be" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 3,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/msdos/msdos-original.svg", "69e8b26c-14bb-49ab-9705-7aafde4c52be" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 4,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/markdown/markdown-original.svg", "5b46ef72-0615-4da7-84e9-8c3cb49f2659" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 5,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/linkedin/linkedin-original.svg", "5b46ef72-0615-4da7-84e9-8c3cb49f2659" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 6,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jquery/jquery-original.svg", "5b46ef72-0615-4da7-84e9-8c3cb49f2659" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 7,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jest/jest-plain.svg", "ddf4fb2e-dcda-495d-bd7f-9e91bbf3da81" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 8,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original.svg", "ddf4fb2e-dcda-495d-bd7f-9e91bbf3da81" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 9,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg", "ddf4fb2e-dcda-495d-bd7f-9e91bbf3da81" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "76eda766-b4fa-4389-a8e6-c4fe85be42b1", 0, "e4442c41-4e72-4724-9f3e-80d708527095", null, false, false, null, null, "LUCAS@GMAIL.COM", "AQAAAAEAACcQAAAAEOfvWO+NsHsu9CZMRH1JaPEEi/b5hhmvwhAcfWe9sHWMMzQhwxSeDi6lLJC207ISrA==", null, false, "7dbdcbd4-771c-4cf3-9ea3-ee173dd3aedf", false, "lucas@gmail.com" },
                    { "810e1de1-a854-4f5e-bb32-cf597c60c163", 0, "4ef41810-74c7-4742-bc19-0c4ee1de5823", null, false, false, null, null, "ROBERT@GMAIL.COM", "AQAAAAEAACcQAAAAEP01g2udxPhw3kR56q300y2me9EqIZvnMHePMWMZspXCbKdX0xbHJ8LXmdWICtx1yA==", null, false, "a13ece42-b79f-4597-a155-10754a91c1bb", false, "robert@gmail.com" },
                    { "8f7949b4-c254-4616-ac70-f5560eeeedf2", 0, "e801e29c-a3ce-468c-9856-c4b8b77da8eb", null, false, false, null, null, "DAVID@GMAIL.COM", "AQAAAAEAACcQAAAAEPZnfxUi/uzXTiwEq/Jx/JkOoBfvYE4hVpcMhTC7pOn3iIZ3S1jy0sRUHfge3/wX6g==", null, false, "2ebae7d4-c1d1-40ea-9e68-ed92c760c8f3", false, "david@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 1,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://via.placeholder.com/600/92c952", "8f7949b4-c254-4616-ac70-f5560eeeedf2" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 2,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://via.placeholder.com/600/771796", "8f7949b4-c254-4616-ac70-f5560eeeedf2" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 3,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://via.placeholder.com/600/24f355", "8f7949b4-c254-4616-ac70-f5560eeeedf2" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 4,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://via.placeholder.com/600/d32776", "810e1de1-a854-4f5e-bb32-cf597c60c163" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 5,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://via.placeholder.com/600/f66b97", "810e1de1-a854-4f5e-bb32-cf597c60c163" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 6,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://via.placeholder.com/600/56a8c2", "810e1de1-a854-4f5e-bb32-cf597c60c163" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 7,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://via.placeholder.com/600/b0f7cc", "76eda766-b4fa-4389-a8e6-c4fe85be42b1" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 8,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://via.placeholder.com/600/54176f", "76eda766-b4fa-4389-a8e6-c4fe85be42b1" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 9,
                columns: new[] { "fileName", "user_id" },
                values: new object[] { "https://via.placeholder.com/600/51aa97", "76eda766-b4fa-4389-a8e6-c4fe85be42b1" });
        }
    }
}
