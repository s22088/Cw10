using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ex10.Models;

namespace Ex10.Data
{
    public class MainContext : DbContext
    {
        public MainContext (DbContextOptions<MainContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
           
        //    modelBuilder.Entity<Movie> (m=> 
        //        {
                    
        //        }
        //    );
        //}

        public DbSet<Ex10.Models.Movie> Movie { get; set; }
    }
}
