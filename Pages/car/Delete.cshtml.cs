using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nissan.Data;
using Nissan.Models;

namespace Nissan.Pages.car
{
    public class DeleteModel : PageModel
    {
        private readonly Nissan.Data.NissanContext _context;

        public DeleteModel(Nissan.Data.NissanContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cars Cars { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cars = await _context.Cars.FirstOrDefaultAsync(m => m.Id == id);

            if (Cars == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cars = await _context.Cars.FindAsync(id);

            if (Cars != null)
            {
                _context.Cars.Remove(Cars);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
