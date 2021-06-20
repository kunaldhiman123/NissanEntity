using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nissan.Data;
using Nissan.Models;

namespace Nissan.Pages.Member
{
    public class DeleteModel : PageModel
    {
        private readonly Nissan.Data.NissanContext _context;

        public DeleteModel(Nissan.Data.NissanContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Members Members { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Members = await _context.Members.FirstOrDefaultAsync(m => m.Id == id);

            if (Members == null)
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

            Members = await _context.Members.FindAsync(id);

            if (Members != null)
            {
                _context.Members.Remove(Members);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
