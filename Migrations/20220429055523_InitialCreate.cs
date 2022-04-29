using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace interest_web_api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "interest_rates_schema");

            migrationBuilder.CreateTable(
                name: "CorporationInterestTable",
                schema: "interest_rates_schema",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Period = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Total = table.Column<double>(type: "double precision", nullable: false),
                    UpToMillion = table.Column<double>(type: "double precision", nullable: false),
                    OverMillion = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorporationInterestTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseholdInterestTable",
                schema: "interest_rates_schema",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Period = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Total = table.Column<double>(type: "double precision", nullable: false),
                    ForConsumption = table.Column<double>(type: "double precision", nullable: false),
                    ForHousePurchase = table.Column<double>(type: "double precision", nullable: false),
                    ForOtherPurposes = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseholdInterestTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CorporationInterestTable",
                schema: "interest_rates_schema");

            migrationBuilder.DropTable(
                name: "HouseholdInterestTable",
                schema: "interest_rates_schema");
        }
    }
}
