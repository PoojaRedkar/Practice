using System;

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
        Employee e = new Employee();
        e.EmployeeID = 1;
        e.EmployeeSalary = 50000;

        Employee e1 = e;
        Employee e2 = e;

        Console.WriteLine("Employee Salary before : " + e.EmployeeSalary);

        e.EmployeeSalary = 75000;

        Console.WriteLine("Employee Salary after : " + e.EmployeeSalary);
        Console.WriteLine("Employee1 Salary : " + e1.EmployeeSalary);
        Console.WriteLine("Employee2 Salary : " + e2.EmployeeSalary);

        Company c = new Company();
        c.CompanyID = 1;
        c.CompanySize = 50;

        Company c1 = c;
        Company c2 = c;

        Console.WriteLine("\n-----------------------------------------------------------------------------------------");
        Console.WriteLine("\nCompany Size before : " + c.CompanySize);

        c.CompanySize = 150;

        Console.WriteLine("Company Size after : " + c.CompanySize);
        Console.WriteLine("Company1 Size : " + c1.CompanySize);
        Console.WriteLine("Company2 Size : " + c2.CompanySize);
    }
}
