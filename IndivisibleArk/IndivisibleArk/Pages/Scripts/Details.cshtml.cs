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
    public class DetailsModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public DetailsModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        public Script Script { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Script = await _context.Script_1
                .Include(s => s.Interest).FirstOrDefaultAsync(m => m.ScriptId == id);

            if (Script == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
