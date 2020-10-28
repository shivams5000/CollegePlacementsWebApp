using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegePlacementsWebApp.BusinessLayer
{
    public class Company
    {
        public int CompanyID { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public int FoundedYear { get; set; }

        public int NoOfBranches { get; set; }
    }
}
