using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial2_MontoyaUrregoDanielEmilio.Migrations
{
    /// <inheritdoc />
    public partial class NewColumn_in_table_Tickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "Tickets");
        }
    }
}
