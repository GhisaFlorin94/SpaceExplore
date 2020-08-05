using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpaceExploreCrewService.DataLayer.Entities;

namespace SpaceExploreCrewService.DataLayer
{
    public class CrewServiceDBContext : DbContext
    {
        public DbSet<Captain> Captains { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Robot> Robots { get; set; }
        public DbSet<Shuttle> Shuttles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"data source=.;initial catalog=CrewServiceDB;integrated security=True");
        }
    }
}
