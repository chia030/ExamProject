using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class SeedEvents3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "DateTime", "Description", "Location", "Title", "UserId" },
                values: new object[] { 1, new DateTime(2022, 7, 30, 21, 9, 55, 556, DateTimeKind.Local).AddTicks(5608), "?", "KEA Main Campus", "Introduction Week", "1" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "DateTime", "Description", "Location", "Title", "UserId" },
                values: new object[] { 2, new DateTime(2022, 7, 30, 21, 9, 55, 556, DateTimeKind.Local).AddTicks(5618), "This is just a test", "KEA Main Campus", "Test Event", "1" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2);

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
    }
}
