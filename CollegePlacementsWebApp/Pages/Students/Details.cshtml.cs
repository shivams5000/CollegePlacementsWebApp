using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CollegePlacementsWebApp.BusinessLayer;
using CollegePlacementsWebApp.Data;

namespace CollegePlacementsWebApp.Students
{
    public class DetailsModel : PageModel
    {
        private readonly CollegePlacementsWebApp.Data.PlacementDataContext _context;

        public DetailsModel(CollegePlacementsWebApp.Data.PlacementDataContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students
                .Include(s => s.Branch).FirstOrDefaultAsync(m => m.StudentID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
