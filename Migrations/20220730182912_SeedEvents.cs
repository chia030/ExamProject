using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class SeedEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Event_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Event_UserId",
                table: "Event",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c00774c-b58c-48b5-8661-36cfad4dd6d7", "AQAAAAEAACcQAAAAEJ7V9chdWZ7m3QVHm0xJ15Tjsy01YEpogUlbCQdT72qmHxiS5ciMSoCZ+9ejVXUQUA==", "aca62617-f502-4c9e-bc2b-dd17aa311f18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da296051-24c7-4ba4-8fd1-2053440f9e82", "AQAAAAEAACcQAAAAEJ5YhlOxf+iDuTo30H6YBHtSma2gbIbEj+/kEPFMxqj4k9HL8Y7VjSo8l9UXr+F2yg==", "1738634f-a3ee-4b28-860b-df367a5d3436" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 14, 40, 24, 540, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 14, 40, 24, 540, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 14, 40, 24, 540, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 14, 40, 24, 540, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 30, 14, 40, 24, 540, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 30, 14, 40, 24, 540, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 30, 14, 40, 24, 540, DateTimeKind.Local).AddTicks(83));
        }
    }
}
