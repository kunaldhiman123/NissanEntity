using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nissan.Models
{
    public class Cars
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string UName { get; set; }

        [Display(Name = "Model ")]
        public string Model { get; set; }

        [Display(Name = "Price")]
        public int Price { get; set; }



    }
}
