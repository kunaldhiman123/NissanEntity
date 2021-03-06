using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nissan.Data;
using Nissan.Models;

namespace Nissan.Pages.login
{
    public class CreateModel : PageModel
    {
        private readonly Nissan.Data.NissanContext _context;

        public CreateModel(Nissan.Data.NissanContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public admin admin { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.admin.Add(admin);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
