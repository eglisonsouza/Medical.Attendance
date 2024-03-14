using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Medical.Attendance.Infra.Migrations
{
    /// <inheritdoc />
    public partial class RenameSequencialToSequential : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sequencial",
                table: "HoursDays",
                newName: "Sequential");

            migrationBuilder.RenameColumn(
                name: "Sequencial",
                table: "Days",
                newName: "Sequential");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sequential",
                table: "HoursDays",
                newName: "Sequencial");

            migrationBuilder.RenameColumn(
                name: "Sequential",
                table: "Days",
                newName: "Sequencial");
        }
    }
}
