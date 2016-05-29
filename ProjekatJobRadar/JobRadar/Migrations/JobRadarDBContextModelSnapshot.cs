using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using JobRadar.JobRadarBaza.Models;

namespace JobRadarMigrations
{
    [ContextType(typeof(JobRadarDBContext))]
    partial class JobRadarDBContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("JobRadar.JobRadarBaza.Models.Konkurs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LokacijaId");

                    b.Property<int?>("PoslodavacID");

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

            builder.Entity("JobRadar.JobRadarBaza.Models.Poslodavac", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("aktiviran");

                    b.Property<DateTime>("datumRegistracije");

                    b.Property<string>("email");

                    b.Property<int?>("lokacijaLokacijaId");

                    b.Property<string>("nazivPoslodavca");

                    b.Property<string>("opis");

                    b.Property<DateTime>("posljednjaAktivnost");

                    b.Property<string>("userName");

                    b.Property<bool>("zabranjenPristup");

                    b.Key("ID");
                });

            builder.Entity("JobRadar.JobRadarBaza.Models.Konkurs", b =>
                {
                    b.Reference("JobRadar.JobRadarBaza.Models.Poslodavac")
                        .InverseCollection()
                        .ForeignKey("PoslodavacID");
                });

            builder.Entity("JobRadar.JobRadarBaza.Models.Poslodavac", b =>
                {
                    b.Reference("JobRadar.JobRadarBaza.Models.Lokacija")
                        .InverseCollection()
                        .ForeignKey("lokacijaLokacijaId");
                });
        }
    }
}
