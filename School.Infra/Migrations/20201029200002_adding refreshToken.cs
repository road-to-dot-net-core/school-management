using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Infra.Migrations
{
    public partial class addingrefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "USERS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 289, DateTimeKind.Local).AddTicks(5154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 33, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 270, DateTimeKind.Local).AddTicks(7594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 25, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLE_PERMISSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 280, DateTimeKind.Local).AddTicks(2276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 28, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PERMISSIONS",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 263, DateTimeKind.Local).AddTicks(1048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 22, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FEATURES",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 195, DateTimeKind.Local).AddTicks(6561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 19, 22, 19, 43, 986, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.CreateTable(
                name: "REFRESH_TOKENS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 298, DateTimeKind.Local).AddTicks(8605)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    DeletedBy = table.Column<Guid>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletReason = table.Column<string>(maxLength: 250, nullable: true),
                    Token = table.Column<string>(maxLength: 50, nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    Used = table.Column<bool>(nullable: false),
                    Invalidated = table.Column<bool>(nullable: false),
                    JwtId = table.Column<string>(maxLength: 250, nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    Refresh_Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REFRESH_TOKENS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_REFRESH_TOKENS_USERS_UserId",
                        column: x => x.UserId,
                        principalTable: "USERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_REFRESH_TOKENS_UserId",
                table: "REFRESH_TOKENS",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "REFRESH_TOKENS");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "USERS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 33, DateTimeKind.Local).AddTicks(6943),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 289, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 25, DateTimeKind.Local).AddTicks(4564),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 270, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ROLE_PERMISSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 28, DateTimeKind.Local).AddTicks(7472),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 280, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PERMISSIONS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 22, 19, 44, 22, DateTimeKind.Local).AddTicks(977),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 263, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FEATURES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 22, 19, 43, 986, DateTimeKind.Local).AddTicks(8519),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 29, 20, 0, 1, 195, DateTimeKind.Local).AddTicks(6561));
        }
    }
}
