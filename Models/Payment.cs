using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nissan.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string UName { get; set; }


        [Display(Name = "Salary")]
        public int Salary { get; set; }


        [Display(Name = "Date")]
        public DateTime PayDate { get; set; }

        public Members members { get; set; }



    }
}
