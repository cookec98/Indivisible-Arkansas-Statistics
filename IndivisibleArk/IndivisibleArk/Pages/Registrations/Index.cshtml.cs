using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IndivisibleArk.Data;
using IndivisibleArk.Models;

namespace IndivisibleArk.Pages.Registrations
{
    public class IndexModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public IndexModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        public IList<Registration> Registration { get;set; }

        public async Task OnGetAsync()
        {
            Registration = await _context.Registration_1
                .Include(r => r.Contact)
                .Include(r => r.Location).ToListAsync();
        }
    }
}
