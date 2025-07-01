using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Migrations
{
    /// <inheritdoc />
    public partial class mig_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntries_WorkSessions_WorkSessionId",
                table: "TimeEntries");

            migrationBuilder.DropTable(
                name: "WorkSessions");

            migrationBuilder.DropIndex(
                name: "IX_TimeEntries_WorkSessionId",
                table: "TimeEntries");

            migrationBuilder.DropColumn(
                name: "WorkSessionId",
                table: "TimeEntries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "WorkSessionId",
                table: "TimeEntries",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WorkSessions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CompletedTasks = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    TotalTrackedTime = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkSessions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntries_WorkSessionId",
                table: "TimeEntries",
                column: "WorkSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntries_WorkSessions_WorkSessionId",
                table: "TimeEntries",
                column: "WorkSessionId",
                principalTable: "WorkSessions",
                principalColumn: "Id");
        }
    }
}
