using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IndivisibleArk.Data;
using IndivisibleArk.Models;

namespace IndivisibleArk.Pages.Scripts
{
    public class IndexModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public IndexModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; }

        public async Task OnGetAsync()
        {
            Contact = await _context.Contact
                .Include(c => c.Interest)
                .Include(c => c.Location).ToListAsync();
        }
    }
}
