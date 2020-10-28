using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CollegePlacementsWebApp.BusinessLayer;
using CollegePlacementsWebApp.Data;

namespace CollegePlacementsWebApp.Jobs
{
    public class EditModel : PageModel
    {
        private readonly CollegePlacementsWebApp.Data.PlacementDataContext _context;

        public EditModel(CollegePlacementsWebApp.Data.PlacementDataContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["CompanyID"] = new SelectList(_context.Companies, "CompanyID", "CompanyID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Job).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobExists(Job.JobID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool JobExists(int id)
        {
            return _context.Jobs.Any(e => e.JobID == id);
        }
    }
}
