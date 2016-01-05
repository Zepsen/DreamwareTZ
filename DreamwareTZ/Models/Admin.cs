using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamwareTZ.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public int? Number { get; set; }
    }
}