using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamwareTZ.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public System.DateTime BirthDate { get; set; }

        public int Age
        {
            //Plug 
            get; set; // { return DateTime.UtcNow.Subtract(BirthDate).Days/365; }
        }
    }
}