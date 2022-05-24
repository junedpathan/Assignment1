using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    internal static class Logger
    {
        public static void Log(EmployeeDTO employee)
        {
            Console.WriteLine($"Current Processed Employee is \t{employee.EmpNo}\t\t{employee.EmpName} \t\t\t{employee.Salary}\t\t\t{employee.Designation}\t\t{employee.DeptName}");
        }
    }
}
