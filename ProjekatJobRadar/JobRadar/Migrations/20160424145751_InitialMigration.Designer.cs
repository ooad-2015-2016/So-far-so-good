using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using JobRadar.LokacijaBaza.Models;

namespace JobRadarMigrations
{
    [ContextType(typeof(LokacijaDbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160424145751_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("JobRadar.LokacijaBaza.Models.Lokacija", b =>
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
        }
    }
}
