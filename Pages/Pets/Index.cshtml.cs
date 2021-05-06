using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EllroyVetClinic.Models;

namespace EllroyVetClinic.Pages.Pets
{
    public class IndexModel : PageModel
    {
        private readonly EllroyVetClinic.Models.PetContext _context;

        public IndexModel(EllroyVetClinic.Models.PetContext context)
        {
            _context = context;
        }

        public IList<Pet> Pet { get;set; }

        public async Task OnGetAsync()
        {
            Pet = await _context.Pet
                .Include(p => p.Owner)
                .Include(p => p.Veterinarian).ToListAsync();
        }
    }
}
