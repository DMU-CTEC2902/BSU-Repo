using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieWebSite.Models
{
    public class DirectorModel
    {
        public virtual int DirectorModelID { get; set; }
        public virtual string DirectorName { get; set; }
        public virtual string DirectorBio { get; set; }
        public virtual DateTime DirectorDOB { get; set; }
}
}