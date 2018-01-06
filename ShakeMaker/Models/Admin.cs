using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakeMaker.Models
{
    public class Admin
    {
        public string userName { get; set; }

        public string password { get; set; }

        public Admin(string name, string pass)
        {
            userName = name;
            password = pass;
        }
    }
}