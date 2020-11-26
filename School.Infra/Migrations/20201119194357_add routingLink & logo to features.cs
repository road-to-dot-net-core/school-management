using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Infra.Migrations
{
    public partial class addroutingLinklogotofeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "USERS",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 19, 19, 43, 56, 336, DateTimeKind.Local).AddTicks(9145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 765, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLES",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 19, 19, 43, 56, 327, DateTimeKind.Local).AddTicks(3535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 751, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLE_PERMISSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 19, 19, 43, 56, 331, DateTimeKind.Local).AddTicks(6595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 755, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "REFRESH_TOKENS",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 19, 19, 43, 56, 422, DateTimeKind.Local).AddTicks(4088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 848, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PERMISSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 19, 19, 43, 56, 321, DateTimeKind.Local).AddTicks(4048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 746, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FEATURES",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 19, 19, 43, 56, 267, DateTimeKind.Local).AddTicks(2295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 697, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "FEATURES",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "FEATURES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoutingLink",
                table: "FEATURES",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FEATURES_ParentId",
                table: "FEATURES",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_FEATURES_FEATURES_ParentId",
                table: "FEATURES",
                column: "ParentId",
                principalTable: "FEATURES",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FEATURES_FEATURES_ParentId",
                table: "FEATURES");

            migrationBuilder.DropIndex(
                name: "IX_FEATURES_ParentId",
                table: "FEATURES");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "FEATURES");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "FEATURES");

            migrationBuilder.DropColumn(
                name: "RoutingLink",
                table: "FEATURES");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "USERS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 765, DateTimeKind.Local).AddTicks(9386),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 19, 19, 43, 56, 336, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 751, DateTimeKind.Local).AddTicks(2240),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 19, 19, 43, 56, 327, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLE_PERMISSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 755, DateTimeKind.Local).AddTicks(6840),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 19, 19, 43, 56, 331, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "REFRESH_TOKENS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 848, DateTimeKind.Local).AddTicks(8033),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 19, 19, 43, 56, 422, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PERMISSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 746, DateTimeKind.Local).AddTicks(2247),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 19, 19, 43, 56, 321, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FEATURES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 10, 21, 7, 30, 697, DateTimeKind.Local).AddTicks(8060),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 19, 19, 43, 56, 267, DateTimeKind.Local).AddTicks(2295));
        }
    }
}
