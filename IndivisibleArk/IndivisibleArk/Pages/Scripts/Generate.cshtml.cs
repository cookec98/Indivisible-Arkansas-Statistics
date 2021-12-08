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
        public string CurrentFilter { get; set; }
        public GenerateModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        public IList<Script> Script { get; set; }
        public IList<Contact> Contact { get; set; }
        public async Task OnGetAsync(string searchString)
        {
            Script = await _context.Script_1
                .Include(s => s.Interest).ToListAsync();
            CurrentFilter = searchString;
            IQueryable<Contact> contactsIQ = from c in _context.Contacts
                                             select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                contactsIQ = contactsIQ.Where(c => c.F_name.Contains(searchString)
                                       || c.L_name.Contains(searchString)
                                       || c.M_name.Contains(searchString));
            }
            Contact = await contactsIQ.AsNoTracking().ToListAsync();
        }
        
    }
}
