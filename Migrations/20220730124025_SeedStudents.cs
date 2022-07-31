using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class SeedStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    StudyProgramme = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

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

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "FirstName", "LastName", "StudyProgramme" },
                values: new object[] { 1, "Bruce", "Wayne", "BSc in Martial Arts" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "FirstName", "LastName", "StudyProgramme" },
                values: new object[] { 2, "Selina", "Kyle", "BSc in Martial Arts" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "FirstName", "LastName", "StudyProgramme" },
                values: new object[] { 3, "James", "Gordon", "MSc in Criminal Justice" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "FirstName", "LastName", "StudyProgramme" },
                values: new object[] { 4, "Carmine", "Falcone", "MSc in Mischievous Arts" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

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
    }
}
