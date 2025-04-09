using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class Boss : Employee
    {

        public Boss(int employeeId, string employeeName, string address, double salary, int companyId, string companyName, string location) : base(employeeId, employeeName, address, salary, companyId, companyName, location)
        {

        }
        
    }
}
