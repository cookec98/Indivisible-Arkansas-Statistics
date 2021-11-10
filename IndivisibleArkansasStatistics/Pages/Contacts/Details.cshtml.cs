using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IndivisibleArkansasStatistics.Data;
using IndivisibleArkansasStatistics.Models;

namespace IndivisibleArkansasStatistics.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly IndivisibleArkansasStatistics.Data.ArkansasContext _context;

        public DetailsModel(IndivisibleArkansasStatistics.Data.ArkansasContext context)
        {
            _context = context;
        }

        public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = await _context.Contact
                .Include(c => c.Interest)
                .Include(c => c.Location).FirstOrDefaultAsync(m => m.ContactId == id);

            if (Contact == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
