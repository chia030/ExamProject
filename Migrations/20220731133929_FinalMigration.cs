using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class FinalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "806cc75e-359e-4a62-a8b7-3392d43566a2", "AQAAAAEAACcQAAAAECr9SMxPDmyCKV6EKtV365mpQ/g5zjl80luV+qgqQ++bCYkWtJV0fQU+LaX2jINzbA==", "f3234703-b6e7-49a3-bd0d-e7ad113ac7d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ff31736-3507-4bae-aaeb-24ddcf8bf424", "AQAAAAEAACcQAAAAENtSJny/IGgvkEeGgszUh+p9iZVgmuIfDD8ZyIo1WBVHSQh+G9pIn6vERjTUPbDBoA==", "4e64c361-0818-434d-9e1c-3b93e0048fa3" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 31, 15, 39, 28, 531, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 31, 15, 39, 28, 531, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 31, 15, 39, 28, 531, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 31, 15, 39, 28, 531, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 31, 15, 39, 28, 531, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 31, 15, 39, 28, 531, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 31, 15, 39, 28, 531, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 31, 15, 39, 28, 531, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 31, 15, 39, 28, 531, DateTimeKind.Local).AddTicks(7409));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68a4cddb-e204-4e2b-82b5-cf01dd0b5e50", "AQAAAAEAACcQAAAAEMT3ZFtXvXtKrYYtTeYepl0PlyyHiRMlXX0lyMwkD2VFNaHdonQqMIHK4hgYTmW+HQ==", "8c3715b3-ef68-4a43-a1d2-a5b99a97abd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bc7ee4c-b2d4-40ee-8b86-f61a8046692a", "AQAAAAEAACcQAAAAEOSH40ywFft6nVQyb8eRO6f20MKYR1B0M3tUZgLwwT1SsvdcOpeCGHvWq4Bun2V9iQ==", "d19ca1c2-368b-4458-8250-1e62fbf09304" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 31, 14, 25, 24, 920, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 31, 14, 25, 24, 920, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 31, 14, 25, 24, 920, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 31, 14, 25, 24, 920, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 31, 14, 25, 24, 920, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 31, 14, 25, 24, 920, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 31, 14, 25, 24, 920, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 31, 14, 25, 24, 920, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 31, 14, 25, 24, 920, DateTimeKind.Local).AddTicks(7573));
        }
    }
}
