using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nissan.Models
{
    public class Members
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string UName { get; set; }

        [Display(Name = "Mobile ")]
        public string Contact { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }



        [Display(Name = "Designation")]
        public string Designation { get; set; }

    }
}
