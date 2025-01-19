using AutoMapper;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Functions
{
    public class CalculateBll : ICalculateBll
    {
        ICalculateDal dal;

        public CalculateBll(ICalculateDal dal)
        {
            this.dal = dal;
        }
        public SalaryCalculationResult CalculateSalary(SalaryCalculationInput input)
        {
            // שכר יסוד לפי רמה מקצועית
            decimal hourlyRate = input.ProfessionalLevel == 1 ? 100 : 120;

            // תוספת ניהול
                hourlyRate += input.ManagementLevel * 20;

            // שכר יסוד
            decimal baseSalary = hourlyRate * 170 * (input.WorkPercentage / 100m);

            // תוספת וותק
            decimal seniorityBonus = input.YearsOfExperience * baseSalary * 0.0125m;

            // תוספת חוק
            decimal lawBonus = 0;
            if (input.IsEligibleByLaw)
            {
                lawBonus = baseSalary * (input.Group == "A" ? 0.01m : 0.005m);
            }

            // חישוב שכר בסיס
            decimal initialBaseSalary = baseSalary + seniorityBonus + lawBonus;

            // חישוב תוספת העלאה
            decimal raisePercentage = initialBaseSalary <= 20000
                ? 0.015m
                : initialBaseSalary <= 30000
                    ? 0.0125m
                    : 0.01m;

            // תוספת רמת ניהול
            raisePercentage += input.ManagementLevel * 0.001m;

            decimal raiseAmount = initialBaseSalary * raisePercentage;

            // חישוב שכר סופי
            decimal finalSalary = initialBaseSalary + raiseAmount;

            return new SalaryCalculationResult
            {
                BaseSalary = baseSalary,
                SeniorityBonus = seniorityBonus,
                LawBonus = lawBonus,
                InitialBaseSalary = initialBaseSalary,
                RaisePercentage = raisePercentage * 100,
                RaiseAmount = raiseAmount,
                FinalSalary = finalSalary
            };
        }
      
    }
}
