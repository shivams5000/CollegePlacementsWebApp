using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CollegePlacementsWebApp.BusinessLayer;
using CollegePlacementsWebApp.Data;

namespace CollegePlacementsWebApp.Jobs
{
    public class DetailsModel : PageModel
    {
        private readonly CollegePlacementsWebApp.Data.PlacementDataContext _context;

        public DetailsModel(CollegePlacementsWebApp.Data.PlacementDataContext context)
        {
            _context = context;
        }

        public Job Job { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Job = await _context.Jobs
                .Include(j => j.Company).FirstOrDefaultAsync(m => m.JobID == id);

            if (Job == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
