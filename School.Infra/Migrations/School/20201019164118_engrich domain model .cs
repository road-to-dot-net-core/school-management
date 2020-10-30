using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Infra.Migrations.School
{
    public partial class engrichdomainmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "STUDENTS");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "STUDENTS");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "INSTRUCTORS");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "INSTRUCTORS");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "ADMINISTRATION_STAFFS");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "ADMINISTRATION_STAFFS");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "STUDENTS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 948, DateTimeKind.Local).AddTicks(9346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 128, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.AddColumn<string>(
                name: "AddressLine",
                table: "STUDENTS",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "STUDENTS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "STUDENTS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "STUDENTS",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROOMS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 945, DateTimeKind.Local).AddTicks(2774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 126, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "ROOMS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "ROOMS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "ROOMS",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ORGANIZATIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 941, DateTimeKind.Local).AddTicks(4285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 123, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "ORGANIZATIONS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "ORGANIZATIONS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "ORGANIZATIONS",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LEVELS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 937, DateTimeKind.Local).AddTicks(9705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 119, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "LEVELS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "LEVELS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "LEVELS",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LEVEL_CLASSES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 932, DateTimeKind.Local).AddTicks(1497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 112, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "LEVEL_CLASSES",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "LEVEL_CLASSES",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "LEVEL_CLASSES",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "INSTRUCTORS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 922, DateTimeKind.Local).AddTicks(4370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 104, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.AddColumn<string>(
                name: "AddressLine",
                table: "INSTRUCTORS",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "INSTRUCTORS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "INSTRUCTORS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "INSTRUCTORS",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_OFFERING_SESSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 917, DateTimeKind.Local).AddTicks(1824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 98, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "COURSES_OFFERING_SESSIONS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "COURSES_OFFERING_SESSIONS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "COURSES_OFFERING_SESSIONS",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_OFFERING",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 952, DateTimeKind.Local).AddTicks(6697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 132, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "COURSES_OFFERING",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "COURSES_OFFERING",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "COURSES_OFFERING",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_INSTRUCTORS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 887, DateTimeKind.Local).AddTicks(685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 54, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AssociatedOn",
                table: "COURSES_INSTRUCTORS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 888, DateTimeKind.Local).AddTicks(5836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 54, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "COURSES_INSTRUCTORS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "COURSES_INSTRUCTORS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "COURSES_INSTRUCTORS",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 896, DateTimeKind.Local).AddTicks(8647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 81, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "COURSES",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "COURSES",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "COURSES",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSE_OFFERING_DAYS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 911, DateTimeKind.Local).AddTicks(6126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 89, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "COURSE_OFFERING_DAYS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "COURSE_OFFERING_DAYS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "COURSE_OFFERING_DAYS",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CATEGORIES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 878, DateTimeKind.Local).AddTicks(9192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 51, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "CATEGORIES",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "CATEGORIES",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "CATEGORIES",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BRANCHS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 959, DateTimeKind.Local).AddTicks(2016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 135, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "BRANCHS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "BRANCHS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "BRANCHS",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ATTENDANCES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 873, DateTimeKind.Local).AddTicks(6072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 48, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "ATTENDANCES",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "ATTENDANCES",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "ATTENDANCES",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ADMINISTRATION_STAFFS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 821, DateTimeKind.Local).AddTicks(8042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 8, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.AddColumn<string>(
                name: "AddressLine",
                table: "ADMINISTRATION_STAFFS",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "ADMINISTRATION_STAFFS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "ADMINISTRATION_STAFFS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "ADMINISTRATION_STAFFS",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine",
                table: "STUDENTS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "STUDENTS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "STUDENTS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "STUDENTS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "ROOMS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ROOMS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "ROOMS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "ORGANIZATIONS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ORGANIZATIONS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "ORGANIZATIONS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "LEVELS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "LEVELS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "LEVELS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "LEVEL_CLASSES");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "LEVEL_CLASSES");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "LEVEL_CLASSES");

            migrationBuilder.DropColumn(
                name: "AddressLine",
                table: "INSTRUCTORS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "INSTRUCTORS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "INSTRUCTORS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "INSTRUCTORS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "COURSES_OFFERING_SESSIONS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "COURSES_OFFERING_SESSIONS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "COURSES_OFFERING_SESSIONS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "COURSES_OFFERING");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "COURSES_OFFERING");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "COURSES_OFFERING");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "COURSES_INSTRUCTORS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "COURSES_INSTRUCTORS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "COURSES_INSTRUCTORS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "COURSES");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "COURSES");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "COURSES");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "COURSE_OFFERING_DAYS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "COURSE_OFFERING_DAYS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "COURSE_OFFERING_DAYS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "CATEGORIES");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "CATEGORIES");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "CATEGORIES");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "BRANCHS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "BRANCHS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "BRANCHS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "ATTENDANCES");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ATTENDANCES");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "ATTENDANCES");

            migrationBuilder.DropColumn(
                name: "AddressLine",
                table: "ADMINISTRATION_STAFFS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "ADMINISTRATION_STAFFS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ADMINISTRATION_STAFFS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "ADMINISTRATION_STAFFS");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "STUDENTS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 128, DateTimeKind.Local).AddTicks(9460),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 948, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "STUDENTS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "STUDENTS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROOMS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 126, DateTimeKind.Local).AddTicks(1069),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 945, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ORGANIZATIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 123, DateTimeKind.Local).AddTicks(30),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 941, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LEVELS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 119, DateTimeKind.Local).AddTicks(50),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 937, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LEVEL_CLASSES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 112, DateTimeKind.Local).AddTicks(6224),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 932, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "INSTRUCTORS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 104, DateTimeKind.Local).AddTicks(7191),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 922, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "INSTRUCTORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "INSTRUCTORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_OFFERING_SESSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 98, DateTimeKind.Local).AddTicks(4687),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 917, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_OFFERING",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 132, DateTimeKind.Local).AddTicks(844),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 952, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES_INSTRUCTORS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 54, DateTimeKind.Local).AddTicks(2870),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 887, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AssociatedOn",
                table: "COURSES_INSTRUCTORS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 54, DateTimeKind.Local).AddTicks(8263),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 888, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 81, DateTimeKind.Local).AddTicks(4082),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 896, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "COURSE_OFFERING_DAYS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 89, DateTimeKind.Local).AddTicks(7853),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 911, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CATEGORIES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 51, DateTimeKind.Local).AddTicks(716),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 878, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BRANCHS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 135, DateTimeKind.Local).AddTicks(5621),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 959, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ATTENDANCES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 48, DateTimeKind.Local).AddTicks(3390),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 873, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ADMINISTRATION_STAFFS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 16, 23, 34, 8, DateTimeKind.Local).AddTicks(3953),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 41, 17, 821, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "ADMINISTRATION_STAFFS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "ADMINISTRATION_STAFFS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }
    }
}
