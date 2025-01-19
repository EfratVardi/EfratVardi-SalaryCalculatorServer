using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models
{
    public class SalaryCalculationResult
    {
        public decimal BaseSalary { get; set; }
        public decimal SeniorityBonus { get; set; }
        public decimal LawBonus { get; set; }
        public decimal InitialBaseSalary { get; set; }
        public decimal RaisePercentage { get; set; }
        public decimal RaiseAmount { get; set; }
        public decimal FinalSalary { get; set; }
    }
}
