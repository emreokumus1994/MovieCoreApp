using Microsoft.EntityFrameworkCore;
using MovieCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCoreApp.Data
{
    public class MvcMovieContext:DbContext 
        //entity frameworkcore.dbcontext'den türetilir nesne data modele dahil edilecek entitylerin belirtildiği kısım
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            :base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; } //entity set table karşılık gelir. 
    }
}
