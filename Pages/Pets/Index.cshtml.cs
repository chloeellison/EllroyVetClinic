using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EllroyVetClinic.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        public SelectList SortList {get; set;}

        public async Task OnGetAsync()
        {
            var query = _context.Pet.Select(p => p);
            List<SelectListItem> sortItems = new List<SelectListItem> {
                new SelectListItem {Text = "PetName Ascending", Value = "pet_asc"},
                new SelectListItem {Text = "PetName Descending", Value = "pet_desc"}
            };
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

            switch(CurrentSort)
            {
                case "pet_asc":
                    query = query.OrderBy(p => p.PetName);
                    break;
                case "pet_desc":
                    query = query.OrderByDescending(p => p.PetName);
                    break;
            }

            Pet = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
