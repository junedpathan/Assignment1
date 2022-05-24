using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    public class EngineerPayroll : PayrollBase 
    {
        public override double CalculateTax(int netsalary)
        {
            TaxRules tax = new TaxRules();
            int slab = tax.GetTaxSlab(netsalary);
            return netsalary * ((double)slab / 100);
        }
        private int GetTeamWorkHours(int members)
        {
            return members * 22 * 10;
        }
        public override int CalculateIncome(EmployeeDTO emp)
        {
            EngineerDTO engineerDTO = new EngineerDTO();
            engineerDTO.Salary = emp.Salary;
            engineerDTO.TeamMembers = 100;
            engineerDTO.HRA = engineerDTO.Salary * 2;
            engineerDTO.TA = engineerDTO.Salary * 2;
            engineerDTO.DA = engineerDTO.Salary * 2;
            engineerDTO.OverTimeBonus = (int)(engineerDTO.Salary * 0.1);

            return engineerDTO.Salary + GetTeamWorkHours(engineerDTO.TeamMembers) + engineerDTO.HRA + engineerDTO.TA + engineerDTO.DA + engineerDTO.OverTimeBonus;
            // As it is implemetation of BAse
            //return base.CalculateIncome(emp);
        }
    }
}
