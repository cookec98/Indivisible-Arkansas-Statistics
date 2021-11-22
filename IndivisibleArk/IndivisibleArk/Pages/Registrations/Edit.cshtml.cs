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

namespace IndivisibleArk.Pages.Registrations
{
    public class EditModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public EditModel(IndivisibleArk.Data.ArkContext context)
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
           ViewData["ContactId"] = new SelectList(_context.Contact, "ContactId", "Address");
           ViewData["LocationId"] = new SelectList(_context.Locations, "LocationId", "LocationId");
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

            _context.Attach(Registration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistrationExists(Registration.RegistrationID))
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

        private bool RegistrationExists(int id)
        {
            return _context.Registration_1.Any(e => e.RegistrationID == id);
        }
    }
}
