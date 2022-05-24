using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    internal class DeveloperPayroll : PayrollBase
    {
        public override double CalculateTax(int netsalary)
        {
            TaxRules tax = new TaxRules();
            int slab = tax.GetTaxSlab(netsalary);
            return netsalary * ((double)slab / 100);
        }
        public override int CalculateIncome(EmployeeDTO emp)
        {
            DeveloperDTO developerDTO = new DeveloperDTO();
            developerDTO.Salary = emp.Salary;
            developerDTO.HRA = developerDTO.Salary * 2;
            developerDTO.TA = developerDTO.Salary * 2;
            developerDTO.DA = developerDTO.Salary * 2;
            developerDTO.OverTimeBonus = (int)(developerDTO.Salary * 0.1);
            developerDTO.TaskBonus = (int)(developerDTO.Salary * 0.2);

            return developerDTO.Salary + developerDTO.HRA + developerDTO.TA + developerDTO.DA + developerDTO.OverTimeBonus + developerDTO.TaskBonus;
            // As it is implemetation of BAse
            //return base.CalculateIncome(emp);
        }
    }
}
