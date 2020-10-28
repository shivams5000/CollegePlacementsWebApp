using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CollegePlacementsWebApp.BusinessLayer;
using CollegePlacementsWebApp.Data;

namespace CollegePlacementsWebApp.Branches
{
    public class DetailsModel : PageModel
    {
        private readonly CollegePlacementsWebApp.Data.PlacementDataContext _context;

        public DetailsModel(CollegePlacementsWebApp.Data.PlacementDataContext context)
        {
            _context = context;
        }

        public Branch Branch { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Branch = await _context.Branches.FirstOrDefaultAsync(m => m.BranchID == id);

            if (Branch == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
