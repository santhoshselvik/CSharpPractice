using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class Company
    {
        //members
        public int CompanyId { get; set; } 
        public string CompanyName { get; set; } 

        public string Location { get; set; }

        public Company(int companyid , string companyname , string location)
        {
            this.CompanyId = companyid;
            this.CompanyName = companyname;
            this.Location = location;
            
        }
       
        public void DisplayCompanyDetails()
        {
            Console.WriteLine($"ID:{CompanyId}, Name: {CompanyName} , Location:{Location}");
        }

        public void DisplayData()
        {
            Console.WriteLine($"Id:{CompanyId} , Name : {CompanyName}");
        }

        

    }
}
