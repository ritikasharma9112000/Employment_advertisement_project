using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Employment_advertisement_project.Migrations
{
    public partial class Employment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidate_detail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_of_candidate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB_of_candidate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mobile_no_of_candidate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_address_of_candidate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidate_detail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employer_detail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employer_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_of_establishment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address_of_employer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employer_detail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Job_detail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Job_role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Job_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employer_id = table.Column<int>(type: "int", nullable: false),
                    Employer_objID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job_detail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Job_detail_Employer_detail_Employer_objID",
                        column: x => x.Employer_objID,
                        principalTable: "Employer_detail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Apply_job_detail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Candidate_id = table.Column<int>(type: "int", nullable: false),
                    Candidate_objID = table.Column<int>(type: "int", nullable: true),
                    Job_id = table.Column<int>(type: "int", nullable: false),
                    Job_objID = table.Column<int>(type: "int", nullable: true),
                    Candidate_availabilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Candidate_notice_period = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apply_job_detail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Apply_job_detail_Candidate_detail_Candidate_objID",
                        column: x => x.Candidate_objID,
                        principalTable: "Candidate_detail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Apply_job_detail_Job_detail_Job_objID",
                        column: x => x.Job_objID,
                        principalTable: "Job_detail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apply_job_detail_Candidate_objID",
                table: "Apply_job_detail",
                column: "Candidate_objID");

            migrationBuilder.CreateIndex(
                name: "IX_Apply_job_detail_Job_objID",
                table: "Apply_job_detail",
                column: "Job_objID");

            migrationBuilder.CreateIndex(
                name: "IX_Job_detail_Employer_objID",
                table: "Job_detail",
                column: "Employer_objID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apply_job_detail");

            migrationBuilder.DropTable(
                name: "Candidate_detail");

            migrationBuilder.DropTable(
                name: "Job_detail");

            migrationBuilder.DropTable(
                name: "Employer_detail");
        }
    }
}
