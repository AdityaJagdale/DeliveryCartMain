using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Models;

namespace DeliveryCart.Pages.DeliveryPersons
{
    public class IndexModel : PageModel
    {
        private readonly DbContext _context;

        public IndexModel(DbContext context)
        {
            _context = context;
        }

        public IList<DeliveryPerson> DeliveryPerson { get;set; }

        public async Task OnGetAsync()
        {
            DeliveryPerson = await _context.DeliveryPersons.ToListAsync();
        }
    }
}
