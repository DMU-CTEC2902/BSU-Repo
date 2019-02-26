using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieWebSite.Models
{
    public class GenreModel
    {
        public virtual int GenreID { get; set; }
        public virtual string GenreName { get; set; }
    }
}