﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace JobRadarWeb.Models
{
    public class OsobaKojaTraziPosaoDBContext:DbContext
    {
        public DbSet<OsobaKojaTraziPosao> OsobeKojeTrazePosao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}