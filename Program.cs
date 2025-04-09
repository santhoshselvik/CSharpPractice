using OOPS_Concept;
using System.Collections;

namespace OOPSConcept;

class Program

{

    static void Main(string[] args)

    {
        //Company santhoshObj = new Company(1, "Santhosh" , "Chennai");
        //santhoshObj.DisplayCompanyDetails();

        //Company aarthiObj = new Company(2, "Aarthi", "Chennai");
        //aarthiObj.DisplayCompanyDetails();

        //Company IsaiObj = new Company(3, "Isai","Chennai");
        //IsaiObj.DisplayData();

        //Company thendralObj = new Company(4,"Thendral","Chennai");
        //thendralObj.DisplayCompanyDetails();

        Employee googleEmployee = new Employee(101,"Santhosh","Chennai",30000,1,"Google","TamilNadu");
        googleEmployee.DisplayCompanyDetails();
        googleEmployee.EmployeeCompanyDetails();
        googleEmployee.EmployeeDetails();

        //Interface
        googleEmployee.SalaryDetails();

        Boss facebookBoss = new Boss(102, "Selvi", "NewYork", 300000, 1, "facebook", "USA");
        //Company
        facebookBoss.DisplayCompanyDetails();

        //Parent_Employee
        facebookBoss.EmployeeCompanyDetails();
        facebookBoss.EmployeeDetails();

        //Interface
        facebookBoss.SalaryDetails();


        IntershipStudents InternEmployee = new IntershipStudents(103, "Aarthi", 30000, 1, "whatsapp", "USA");
        InternEmployee.DisplayCompanyDetails();

        //
        InternEmployee.InternEmployeeCompanyDetails();


    }


}