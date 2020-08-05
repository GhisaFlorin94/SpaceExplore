using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpaceExplorePlanetService.DataLayer.Entities;

namespace SpaceExplorePlanetService.DataLayer
{
    public class PlanetServiceDBContext : DbContext
    {
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Robot> Robots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"data source=.;initial catalog=PlanetServiceDB;integrated security=True");
        }

    }
}
