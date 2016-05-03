using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace JobRadarMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Konkurs",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement","true"),
                    LokacijaId = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konkurs", x => x.ID);
                });
            migration.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    LokacijaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", "true"),
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
                name: "OsobaKojaTraziPosao",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                    // .Annotation("Sqlite:Autoincrement", "true"),     
                    userName = table.Column(type: "TEXT", nullable: true),
                    email = table.Column(type: "TEXT", nullable: true),
                    datumRegistracije = table.Column(type: "TEXT", nullable: false),
                    posljednjaAktivnost = table.Column(type: "TEXT", nullable: false),
                    aktiviran = table.Column(type: "INTEGER", nullable: false),
                    zabranjenPristup = table.Column(type: "INTEGER", nullable: false),
                    ime = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: false),                   
                    godinaZavrsetkaObrazovanja = table.Column(type: "TEXT", nullable: false),                                     
                    zaposlen = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OsobaKojaTraziPosao", x => x.ID);
                });
            migration.CreateTable(
                name: "Poslodavac",
                columns: table => new
                {
                    ID = table.Column(type: "INTEGER", nullable: false),
                    // .Annotation("Sqlite:Autoincrement", "true"),     
                    userName = table.Column(type: "TEXT", nullable: true),
                    email = table.Column(type: "TEXT", nullable: true),
                    datumRegistracije = table.Column(type: "TEXT", nullable: false),
                    posljednjaAktivnost = table.Column(type: "TEXT", nullable: false),
                    aktiviran = table.Column(type: "INTEGER", nullable: false),
                    zabranjenPristup = table.Column(type: "INTEGER", nullable: false),
                    nazivPoslodavca = table.Column(type: "TEXT", nullable: true),
                    opis = table.Column(type: "TEXT", nullable: true),
                    lokacija = table.Column(type: "TEXT", nullable: true),
                    //fali lista konkursa, nisam sigurna za ovo
                }
                    );
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Konkurs");
            migration.DropTable("Lokacija");
            migration.DropTable("OsobaKojaTraziPosao");
            migration.DropTable("Poslodavac");
        }
    }
}
