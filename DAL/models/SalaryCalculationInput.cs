using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models
{
    public class SalaryCalculationInput
    {
        public int WorkPercentage { get; set; }
        public int ProfessionalLevel { get; set; }
        public int ManagementLevel { get; set; }
        public int YearsOfExperience { get; set; }
        public bool IsEligibleByLaw { get; set; }
        public string? Group { get; set; }
    }
}
