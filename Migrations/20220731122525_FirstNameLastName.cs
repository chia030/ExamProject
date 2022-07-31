using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class FirstNameLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68a4cddb-e204-4e2b-82b5-cf01dd0b5e50", "TestName", "TestName", "AQAAAAEAACcQAAAAEMT3ZFtXvXtKrYYtTeYepl0PlyyHiRMlXX0lyMwkD2VFNaHdonQqMIHK4hgYTmW+HQ==", "8c3715b3-ef68-4a43-a1d2-a5b99a97abd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bc7ee4c-b2d4-40ee-8b86-f61a8046692a", "TestName", "TestName", "AQAAAAEAACcQAAAAEOSH40ywFft6nVQyb8eRO6f20MKYR1B0M3tUZgLwwT1SsvdcOpeCGHvWq4Bun2V9iQ==", "d19ca1c2-368b-4458-8250-1e62fbf09304" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "377fb6ea-5487-4e56-a913-dae8e4690b94", "AQAAAAEAACcQAAAAEEKeKyHAunAk4xv3rjQP/JCYpB1Fu22uilfRSfL6SpvhE/tCz+fp46w9ZLko0HCKRQ==", "f19b7613-12c7-417f-b2b0-1f8d89ffef8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71011ebb-ad03-4f6e-9b17-6716a461205a", "AQAAAAEAACcQAAAAEF0xpJC29N+zGwZ9zRTJ9fHopwbeIwSkmwJp+IV384JG3dH5of0qyykaRXHAVM+2kQ==", "da202f35-b071-4066-bdf6-8258f9306e83" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 21, 9, 55, 556, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 21, 9, 55, 556, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 21, 9, 55, 556, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 7, 30, 21, 9, 55, 556, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 30, 21, 9, 55, 556, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 30, 21, 9, 55, 556, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 30, 21, 9, 55, 556, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 30, 21, 9, 55, 556, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 30, 21, 9, 55, 556, DateTimeKind.Local).AddTicks(5476));
        }
    }
}
