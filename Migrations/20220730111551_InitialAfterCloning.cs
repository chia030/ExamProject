using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class InitialAfterCloning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "316f04ca-f29c-4b7e-b772-a895558e3950", "AQAAAAEAACcQAAAAENHGLArXHsOnhBBJdnk/rsICjFFthipHZZqtXiJ96StVTpJmhTDqEgAI7LcDffVk0Q==", "a6177534-4d38-4f8c-a0bb-7f64a0e36f90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d5b1b5c-d30e-4d4a-a8f3-f5b258b406b9", "AQAAAAEAACcQAAAAEPGKBZ8GX1Dm43nipo61rsQ1gvWWXBCBVSsNm3NBgQPnOgBXHoS+ZrL4ILCvWcfufA==", "a2300768-5369-4209-9f67-8287257ed350" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 13, 15, 51, 21, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 13, 15, 51, 21, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 13, 15, 51, 21, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 13, 15, 51, 21, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 30, 13, 15, 51, 21, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 30, 13, 15, 51, 21, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 30, 13, 15, 51, 21, DateTimeKind.Local).AddTicks(8365));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea6e0e8b-5c42-49dd-81a4-4e2d51402328", "AQAAAAEAACcQAAAAEAtw7H60mzjhPwaZ+NqRkAjZ4aeSde5fu3YGLSI94/mU/6WuVkBLkykIKECj4a1BxQ==", "3022a109-4222-44bc-a24c-7af9e69df2d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dc398c9-9202-49b1-b82a-b5e1efd6838b", "AQAAAAEAACcQAAAAEJJ6LmqTnZ+ADQg+V3hgbbOL7y45YvStRo+ySZYGZIEFjHcV0qG8c3I5x06VKudZ1Q==", "26034978-c05a-40e5-92d2-3a5262682eb6" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 739, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(30));
        }
    }
}
