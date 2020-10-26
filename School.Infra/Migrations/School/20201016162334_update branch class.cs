using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Infra.Migrations.School
{
    public partial class updatebranchclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COURSES_Branch_BranchId",
                table: "COURSES");

            migrationBuilder.DropForeignKey(
                name: "FK_LEVEL_CLASSES_Branch_BranchId",
                table: "LEVEL_CLASSES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branch",
                table: "Branch");

            migrationBuilder.RenameTable(
                name: "Branch",
                newName: "BRANCHS");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "STUDENTS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 128, DateTimeKind.Local).AddTicks(9460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 166, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROOMS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 126, DateTimeKind.Local).AddTicks(1069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 152, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ORGANIZATIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 123, DateTimeKind.Local).AddTicks(30),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 146, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LEVELS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 119, DateTimeKind.Local).AddTicks(50),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 143, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LEVEL_CLASSES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 112, DateTimeKind.Local).AddTicks(6224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 140, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "INSTRUCTORS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 104, DateTimeKind.Local).AddTicks(7191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 136, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_OFFERING_SESSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 98, DateTimeKind.Local).AddTicks(4687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 133, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_OFFERING",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 132, DateTimeKind.Local).AddTicks(844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 174, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_INSTRUCTORS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 54, DateTimeKind.Local).AddTicks(2870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 93, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AssociatedOn",
                table: "COURSES_INSTRUCTORS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 54, DateTimeKind.Local).AddTicks(8263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 94, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 81, DateTimeKind.Local).AddTicks(4082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 121, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSE_OFFERING_DAYS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 89, DateTimeKind.Local).AddTicks(7853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 129, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CATEGORIES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 51, DateTimeKind.Local).AddTicks(716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 89, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ATTENDANCES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 48, DateTimeKind.Local).AddTicks(3390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 83, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ADMINISTRATION_STAFFS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 8, DateTimeKind.Local).AddTicks(3953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 46, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "BRANCHS",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "BRANCHS",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BRANCHS",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "BRANCHS",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BRANCHS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 135, DateTimeKind.Local).AddTicks(5621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "BRANCHS",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BRANCHS",
                table: "BRANCHS",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_COURSES_BRANCHS_BranchId",
                table: "COURSES",
                column: "BranchId",
                principalTable: "BRANCHS",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LEVEL_CLASSES_BRANCHS_BranchId",
                table: "LEVEL_CLASSES",
                column: "BranchId",
                principalTable: "BRANCHS",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COURSES_BRANCHS_BranchId",
                table: "COURSES");

            migrationBuilder.DropForeignKey(
                name: "FK_LEVEL_CLASSES_BRANCHS_BranchId",
                table: "LEVEL_CLASSES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BRANCHS",
                table: "BRANCHS");

            migrationBuilder.RenameTable(
                name: "BRANCHS",
                newName: "Branch");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "STUDENTS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 166, DateTimeKind.Local).AddTicks(2193),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 128, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROOMS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 152, DateTimeKind.Local).AddTicks(83),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 126, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ORGANIZATIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 146, DateTimeKind.Local).AddTicks(3622),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 123, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LEVELS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 143, DateTimeKind.Local).AddTicks(9174),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 119, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LEVEL_CLASSES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 140, DateTimeKind.Local).AddTicks(652),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 112, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "INSTRUCTORS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 136, DateTimeKind.Local).AddTicks(4191),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 104, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_OFFERING_SESSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 133, DateTimeKind.Local).AddTicks(1241),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 98, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_OFFERING",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 174, DateTimeKind.Local).AddTicks(2919),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 132, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_INSTRUCTORS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 93, DateTimeKind.Local).AddTicks(7029),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 54, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AssociatedOn",
                table: "COURSES_INSTRUCTORS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 94, DateTimeKind.Local).AddTicks(3901),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 54, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 121, DateTimeKind.Local).AddTicks(7561),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 81, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSE_OFFERING_DAYS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 129, DateTimeKind.Local).AddTicks(7573),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 89, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CATEGORIES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 89, DateTimeKind.Local).AddTicks(783),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 51, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ATTENDANCES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 83, DateTimeKind.Local).AddTicks(3000),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 48, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ADMINISTRATION_STAFFS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 17, 43, 46, DateTimeKind.Local).AddTicks(4917),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 8, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Branch",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Branch",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 135, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Branch",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branch",
                table: "Branch",
                column: "Id");

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
    }
}
