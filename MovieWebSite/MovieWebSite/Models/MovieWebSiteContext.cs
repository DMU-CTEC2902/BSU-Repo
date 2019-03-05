using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MovieWebSite.Models;

namespace MovieWebSite.Models
{
    public class MovieWebSiteContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MovieWebSiteContext() : base("name=MovieWebSiteContext")
        {
        }

        public DbSet<FilmModel> FilmModels { get; set; }

        public System.Data.Entity.DbSet<MovieWebSite.Models.DirectorModel> DirectorModels { get; set; }

        public System.Data.Entity.DbSet<MovieWebSite.Models.ActorModel> ActorModels { get; set; }
    }
}
