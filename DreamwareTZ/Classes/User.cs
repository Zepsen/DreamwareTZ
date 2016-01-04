using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamwareTZ.Classes
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDate { get; set; }

        public int Age
        {
            get
            {
                TimeSpan age = DateTime.UtcNow.Subtract(BirthDate);
                return age.Days/365;
            }
        }
    }
}