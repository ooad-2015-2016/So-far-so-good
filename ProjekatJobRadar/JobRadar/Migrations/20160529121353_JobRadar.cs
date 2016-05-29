using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace JobRadarMigrations
{
    public partial class JobRadar : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    LokacijaId = table.Column(type: "INTEGER", nullable: false),
                     //   .Annotation("Sqlite:Autoincrement", true),
                    Adresa = table.Column(type: "TEXT", nullable: true),
                    Drzava = table.Column(type: "TEXT", nullable: true),
                    Grad = table.Column(type: "TEXT", nullable: true),
                    Kontinent = table.Column(type: "TEXT", nullable: true),
                    PostanskiBroj = table.Column(type: "TEXT", nullable: true),
                    fourSqaureId = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacija", x => x.LokacijaId);
                });
            migration.CreateTable(
                name: "Poslodavac",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                      //  .Annotation("Sqlite:Autoincrement", true),
                    aktiviran = table.Column(type: "INTEGER", nullable: false),
                    datumRegistracije = table.Column(type: "TEXT", nullable: false),
                    email = table.Column(type: "TEXT", nullable: true),
                    lokacijaLokacijaId = table.Column(type: "INTEGER", nullable: true),
                    nazivPoslodavca = table.Column(type: "TEXT", nullable: true),
                    opis = table.Column(type: "TEXT", nullable: true),
                    posljednjaAktivnost = table.Column(type: "TEXT", nullable: false),
                    userName = table.Column(type: "TEXT", nullable: true),
                    zabranjenPristup = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poslodavac", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Poslodavac_Lokacija_lokacijaLokacijaId",
                        columns: x => x.lokacijaLokacijaId,
                        referencedTable: "Lokacija",
                        referencedColumn: "LokacijaId");
                });
            migration.CreateTable(
                name: "Konkurs",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                  //      .Annotation("Sqlite:Autoincrement", true),
                    LokacijaId = table.Column(type: "INTEGER", nullable: false),
                    PoslodavacID = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konkurs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Konkurs_Poslodavac_PoslodavacID",
                        columns: x => x.PoslodavacID,
                        referencedTable: "Poslodavac",
                        referencedColumn: "ID");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Konkurs");
            migration.DropTable("Poslodavac");
            migration.DropTable("Lokacija");
        }
    }
}
