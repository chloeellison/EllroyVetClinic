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
    public class DetailsModel : PageModel
    {
        private readonly EllroyVetClinic.Models.PetContext _context;

        public DetailsModel(EllroyVetClinic.Models.PetContext context)
        {
            _context = context;
        }

        public Pet Pet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pet = await _context.Pet
                .Include(p => p.Owner)
                .Include(p => p.Veterinarian).FirstOrDefaultAsync(m => m.PetId == id);

            if (Pet == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
