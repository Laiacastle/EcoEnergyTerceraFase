using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoEnergyTerceraFase.Migrations
{
    /// <inheritdoc />
    public partial class migracionMikel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsumAigua",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CodeDistrict = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poblation = table.Column<int>(type: "int", nullable: false),
                    Network = table.Column<int>(type: "int", nullable: false),
                    FontsAndEcoActivities = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Consumption = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumAigua", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndicadorsEnergetics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CDEEBC_ProdNeta = table.Column<double>(type: "float", nullable: false),
                    CDEEBC_ProdDisp = table.Column<double>(type: "float", nullable: false),
                    CDEEBC_DemandaElectr = table.Column<double>(type: "float", nullable: false),
                    CCAC_GasolinaAuto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndicadorsEnergetics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Simulacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Rati = table.Column<double>(type: "float", nullable: false),
                    EnergiaGenerada = table.Column<double>(type: "float", nullable: false),
                    CostKWh = table.Column<double>(type: "float", nullable: false),
                    PreuKWh = table.Column<double>(type: "float", nullable: false),
                    DataHora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Simulacions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumAigua");

            migrationBuilder.DropTable(
                name: "IndicadorsEnergetics");

            migrationBuilder.DropTable(
                name: "Simulacions");
        }
    }
}
