using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieWebSite.Models
{
    public class DirectorModel
    {
        public virtual int DirectorId { get; set; }
        public virtual string DirectorName { get; set; }
        public virtual string DirectorBio { get; set; }
        public virtual DateTime DirectorDOB { get; set; }
        public virtual int CommentId { get; set; }
        public virtual CommentModel Comment { get; set; }
}
}