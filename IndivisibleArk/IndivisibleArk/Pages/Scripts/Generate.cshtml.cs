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
    public class GenerateModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public GenerateModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        public IList<Script> Script { get; set; }
        public async Task OnGetAsync()
        {
            Script = await _context.Script_1
                .Include(s => s.Interest).ToListAsync();
        }
    }
}
