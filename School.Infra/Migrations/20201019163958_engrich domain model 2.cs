using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Infra.Migrations
{
    public partial class engrichdomainmodel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "USERS");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "USERS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 22, DateTimeKind.Local).AddTicks(3902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 263, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.AddColumn<string>(
                name: "AddressLine",
                table: "USERS",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "USERS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "USERS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "USERS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastConnexionOn",
                table: "USERS",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "USERS",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "USERS",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 14, DateTimeKind.Local).AddTicks(7009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 251, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.AddColumn<bool>(
                name: "CanBeDeleted",
                table: "ROLES",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "ROLES",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "ROLES",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "ROLES",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLE_PERMISSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 18, DateTimeKind.Local).AddTicks(888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 254, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "ROLE_PERMISSIONS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "ROLE_PERMISSIONS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "ROLE_PERMISSIONS",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PERMISSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 8, DateTimeKind.Local).AddTicks(2704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 248, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "PERMISSIONS",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "PERMISSIONS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "PERMISSIONS",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FEATURES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 16, 39, 57, 954, DateTimeKind.Local).AddTicks(2956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 212, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.AddColumn<string>(
                name: "DeletReason",
                table: "FEATURES",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "FEATURES",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "FEATURES",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "LastConnexionOn",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "CanBeDeleted",
                table: "ROLES");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "ROLES");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ROLES");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "ROLES");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "ROLE_PERMISSIONS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ROLE_PERMISSIONS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "ROLE_PERMISSIONS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "PERMISSIONS");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "PERMISSIONS");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "PERMISSIONS");

            migrationBuilder.DropColumn(
                name: "DeletReason",
                table: "FEATURES");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "FEATURES");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "FEATURES");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "USERS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 263, DateTimeKind.Local).AddTicks(9887),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 22, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "USERS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "USERS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 251, DateTimeKind.Local).AddTicks(3577),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 14, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLE_PERMISSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 254, DateTimeKind.Local).AddTicks(1015),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 18, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PERMISSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 248, DateTimeKind.Local).AddTicks(2872),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 39, 58, 8, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FEATURES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 212, DateTimeKind.Local).AddTicks(3295),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 16, 39, 57, 954, DateTimeKind.Local).AddTicks(2956));
        }
    }
}
