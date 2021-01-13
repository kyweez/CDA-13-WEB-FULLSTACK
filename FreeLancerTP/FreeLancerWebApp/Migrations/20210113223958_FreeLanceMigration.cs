using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeLancerWebApp.Migrations
{
    public partial class FreeLanceMigration : Migration
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
                    cat_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_cats", x => x.cat_id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    customer_email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customer_id);
                    table.ForeignKey(
                        name: "FK_customers_customer_cats_cat_id",
                        column: x => x.cat_id,
                        principalTable: "customer_cats",
                        principalColumn: "cat_id",
                        onDelete: ReferentialAction.Cascade);
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
                    job_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customer_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.job_id);
                    table.ForeignKey(
                        name: "FK_jobs_customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
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
                    quote_final_amount = table.Column<int>(type: "int", nullable: false),
                    job_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quotes", x => x.quote_id);
                    table.ForeignKey(
                        name: "FK_quotes_jobs_job_id",
                        column: x => x.job_id,
                        principalTable: "jobs",
                        principalColumn: "job_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customer_cats_cat_name",
                table: "customer_cats",
                column: "cat_name",
                unique: true,
                filter: "[cat_name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_customers_cat_id",
                table: "customers",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "IX_customers_customer_email",
                table: "customers",
                column: "customer_email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_customers_customer_name",
                table: "customers",
                column: "customer_name",
                unique: true,
                filter: "[customer_name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_customer_id",
                table: "jobs",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_quotes_job_id",
                table: "quotes",
                column: "job_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "quotes");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "customer_cats");
        }
    }
}
