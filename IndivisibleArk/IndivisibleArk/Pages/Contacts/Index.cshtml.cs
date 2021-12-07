using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IndivisibleArk.Data;
using IndivisibleArk.Models;

namespace IndivisibleArk.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public IndexModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public string ContactInterest { get; set; }
        public IList<Contact> Contact { get; set; }
        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            CurrentFilter = searchString;
            IQueryable<Contact> contactsIQ = from c in _context.Contacts
                                             select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                contactsIQ = contactsIQ.Where(c => c.F_name.Contains(searchString)
                                       || c.L_name.Contains(searchString)
                                       || c.M_name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    contactsIQ = contactsIQ.OrderByDescending(c => c.L_name);
                    break;
                case "Date":
                    contactsIQ = contactsIQ.OrderBy(c => c.Registration);
                    break;
                case "date_desc":
                    contactsIQ = contactsIQ.OrderByDescending(c => c.Registration);
                    break;
                default:
                    contactsIQ = contactsIQ.OrderBy(c => c.L_name);
                    break;
            }

            Contact = await contactsIQ.AsNoTracking().ToListAsync();
        }
    }
}
