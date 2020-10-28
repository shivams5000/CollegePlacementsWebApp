using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegePlacementsWebApp.BusinessLayer
{
    public class Student
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public string FatherName { get; set; }

        public DateTime Dob { get; set; }

        public int BranchID { get; set; }

        public Branch Branch { get; set; }

        public float Percentage { get; set; }

        
    }
}
