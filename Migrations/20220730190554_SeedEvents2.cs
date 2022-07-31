using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class SeedEvents2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7954519-a646-41ba-897b-fa406dd69aa7", "AQAAAAEAACcQAAAAENdlLt2LzKUqONhwkq18ucl83dEaykdH7j2fnI7bYXmf8WY9I+5biBwl5xG4a/JFiw==", "74eea82b-2b04-45f0-8c52-b88cfde9146d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a6817a2-3c50-4277-a0d5-fb6b690bd339", "AQAAAAEAACcQAAAAECZS1EoabD1aQEZ71wG6Lhb1eQ1QJ/P1I99VEqcfEArPz9SSBY2MzgTxxzpGc3S8Ng==", "8517836e-693c-4c03-855e-607410014ebd" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 21, 5, 54, 384, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 21, 5, 54, 384, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 21, 5, 54, 384, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 21, 5, 54, 384, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 30, 21, 5, 54, 384, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 30, 21, 5, 54, 384, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 30, 21, 5, 54, 384, DateTimeKind.Local).AddTicks(8517));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb708df9-0494-4559-b8d1-51bf64fc54b4", "AQAAAAEAACcQAAAAEB8z8+S8RVvGjK/gVYF4r+d3GxPZ4AcG/tvfEXo/PZJ/xb/JhxjIPZntqLMRa7C96g==", "40eeec1e-061a-49c7-a7d0-7e76feae75d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28dd3894-909e-4ba7-befd-5f8bd86e9a14", "AQAAAAEAACcQAAAAEGhBedckXhqCfJSKEIksYDyjWcsAW70opsPHe5HyHOqetjW3/llx1mve8d+t+3ZM9A==", "ed47e092-f6e8-43d8-81a3-0fe2ae22ed7c" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 20, 29, 12, 466, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 20, 29, 12, 466, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 20, 29, 12, 466, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 20, 29, 12, 466, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 30, 20, 29, 12, 466, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 30, 20, 29, 12, 466, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 30, 20, 29, 12, 466, DateTimeKind.Local).AddTicks(9782));
        }
    }
}
