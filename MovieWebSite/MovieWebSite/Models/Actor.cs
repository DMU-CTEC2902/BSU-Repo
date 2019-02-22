using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieWebSite.Models
{
    public class Actor
    {
        public virtual int ActorID { get; set; }
        public virtual string ActorName { get; set; }
        public virtual string ActorBio { get; set; }
        public virtual DateTime ActorDOB { get; set; }
        public virtual string ActorRoles { get; set; }
    }
}