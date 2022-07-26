using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something
{
    class SubiektContext : DbContext
    {
        public SubiektContext() { }
        public DbSet<Towar> tw_Towar { get; set; }
        public DbSet<Rabat> sl_Rabat { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("C:\\Users\\Alex_\\OneDrive\\Dokumenty\\Staż\\MiniProjekt\\MiniProjekt\\cnstring.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("cnE"));
            }
        }
    }
}
