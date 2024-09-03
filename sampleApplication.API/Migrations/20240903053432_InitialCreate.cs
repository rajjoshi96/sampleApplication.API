using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sampleApplication.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sampleModel",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    taskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taskTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isComplete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sampleModel", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sampleModel");
        }
    }
}
