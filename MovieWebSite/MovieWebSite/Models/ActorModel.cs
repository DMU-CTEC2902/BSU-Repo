﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieWebSite.Models
{
    public class ActorModel
    {
        public virtual int ActorModelID { get; set; }
        public virtual string ActorName { get; set; }
        public virtual string ActorBio { get; set; }
        public virtual DateTime ActorDOB { get; set; }
        public virtual string ActorRoles { get; set; }
        public virtual decimal Rating { get; set; }
    }
}