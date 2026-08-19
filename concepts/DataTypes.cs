using System;
using System.Data;
using System.Runtime.Intrinsics.Arm;

//value-type

struct Employee
{
    public int EmployeeID;

    public int EmployeeSalary;
}

//reference-type

class Company
{
    public int CompanyID { get; set; }
    public int CompanySize { get; set; }
}

class DataTypes
{
    public static void Show()
    {
        //Employee e = new Employee();
        //e.EmployeeID = 1;
        //e.EmployeeSalary = 50000;

        //Employee e1 = e;
        //Employee e2 = e;

        //Console.WriteLine("Employee Salary before : " + e.EmployeeSalary);

        //e.EmployeeSalary = 75000;

        //Console.WriteLine("Employee Salary after : " + e.EmployeeSalary);
        //Console.WriteLine("Employee1 Salary : " + e1.EmployeeSalary);
        //Console.WriteLine("Employee2 Salary : " + e2.EmployeeSalary);

        //Company c = new Company();
        //c.CompanyID = 1;
        //c.CompanySize = 50;

        //Company c1 = c;
        //Company c2 = c;

        //Console.WriteLine("\n-----------------------------------------------------------------------------------------");
        //Console.WriteLine("\nCompany Size before : " + c.CompanySize);

        //c.CompanySize = 150;

        //Console.WriteLine("Company Size after : " + c.CompanySize);
        //Console.WriteLine("Company1 Size : " + c1.CompanySize);
        //Console.WriteLine("Company2 Size : " + c2.CompanySize);

        int a = 50;
        int b = a;
        Console.WriteLine("b value : " + b); //50
        b = 90;
        Console.WriteLine("a value : " + a); //50
        Console.WriteLine("b value : " + b); //90

        string val1 = "Pooja";
        string val2 = val1;
        Console.WriteLine("val1 value : " + val1); //Pooja
        Console.WriteLine("val2 value : " + val2); //Pooja

        val2 = "Arati";

        Console.WriteLine("val1 value : " + val1); //Pooja
        Console.WriteLine("val2 value : " + val2); //Arati

        // even the string is a reference type
        // still string is a IMMUTABLE - once the object is created it can not be change.

    }

    //---------------------------------------------------------------------------------------------------------------------------

    ////Call by
    //public static void Show()
    //{
    //    //call by Value Type
    //    Company c1 = new Company();
    //    c1.CompanyID = 1001;
    //    c1.CompanySize = 500;

    //    Company? c2 = c1;
    //    updateValue(c2);

    //    Console.WriteLine("Value of c1 : " + c1.CompanySize);
    //    Console.WriteLine("Value of c2 : " + c2.CompanySize);        


    //    //Console.WriteLine("Value of c2 : " + c2.CompanySize);

    //    //c2 = null;
    //    //Console.WriteLine("Value of c1 : " + c1.CompanyID);
    //    //Console.WriteLine("Value of c1 : " + c1.CompanySize);

    //    ////call by Reference type
    //    //int a = 19;
    //    //updateData(ref a);
    //    //Console.WriteLine(a);
    //}

    //static void updateData(ref int b)
    //{
    //    b = 30;
    //    Console.WriteLine(b);
    //}

    //static void updateValue(Company? c)
    //{
    //    c = null;
    //}

}


