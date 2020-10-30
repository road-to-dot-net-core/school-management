using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Infra.Migrations
{
    public partial class changecontrolActionNamelength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "USERS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 33, DateTimeKind.Local).AddTicks(6943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 22, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 25, DateTimeKind.Local).AddTicks(4564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 14, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLE_PERMISSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 28, DateTimeKind.Local).AddTicks(7472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 18, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PERMISSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 22, DateTimeKind.Local).AddTicks(977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 8, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FEATURES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 22, 19, 43, 986, DateTimeKind.Local).AddTicks(8519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 39, 57, 954, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.AlterColumn<string>(
                name: "ControllerActionName",
                table: "FEATURES",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "USERS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 22, DateTimeKind.Local).AddTicks(3902),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 33, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 14, DateTimeKind.Local).AddTicks(7009),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 25, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLE_PERMISSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 18, DateTimeKind.Local).AddTicks(888),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 28, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PERMISSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 8, DateTimeKind.Local).AddTicks(2704),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 22, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FEATURES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 39, 57, 954, DateTimeKind.Local).AddTicks(2956),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 22, 19, 43, 986, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.AlterColumn<string>(
                name: "ControllerActionName",
                table: "FEATURES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
