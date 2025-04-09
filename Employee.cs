using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeType { get; set; }

        public Employee(int employeeId , string employeeName ,string employeeType)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeType = employeeType;

        }

        public void EmployeeSalaryDetails()
        {
            if(EmployeeType.ToUpper()=="BOSS")
            {
                Salary();
            }
            else
            {
                Console.WriteLine("You are not the boss!");
            }
        }

        private void Salary()
        {
            Console.WriteLine("Salary:100000");
        }
    }
}
