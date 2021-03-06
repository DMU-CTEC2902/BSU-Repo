﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieWebSite.Models
{
    public class FilmModel
    {
        public virtual int FilmModelID { get; set; }
        public virtual string FilmName { get; set; }
        public virtual string FilmDescription { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual int FilmLength { get; set; }
        public virtual int GenreId { get; set; }
        public virtual GenreModel Genre { get; set; }
        public virtual decimal Rating { get; set; }
    }
}