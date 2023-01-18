using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AndreyevInterview.Migrations
{
    /// <inheritdoc />
    public partial class contacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Invoices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNum = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    EmerName = table.Column<string>(type: "TEXT", nullable: true),
                    EmerPhoneNum = table.Column<string>(type: "TEXT", nullable: true),
                    DOB = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LegalRep = table.Column<string>(type: "TEXT", nullable: true),
                    AdditionalNote = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ContactId",
                table: "Invoices",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Contacts_ContactId",
                table: "Invoices",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onUpdate: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Contacts_ContactId",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ContactId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Invoices");
        }
    }
}
