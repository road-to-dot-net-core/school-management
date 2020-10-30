using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Infra.Migrations.School
{
    public partial class enrichdomainmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIES",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 499, DateTimeKind.Local).AddTicks(6318)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Desription = table.Column<string>(maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "INSTRUCTORS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 586, DateTimeKind.Local).AddTicks(5995)),
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
                    HireDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSTRUCTORS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LEVELS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 599, DateTimeKind.Local).AddTicks(5560)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEVELS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ORGANIZATIONS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 602, DateTimeKind.Local).AddTicks(2609)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORGANIZATIONS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ROOMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 605, DateTimeKind.Local).AddTicks(932)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROOMS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "COURSES",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 554, DateTimeKind.Local).AddTicks(566)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    DurationTicks = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: true),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COURSES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COURSES_CATEGORIES_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CATEGORIES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COURSES_COURSES_ParentId",
                        column: x => x.ParentId,
                        principalTable: "COURSES",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LEVEL_CLASSES",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 591, DateTimeKind.Local).AddTicks(6055)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    ClassName = table.Column<string>(maxLength: 50, nullable: false),
                    LevelId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEVEL_CLASSES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LEVEL_CLASSES_LEVELS_LevelId",
                        column: x => x.LevelId,
                        principalTable: "LEVELS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ADMINISTRATION_STAFFS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 468, DateTimeKind.Local).AddTicks(4865)),
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
                    OrgId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMINISTRATION_STAFFS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ADMINISTRATION_STAFFS_ORGANIZATIONS_OrgId",
                        column: x => x.OrgId,
                        principalTable: "ORGANIZATIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COURSES_INSTRUCTORS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 502, DateTimeKind.Local).AddTicks(6386)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CourseId = table.Column<Guid>(nullable: false),
                    InstructorId = table.Column<Guid>(nullable: false),
                    AssociatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 503, DateTimeKind.Local).AddTicks(6534))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COURSES_INSTRUCTORS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COURSES_INSTRUCTORS_COURSES_CourseId",
                        column: x => x.CourseId,
                        principalTable: "COURSES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COURSES_INSTRUCTORS_INSTRUCTORS_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "INSTRUCTORS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COURSES_OFFERING",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 611, DateTimeKind.Local).AddTicks(9566)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    State = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    CourseId = table.Column<Guid>(nullable: false),
                    LevelClassId = table.Column<Guid>(nullable: false),
                    InstructorId = table.Column<Guid>(nullable: false),
                    DefaultRoomId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COURSES_OFFERING", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COURSES_OFFERING_COURSES_CourseId",
                        column: x => x.CourseId,
                        principalTable: "COURSES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COURSES_OFFERING_ROOMS_DefaultRoomId",
                        column: x => x.DefaultRoomId,
                        principalTable: "ROOMS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_COURSES_OFFERING_INSTRUCTORS_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "INSTRUCTORS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COURSES_OFFERING_LEVEL_CLASSES_LevelClassId",
                        column: x => x.LevelClassId,
                        principalTable: "LEVEL_CLASSES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "STUDENTS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 608, DateTimeKind.Local).AddTicks(3446)),
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
                    LevelClassId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDENTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_STUDENTS_LEVEL_CLASSES_LevelClassId",
                        column: x => x.LevelClassId,
                        principalTable: "LEVEL_CLASSES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COURSE_OFFERING_DAYS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 570, DateTimeKind.Local).AddTicks(2594)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Day = table.Column<int>(nullable: false),
                    StartTimeTicks = table.Column<long>(type: "bigint", nullable: false),
                    EndTimeTicks = table.Column<long>(type: "bigint", nullable: false),
                    CourseOfferingId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COURSE_OFFERING_DAYS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COURSE_OFFERING_DAYS_COURSES_OFFERING_CourseOfferingId",
                        column: x => x.CourseOfferingId,
                        principalTable: "COURSES_OFFERING",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COURSES_OFFERING_SESSIONS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 573, DateTimeKind.Local).AddTicks(4531)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Canceled = table.Column<bool>(nullable: false),
                    RoomId = table.Column<Guid>(nullable: false),
                    CourseOfferingId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COURSES_OFFERING_SESSIONS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COURSES_OFFERING_SESSIONS_COURSES_OFFERING_CourseOfferingId",
                        column: x => x.CourseOfferingId,
                        principalTable: "COURSES_OFFERING",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COURSES_OFFERING_SESSIONS_ROOMS_RoomId",
                        column: x => x.RoomId,
                        principalTable: "ROOMS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ATTENDANCES",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 15, 17, 0, 53, 497, DateTimeKind.Local).AddTicks(518)),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    StudentId = table.Column<Guid>(nullable: false),
                    Attended = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(maxLength: 500, nullable: true),
                    CourseOfferingSessionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATTENDANCES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ATTENDANCES_COURSES_OFFERING_SESSIONS_CourseOfferingSessionId",
                        column: x => x.CourseOfferingSessionId,
                        principalTable: "COURSES_OFFERING_SESSIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ATTENDANCES_STUDENTS_StudentId",
                        column: x => x.StudentId,
                        principalTable: "STUDENTS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADMINISTRATION_STAFFS_OrgId",
                table: "ADMINISTRATION_STAFFS",
                column: "OrgId");

            migrationBuilder.CreateIndex(
                name: "IX_ATTENDANCES_CourseOfferingSessionId",
                table: "ATTENDANCES",
                column: "CourseOfferingSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ATTENDANCES_StudentId",
                table: "ATTENDANCES",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_COURSE_OFFERING_DAYS_CourseOfferingId",
                table: "COURSE_OFFERING_DAYS",
                column: "CourseOfferingId");

            migrationBuilder.CreateIndex(
                name: "IX_COURSES_CategoryId",
                table: "COURSES",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_COURSES_ParentId",
                table: "COURSES",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_COURSES_INSTRUCTORS_CourseId",
                table: "COURSES_INSTRUCTORS",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_COURSES_INSTRUCTORS_InstructorId",
                table: "COURSES_INSTRUCTORS",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_COURSES_OFFERING_CourseId",
                table: "COURSES_OFFERING",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_COURSES_OFFERING_DefaultRoomId",
                table: "COURSES_OFFERING",
                column: "DefaultRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_COURSES_OFFERING_InstructorId",
                table: "COURSES_OFFERING",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_COURSES_OFFERING_LevelClassId",
                table: "COURSES_OFFERING",
                column: "LevelClassId");

            migrationBuilder.CreateIndex(
                name: "IX_COURSES_OFFERING_SESSIONS_CourseOfferingId",
                table: "COURSES_OFFERING_SESSIONS",
                column: "CourseOfferingId");

            migrationBuilder.CreateIndex(
                name: "IX_COURSES_OFFERING_SESSIONS_RoomId",
                table: "COURSES_OFFERING_SESSIONS",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_LEVEL_CLASSES_LevelId",
                table: "LEVEL_CLASSES",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_STUDENTS_LevelClassId",
                table: "STUDENTS",
                column: "LevelClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADMINISTRATION_STAFFS");

            migrationBuilder.DropTable(
                name: "ATTENDANCES");

            migrationBuilder.DropTable(
                name: "COURSE_OFFERING_DAYS");

            migrationBuilder.DropTable(
                name: "COURSES_INSTRUCTORS");

            migrationBuilder.DropTable(
                name: "ORGANIZATIONS");

            migrationBuilder.DropTable(
                name: "COURSES_OFFERING_SESSIONS");

            migrationBuilder.DropTable(
                name: "STUDENTS");

            migrationBuilder.DropTable(
                name: "COURSES_OFFERING");

            migrationBuilder.DropTable(
                name: "COURSES");

            migrationBuilder.DropTable(
                name: "ROOMS");

            migrationBuilder.DropTable(
                name: "INSTRUCTORS");

            migrationBuilder.DropTable(
                name: "LEVEL_CLASSES");

            migrationBuilder.DropTable(
                name: "CATEGORIES");

            migrationBuilder.DropTable(
                name: "LEVELS");
        }
    }
}
