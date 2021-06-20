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
    public class IndexModel : PageModel
    {
        private readonly Nissan.Data.NissanContext _context;

        public IndexModel(Nissan.Data.NissanContext context)
        {
            _context = context;
        }

        public IList<Members> Members { get;set; }

        public async Task OnGetAsync()
        {
            Members = await _context.Members.ToListAsync();
        }
    }
}
