using System;
using System.Collections;

namespace CS_OOPs_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Storing the employee details in array list
   
            ArrayList empdetails = new ArrayList();
            EmployeeLogic logic = new EmployeeLogic();
          
            for (int i = 1; i <= 3; i++)
            {
                EmployeeDTO emp = new EmployeeDTO();
                Console.WriteLine("Enter Employee Information as EmpNo, EmpName, Salary, Designation, DeptNAme in this order only");
               
                // Set values for propertes
                emp.EmpNo = Convert.ToInt32(Console.ReadLine());
                emp.EmpName = Console.ReadLine();
                emp.Salary = Convert.ToInt32(Console.ReadLine());
                emp.Designation = Console.ReadLine();
                emp.DeptName = Console.ReadLine();
                logic.AddEmployee(emp);
            }

            Console.WriteLine($"\t\t\t\tEmpNo \t\t EmpName \t\t Salary \t\t Designation \t\t DeptName");
            ArrayList emps = logic.GetEmployees();


            foreach (EmployeeDTO item in emps)
            {
                Logger.Log(item); // The static method

            }

            Console.WriteLine("Enter the Emp No of the Employee for the Payroll");
            int empno = Convert.ToInt32(Console.ReadLine());

            foreach (EmployeeDTO emp in emps)
            {

                if (emp.EmpNo == empno)
                {
                    if (emp.Designation == "Director")
                    {
                        DirectorPayroll director = new DirectorPayroll();
                        int income = director.CalculateIncome(emp);
                        double tax = director.CalculateTax(income);
                        Console.WriteLine($"Income of Director = {income} and payable tax is {tax}");
                    }
                    if (emp.Designation == "Manager")
                    {
                        ManagerPayroll manager = new ManagerPayroll();
                        int income = manager.CalculateIncome(emp);
                        double tax = manager.CalculateTax(income);
                        Console.WriteLine($"Income of Manager = {income} and payable tax is {tax}");
                    }
                    if (emp.Designation == "Engineer")
                    {
                        EngineerPayroll engineer = new EngineerPayroll();
                        int income = engineer.CalculateIncome(emp);
                        double tax = engineer.CalculateTax(income);
                        Console.WriteLine($"Income of Engineer = {income} and payable tax is {tax}");
                    }
                    if(emp.Designation == "Developer")
                    { 
                        DeveloperPayroll developer = new DeveloperPayroll();
                        int income = developer.CalculateIncome(emp);
                        double tax = developer.CalculateTax(income);
                        Console.WriteLine($"Income of Developer = {income} and payable tax is {tax}");
                    }
                }
            }   
            Console.WriteLine("Employee Information System");
            Console.ReadLine();
        }
    }
}
