using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetPress.Models
{
    public class Posts
    {

        public int postID { get; set; }
        public string title { get; set; }

        public string content { get; set; }

        public string category { get; set; }

        public int authorID { get; set; }

        public string status{ get; set; }

        public DateTime dateCreated { get; set; }

        public DateTime lastModified{ get; set; }

        public virtual Users Users{ get; set; }


    }
}