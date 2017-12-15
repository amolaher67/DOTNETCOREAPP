using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAppTest.Models
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Movie> Movie { get; set; }
    }
}
