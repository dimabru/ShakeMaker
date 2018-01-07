using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakeMaker.Models
{
    public class User
    {
        public string userName { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public List<Cocktails> favCocktails;

        public User(string name, string pass, string emal, List<Cocktails> cocktails)
        {
            userName = name;
            password = pass;
            email = emal;
            if (cocktails == null) favCocktails = new List<Cocktails>();
            else favCocktails = new List<Cocktails>(cocktails);
        }
    }
}