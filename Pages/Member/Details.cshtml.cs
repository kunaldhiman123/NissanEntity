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
    public class DetailsModel : PageModel
    {
        private readonly Nissan.Data.NissanContext _context;

        public DetailsModel(Nissan.Data.NissanContext context)
        {
            _context = context;
        }

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
    }
}
