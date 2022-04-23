using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportsService.Migrations
{
    public partial class ReportParamChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReportName",
                table: "Report",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Report",
                newName: "ReportName");
        }
    }
}
