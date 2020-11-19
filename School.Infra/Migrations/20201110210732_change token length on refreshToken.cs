using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Infra.Migrations
{
    public partial class changetokenlengthonrefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "USERS",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 765, DateTimeKind.Local).AddTicks(9386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 289, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLES",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 751, DateTimeKind.Local).AddTicks(2240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 270, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLE_PERMISSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 755, DateTimeKind.Local).AddTicks(6840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 280, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "REFRESH_TOKENS",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "REFRESH_TOKENS",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 848, DateTimeKind.Local).AddTicks(8033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 298, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PERMISSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 746, DateTimeKind.Local).AddTicks(2247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 263, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FEATURES",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 697, DateTimeKind.Local).AddTicks(8060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 195, DateTimeKind.Local).AddTicks(6561));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "USERS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 289, DateTimeKind.Local).AddTicks(5154),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 765, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 270, DateTimeKind.Local).AddTicks(7594),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 751, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLE_PERMISSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 280, DateTimeKind.Local).AddTicks(2276),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 755, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "REFRESH_TOKENS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "REFRESH_TOKENS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 298, DateTimeKind.Local).AddTicks(8605),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 848, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PERMISSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 263, DateTimeKind.Local).AddTicks(1048),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 746, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FEATURES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 195, DateTimeKind.Local).AddTicks(6561),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 697, DateTimeKind.Local).AddTicks(8060));
        }
    }
}
