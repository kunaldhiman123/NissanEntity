using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nissan.Models
{
    public class Sale
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string UName { get; set; }

        [Display(Name = "Mobile")]
        public string Contact { get; set; }


        [Display(Name = "Model ")]
        public string Model { get; set; }


        [Display(Name = "Address ")]
        public string Address{ get; set; }

        [Display(Name = "Date ")]
        public DateTime saleDate { get; set; }

        public Cars cars { get; set; }
    }

}
