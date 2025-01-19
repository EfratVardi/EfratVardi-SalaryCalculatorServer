using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.models
{
    public class SalaryCalculationInput
    {
        public int WorkPercentage { get; set; }
        public string ProfessionalLevel { get; set; }
        public string ManagementLevel { get; set; }
        public int YearsOfExperience { get; set; }
        public bool IsEligibleByLaw { get; set; }
        public string? Group { get; set; }
    }
}
