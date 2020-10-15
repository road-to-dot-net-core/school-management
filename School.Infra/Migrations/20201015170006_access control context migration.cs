using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Infra.Migrations
{
    public partial class accesscontrolcontextmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FEATURES",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 212, DateTimeKind.Local).AddTicks(3295)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Label = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Controller = table.Column<string>(maxLength: 50, nullable: false),
                    ControllerActionName = table.Column<string>(nullable: true),
                    Action = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FEATURES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PERMISSIONS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 248, DateTimeKind.Local).AddTicks(2872)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Label = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERMISSIONS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ROLES",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 251, DateTimeKind.Local).AddTicks(3577)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PERMISSIONS_FEATURES",
                columns: table => new
                {
                    PermissionId = table.Column<Guid>(nullable: false),
                    FeatureId = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    AssociatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERMISSIONS_FEATURES", x => new { x.FeatureId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_PERMISSIONS_FEATURES_FEATURES_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "FEATURES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PERMISSIONS_FEATURES_PERMISSIONS_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "PERMISSIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ROLE_PERMISSIONS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 254, DateTimeKind.Local).AddTicks(1015)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    AssociatedOn = table.Column<DateTime>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    PermissionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLE_PERMISSIONS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ROLE_PERMISSIONS_PERMISSIONS_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "PERMISSIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ROLE_PERMISSIONS_ROLES_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ROLES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 6, 263, DateTimeKind.Local).AddTicks(9887)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Notes = table.Column<string>(maxLength: 500, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    AddressLine1 = table.Column<string>(maxLength: 255, nullable: true),
                    AddressLine2 = table.Column<string>(maxLength: 255, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_USERS_ROLES_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ROLES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PERMISSIONS_FEATURES_PermissionId",
                table: "PERMISSIONS_FEATURES",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_ROLE_PERMISSIONS_PermissionId",
                table: "ROLE_PERMISSIONS",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_ROLE_PERMISSIONS_RoleId",
                table: "ROLE_PERMISSIONS",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_USERS_RoleId",
                table: "USERS",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PERMISSIONS_FEATURES");

            migrationBuilder.DropTable(
                name: "ROLE_PERMISSIONS");

            migrationBuilder.DropTable(
                name: "USERS");

            migrationBuilder.DropTable(
                name: "FEATURES");

            migrationBuilder.DropTable(
                name: "PERMISSIONS");

            migrationBuilder.DropTable(
                name: "ROLES");
        }
    }
}
