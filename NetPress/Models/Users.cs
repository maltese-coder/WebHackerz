using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetPress.Models
{
    public class Users
    {
        [Key]
        public int userID { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public DateTime memberSince { get; set; }

        public virtual ICollection<Posts> Post{ get; set; }

    }
}