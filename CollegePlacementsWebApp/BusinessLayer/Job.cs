using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegePlacementsWebApp.BusinessLayer
{
    public class Job
    {
        public int JobID { get; set; }

        public string JobTitle { get; set; }

        public string Package { get; set; }

        public int CompanyID { get; set; }

        public Company Company { get; set; }
    }
}
