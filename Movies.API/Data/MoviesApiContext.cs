using Microsoft.EntityFrameworkCore;
using Movies.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.API.Data
{
    public class MoviesApiContext: DbContext
    {
        public MoviesApiContext(DbContextOptions<MoviesApiContext> options) : base(options) { }
        
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

    }
}
