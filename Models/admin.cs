using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nissan.Models
{
    public class admin
    {
        public int Id { get; set; }

        [Display(Name = "User Name")]
        public string UName { get; set; }

       

        [Display(Name = "Password")]
        public string Password { get; set; }

    }
}
