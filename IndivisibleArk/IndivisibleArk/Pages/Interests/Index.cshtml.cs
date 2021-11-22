using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IndivisibleArk.Data;
using IndivisibleArk.Models;

namespace IndivisibleArk.Pages.Interests
{
    public class IndexModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public IndexModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        public IList<Interest> Interest { get;set; }

        public async Task OnGetAsync()
        {
            Interest = await _context.Interests.ToListAsync();
        }
    }
}
