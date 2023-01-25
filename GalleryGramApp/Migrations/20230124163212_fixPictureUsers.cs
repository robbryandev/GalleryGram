using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalleryGram.Migrations
{
    public partial class fixPictureUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "76eda766-b4fa-4389-a8e6-c4fe85be42b1", 0, "e4442c41-4e72-4724-9f3e-80d708527095", null, false, false, null, null, "LUCAS@GMAIL.COM", "AQAAAAEAACcQAAAAEOfvWO+NsHsu9CZMRH1JaPEEi/b5hhmvwhAcfWe9sHWMMzQhwxSeDi6lLJC207ISrA==", null, false, "7dbdcbd4-771c-4cf3-9ea3-ee173dd3aedf", false, "lucas@gmail.com" },
                    { "810e1de1-a854-4f5e-bb32-cf597c60c163", 0, "4ef41810-74c7-4742-bc19-0c4ee1de5823", null, false, false, null, null, "ROBERT@GMAIL.COM", "AQAAAAEAACcQAAAAEP01g2udxPhw3kR56q300y2me9EqIZvnMHePMWMZspXCbKdX0xbHJ8LXmdWICtx1yA==", null, false, "a13ece42-b79f-4597-a155-10754a91c1bb", false, "robert@gmail.com" },
                    { "8f7949b4-c254-4616-ac70-f5560eeeedf2", 0, "e801e29c-a3ce-468c-9856-c4b8b77da8eb", null, false, false, null, null, "DAVID@GMAIL.COM", "AQAAAAEAACcQAAAAEPZnfxUi/uzXTiwEq/Jx/JkOoBfvYE4hVpcMhTC7pOn3iIZ3S1jy0sRUHfge3/wX6g==", null, false, "2ebae7d4-c1d1-40ea-9e68-ed92c760c8f3", false, "david@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 1,
                column: "user_id",
                value: "8f7949b4-c254-4616-ac70-f5560eeeedf2");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 2,
                column: "user_id",
                value: "8f7949b4-c254-4616-ac70-f5560eeeedf2");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 3,
                column: "user_id",
                value: "8f7949b4-c254-4616-ac70-f5560eeeedf2");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 4,
                column: "user_id",
                value: "810e1de1-a854-4f5e-bb32-cf597c60c163");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 5,
                column: "user_id",
                value: "810e1de1-a854-4f5e-bb32-cf597c60c163");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 6,
                column: "user_id",
                value: "810e1de1-a854-4f5e-bb32-cf597c60c163");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 7,
                column: "user_id",
                value: "76eda766-b4fa-4389-a8e6-c4fe85be42b1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 8,
                column: "user_id",
                value: "76eda766-b4fa-4389-a8e6-c4fe85be42b1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "picture_id",
                keyValue: 9,
                column: "user_id",
                value: "76eda766-b4fa-4389-a8e6-c4fe85be42b1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
