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
    public class DeleteModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public DeleteModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Registration Registration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Registration = await _context.Registration_1
                .Include(r => r.Contact)
                .Include(r => r.Location).FirstOrDefaultAsync(m => m.RegistrationID == id);

            if (Registration == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Registration = await _context.Registration_1.FindAsync(id);

            if (Registration != null)
            {
                _context.Registration_1.Remove(Registration);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
