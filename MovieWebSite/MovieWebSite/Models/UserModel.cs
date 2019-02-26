using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieWebSite.Models
{
    public class UserModel
    {
        public virtual int UserID { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime UserDOB { get; set; }
        public virtual string PhoneNO { get; set; }
        public virtual int CommentID { get; set; }
        public virtual CommentModel Comment { get; set; }
    }
}