using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nissan.Models;

namespace Nissan.Pages.login
{
    public class LoginModel : PageModel
    {
        private readonly Nissan.Data.NissanContext _context;
        public LoginModel(Nissan.Data.NissanContext context)
        {
            _context = context;
        }

        [BindProperty]
        public admin admin { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            
            try
            {
                if (admin.UName.Equals("admin") && admin.Password.Equals("admin")) {
                    return RedirectToPage("./Dashboard");
                }
            }
            catch (DbUpdateConcurrencyException)
            {
               
            }

            return RedirectToPage("./Index");
        }


    }
}
