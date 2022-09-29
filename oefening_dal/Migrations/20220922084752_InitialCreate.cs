using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oefening_dal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reeksnummer = table.Column<int>(type: "int", nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlbumTypeID = table.Column<int>(type: "int", nullable: false),
                    Favoriet = table.Column<bool>(type: "bit", nullable: false),
                    Waardering = table.Column<byte>(type: "tinyint", nullable: true),
                    Uitgiftedatum = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EersteDruk = table.Column<bool>(type: "bit", nullable: false),
                    Kaft = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inkleuring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Paginas = table.Column<int>(type: "int", nullable: false),
                    Breedte = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Hoogte = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Taal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conditie = table.Column<byte>(type: "tinyint", nullable: true),
                    InBedrag = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    Waarde = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    Uitbedrag = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    LaatsteUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReeksID = table.Column<int>(type: "int", nullable: false),
                    UitgeverID = table.Column<int>(type: "int", nullable: false),
                    EventIDIn = table.Column<int>(type: "int", nullable: true),
                    EventIDUit = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "Reekstypes",
                columns: table => new
                {
                    ReekstypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reekstypes", x => x.ReekstypeID);
                });

            migrationBuilder.CreateTable(
                name: "Reeksen",
                columns: table => new
                {
                    ReeksID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReekstypeID = table.Column<int>(type: "int", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaatsteUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlbumsAlbumID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reeksen", x => x.ReeksID);
                    table.ForeignKey(
                        name: "FK_Reeksen_Albums_AlbumsAlbumID",
                        column: x => x.AlbumsAlbumID,
                        principalTable: "Albums",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReeksGenres",
                columns: table => new
                {
                    ReeksGenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReeksID = table.Column<int>(type: "int", nullable: false),
                    GenreID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReeksGenres", x => x.ReeksGenreID);
                    table.ForeignKey(
                        name: "FK_ReeksGenres_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReeksGenres_Reeksen_ReeksID",
                        column: x => x.ReeksID,
                        principalTable: "Reeksen",
                        principalColumn: "ReeksID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reeksen_AlbumsAlbumID",
                table: "Reeksen",
                column: "AlbumsAlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_ReeksGenres_GenreID",
                table: "ReeksGenres",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_ReeksIDGenreID",
                table: "ReeksGenres",
                columns: new[] { "ReeksID", "GenreID" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReeksGenres");

            migrationBuilder.DropTable(
                name: "Reekstypes");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Reeksen");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
