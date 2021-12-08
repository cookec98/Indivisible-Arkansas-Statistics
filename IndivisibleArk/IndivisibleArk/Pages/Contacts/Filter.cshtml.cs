using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IndivisibleArk.Pages.Contacts
{
    public class FilterModel : PageModel
    {
        private readonly IndivisibleArk.Data.ArkContext _context;

        public FilterModel(IndivisibleArk.Data.ArkContext context)
        {
            _context = context;
        }

        public JsonResult OnGet(int contact)
        {
            return new JsonResult(_context.Contacts.Where(c => c.ContactId == contact));
        }
    }

}
