using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace プロジェクト5.Services.Migrations
{
    public partial class DefinitiveMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    NomEquip = table.Column<string>(nullable: true),
                    Logo = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Usuario = table.Column<string>(nullable: true),
                    Contrasena = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipoSubs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    IdEquipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoSubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipoSubs_Equipos_IdEquipo",
                        column: x => x.IdEquipo,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    NomJug = table.Column<string>(nullable: true),
                    ApellidoP = table.Column<string>(nullable: true),
                    ApellidoM = table.Column<string>(nullable: true),
                    Posicion = table.Column<string>(nullable: true),
                    FechNac = table.Column<DateTime>(nullable: false),
                    FotoJug = table.Column<byte[]>(nullable: true),
                    IdEquipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos_IdEquipo",
                        column: x => x.IdEquipo,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    FechPart = table.Column<int>(nullable: false),
                    TiemJugado = table.Column<TimeSpan>(nullable: false),
                    Estadio = table.Column<string>(nullable: true),
                    IdEquipo = table.Column<int>(nullable: true),
                    TotalJugLc = table.Column<int>(nullable: false),
                    IdEquipoSub = table.Column<int>(nullable: true),
                    TotalJugVis = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_IdEquipo",
                        column: x => x.IdEquipo,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_EquipoSubs_IdEquipoSub",
                        column: x => x.IdEquipoSub,
                        principalTable: "EquipoSubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResultadoPartidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Goles = table.Column<int>(nullable: false),
                    Asistencias = table.Column<int>(nullable: false),
                    AutoGoles = table.Column<int>(nullable: false),
                    Penales = table.Column<int>(nullable: false),
                    TarjAmarilla = table.Column<int>(nullable: false),
                    TarjRoja = table.Column<int>(nullable: false),
                    IdPartido = table.Column<int>(nullable: false),
                    IdJugador = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultadoPartidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultadoPartidos_Jugadores_IdJugador",
                        column: x => x.IdJugador,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResultadoPartidos_Partidos_IdPartido",
                        column: x => x.IdPartido,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipoSubs_IdEquipo",
                table: "EquipoSubs",
                column: "IdEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_IdEquipo",
                table: "Jugadores",
                column: "IdEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_IdEquipo",
                table: "Partidos",
                column: "IdEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_IdEquipoSub",
                table: "Partidos",
                column: "IdEquipoSub");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoPartidos_IdJugador",
                table: "ResultadoPartidos",
                column: "IdJugador");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoPartidos_IdPartido",
                table: "ResultadoPartidos",
                column: "IdPartido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResultadoPartidos");

            migrationBuilder.DropTable(
                name: "UserPages");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "EquipoSubs");

            migrationBuilder.DropTable(
                name: "Equipos");
        }
    }
}
