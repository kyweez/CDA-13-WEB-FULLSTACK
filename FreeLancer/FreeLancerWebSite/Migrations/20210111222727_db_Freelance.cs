using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeLancerWebSite.Migrations
{
    public partial class db_Freelance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer_cats",
                columns: table => new
                {
                    cat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cat_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cat_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCatModelID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_cats", x => x.cat_id);
                    table.ForeignKey(
                        name: "FK_customer_cats_customer_cats_CustomerCatModelID",
                        column: x => x.CustomerCatModelID,
                        principalTable: "customer_cats",
                        principalColumn: "cat_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    customer_email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    job_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_state = table.Column<string>(type: "char(10)", nullable: false),
                    job_title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    job_start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    job_end = table.Column<DateTime>(type: "datetime2", nullable: false),
                    job_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.job_id);
                });

            migrationBuilder.CreateTable(
                name: "quotes",
                columns: table => new
                {
                    quote_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quote_state = table.Column<string>(type: "char(10)", nullable: false),
                    quote_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quote_amount = table.Column<int>(type: "int", nullable: false),
                    quote_final_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quote_final_amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quotes", x => x.quote_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customer_cats_CustomerCatModelID",
                table: "customer_cats",
                column: "CustomerCatModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer_cats");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "quotes");
        }
    }
}
