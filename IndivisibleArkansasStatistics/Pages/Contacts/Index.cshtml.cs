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
    public class IndexModel : PageModel
    {
        private readonly IndivisibleArkansasStatistics.Data.IndivisibleArkansasStatisticsContext _context;

        public IndexModel(IndivisibleArkansasStatistics.Data.IndivisibleArkansasStatisticsContext context)
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
