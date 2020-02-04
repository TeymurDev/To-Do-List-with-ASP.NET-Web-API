using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyTasksApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDate", "Duration", "Name" },
                values: new object[] { 1, new DateTime(2020, 1, 24, 10, 57, 54, 526, DateTimeKind.Local), 10, "Learn Java" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDate", "Duration", "Name" },
                values: new object[] { 2, new DateTime(2020, 1, 24, 10, 57, 54, 528, DateTimeKind.Local), 5, "Learn JS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
