using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieWebSite.Models
{
    public class CommentModel
    {
        public virtual int CommentId { get; set; }
        public virtual int ReplyId { get; set; }
        public virtual ReplyModel Reply { get; set; }
    }
}