using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IndivisibleArk.Data;
using IndivisibleArk.Models;

namespace IndivisibleArk.Pages.Scripts
{
    public class EditModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public EditModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["InterestId"] = new SelectList(_context.Interests, "InterestId", "InterestId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Script).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScriptExists(Script.ScriptId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ScriptExists(int id)
        {
            return _context.Script_1.Any(e => e.ScriptId == id);
        }
    }
}
