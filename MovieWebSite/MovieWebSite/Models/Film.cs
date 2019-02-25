using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieWebSite.Models
{
    public class Film
    {
        public virtual int FilmID { get; set; }
        public virtual string FilmName { get; set; }
        public virtual string FilmDescription { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
    }
}