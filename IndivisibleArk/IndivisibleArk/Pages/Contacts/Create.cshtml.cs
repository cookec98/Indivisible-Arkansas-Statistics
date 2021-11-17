using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IndivisibleArk.Data;
using IndivisibleArk.Models;

namespace IndivisibleArk.Pages.Contacts
{
    public class CreateModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public CreateModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["InterestId"] = new SelectList(_context.Set<Interest>(), "InterestId", "InterestId");
        ViewData["LocationId"] = new SelectList(_context.Set<Location>(), "LocationId", "LocationId");
            return Page();
        }

        [BindProperty]
        public Contact Contact { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Contact.Add(Contact);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
