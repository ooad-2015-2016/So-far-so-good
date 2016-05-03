using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using JobRadar.JobRadarBaza.Models;

namespace JobRadarMigrations
{
    [ContextType(typeof(JobRadarDBContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160503124309_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("JobRadar.JobRadarBaza.Models.Konkurs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LokacijaId");

                    b.Key("ID");
                });

            builder.Entity("JobRadar.JobRadarBaza.Models.Lokacija", b =>
                {
                    b.Property<int>("LokacijaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<string>("Drzava");

                    b.Property<string>("Grad");

                    b.Property<string>("Kontinent");

                    b.Property<string>("PostanskiBroj");

                    b.Property<string>("fourSqaureId");

                    b.Key("LokacijaId");
                });

            builder.Entity("JobRadar.JobRadarBaza.Models.OsobaKojaTraziPosao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("aktiviran");

                    b.Property<DateTime>("datumRegistracije");

                    b.Property<DateTime>("datumRodjenja");

                    b.Property<string>("email");

                    b.Property<DateTime>("godinaZavrsetkaObrazovanja");

                    b.Property<string>("ime");

                    b.Property<DateTime>("posljednjaAktivnost");

                    b.Property<string>("prezime");

                    b.Property<string>("userName");

                    b.Property<bool>("zabranjenPristup");

                    b.Property<bool>("zaposlen");

                    b.Key("ID");
                });
        }
    }
}
