using Microsoft.EntityFrameworkCore.Migrations;

namespace ResultManagementSystem.Migrations
{
    public partial class @class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Courses",
                newName: "Subject4");

            migrationBuilder.AddColumn<string>(
                name: "Subject1",
                table: "Courses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject2",
                table: "Courses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject3",
                table: "Courses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Class",
                table: "Classes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 2, "Nursery", 2 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 20, "UKG", 20 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 19, "UKG", 19 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 18, "UKG", 18 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 17, "UKG", 17 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 16, "UKG", 16 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 15, "UKG", 15 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 14, "UKG", 14 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 13, "LKG", 13 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 21, "UKG", 21 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 12, "LKG", 12 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 10, "LKG", 10 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 9, "LKG", 9 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 8, "LKG", 8 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 7, "LKG", 7 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 6, "Nursery", 6 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 5, "Nursery", 5 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 4, "Nursery", 4 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 3, "Nursery", 3 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 11, "LKG", 11 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Name", "ParentEmail", "ParentName" },
                values: new object[] { 1, "Bijay Mandal", "mbijay833@gmail.com", "Bibek Mandal" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Class", "StudentId" },
                values: new object[] { 1, "Nursery", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Subject1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Subject2",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Subject3",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Subject4",
                table: "Courses",
                newName: "Subject");

            migrationBuilder.AlterColumn<int>(
                name: "Class",
                table: "Classes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
