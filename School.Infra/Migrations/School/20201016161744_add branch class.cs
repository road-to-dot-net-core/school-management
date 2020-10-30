using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Infra.Migrations.School
{
    public partial class addbranchclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "STUDENTS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 166, DateTimeKind.Local).AddTicks(2193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 608, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROOMS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 152, DateTimeKind.Local).AddTicks(83),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 605, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ORGANIZATIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 146, DateTimeKind.Local).AddTicks(3622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 602, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LEVELS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 143, DateTimeKind.Local).AddTicks(9174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 599, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LEVEL_CLASSES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 140, DateTimeKind.Local).AddTicks(652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 591, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.AddColumn<Guid>(
                name: "BranchId",
                table: "LEVEL_CLASSES",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "INSTRUCTORS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 136, DateTimeKind.Local).AddTicks(4191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 586, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_OFFERING_SESSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 133, DateTimeKind.Local).AddTicks(1241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 573, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_OFFERING",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 174, DateTimeKind.Local).AddTicks(2919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 611, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_INSTRUCTORS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 93, DateTimeKind.Local).AddTicks(7029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 502, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AssociatedOn",
                table: "COURSES_INSTRUCTORS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 94, DateTimeKind.Local).AddTicks(3901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 503, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 121, DateTimeKind.Local).AddTicks(7561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 554, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.AddColumn<Guid>(
                name: "BranchId",
                table: "COURSES",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSE_OFFERING_DAYS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 129, DateTimeKind.Local).AddTicks(7573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 570, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.AddColumn<int>(
                name: "Frequency",
                table: "COURSE_OFFERING_DAYS",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CATEGORIES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 89, DateTimeKind.Local).AddTicks(783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 499, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ATTENDANCES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 83, DateTimeKind.Local).AddTicks(3000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 497, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ADMINISTRATION_STAFFS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 46, DateTimeKind.Local).AddTicks(4917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 468, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LEVEL_CLASSES_BranchId",
                table: "LEVEL_CLASSES",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_COURSES_BranchId",
                table: "COURSES",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_COURSES_Branch_BranchId",
                table: "COURSES",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LEVEL_CLASSES_Branch_BranchId",
                table: "LEVEL_CLASSES",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COURSES_Branch_BranchId",
                table: "COURSES");

            migrationBuilder.DropForeignKey(
                name: "FK_LEVEL_CLASSES_Branch_BranchId",
                table: "LEVEL_CLASSES");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropIndex(
                name: "IX_LEVEL_CLASSES_BranchId",
                table: "LEVEL_CLASSES");

            migrationBuilder.DropIndex(
                name: "IX_COURSES_BranchId",
                table: "COURSES");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "LEVEL_CLASSES");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "COURSES");

            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "COURSE_OFFERING_DAYS");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "STUDENTS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 608, DateTimeKind.Local).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 166, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROOMS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 605, DateTimeKind.Local).AddTicks(932),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 152, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ORGANIZATIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 602, DateTimeKind.Local).AddTicks(2609),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 146, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LEVELS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 599, DateTimeKind.Local).AddTicks(5560),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 143, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LEVEL_CLASSES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 591, DateTimeKind.Local).AddTicks(6055),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 140, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "INSTRUCTORS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 586, DateTimeKind.Local).AddTicks(5995),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 136, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_OFFERING_SESSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 573, DateTimeKind.Local).AddTicks(4531),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 133, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_OFFERING",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 611, DateTimeKind.Local).AddTicks(9566),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 174, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_INSTRUCTORS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 502, DateTimeKind.Local).AddTicks(6386),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 93, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AssociatedOn",
                table: "COURSES_INSTRUCTORS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 503, DateTimeKind.Local).AddTicks(6534),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 94, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 554, DateTimeKind.Local).AddTicks(566),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 121, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSE_OFFERING_DAYS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 570, DateTimeKind.Local).AddTicks(2594),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 129, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CATEGORIES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 499, DateTimeKind.Local).AddTicks(6318),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 89, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ATTENDANCES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 497, DateTimeKind.Local).AddTicks(518),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 83, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ADMINISTRATION_STAFFS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 468, DateTimeKind.Local).AddTicks(4865),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 46, DateTimeKind.Local).AddTicks(4917));
        }
    }
}
