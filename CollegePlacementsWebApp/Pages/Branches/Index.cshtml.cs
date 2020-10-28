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
    public class IndexModel : PageModel
    {
        private readonly CollegePlacementsWebApp.Data.PlacementDataContext _context;

        public IndexModel(CollegePlacementsWebApp.Data.PlacementDataContext context)
        {
            _context = context;
        }

        public IList<Branch> Branch { get;set; }

        public async Task OnGetAsync()
        {
            Branch = await _context.Branches.ToListAsync();
        }
    }
}
