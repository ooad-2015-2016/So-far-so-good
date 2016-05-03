using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using JobRadar.JobRadarBaza.Models;

namespace JobRadar.JobRadarBaza.Models
{
    class JobRadarDBContext:DbContext
    {
        public DbSet<Konkurs> Konkursi { get; set; }
        public DbSet<OsobaKojaTraziPosao> OsobaKojaTraziPosao { get; set; }
        public DbSet<Lokacija> Lokacija { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "ooadbaza.db";
            try
            {
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException) { }

            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
