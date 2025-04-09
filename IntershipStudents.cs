using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class IntershipStudents : Company
    {
        public int InternEmployeeId { get; set; }

        public string InternEmployeeName { get; set; }

        public double Salary { get; set; }


        public IntershipStudents(int internEmployeeId , string internEmployeeName , double salary , int companyId , string companyName , string location) :base(companyId, companyName , location)
        {
            InternEmployeeId = internEmployeeId;
            InternEmployeeName = internEmployeeName;
            Salary = salary;
        }

        public void InternEmployeeCompanyDetails()
        {
            Console.WriteLine($"Employee Name :{InternEmployeeName}, Salary : {Salary}");
        }
    }
}
