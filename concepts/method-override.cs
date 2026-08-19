using System;
using System.Collections.Generic;
using System.Text;

namespace concepts
{
    class method_override
    {
        public static void overriding()
        {
            childClass cc = new childClass();
            cc.customer();
            //Console.ReadLine();

            baseClass b = new childClass();
            b.customer();
            Console.ReadLine();
        }

        class baseClass
        {
            // base class method gets called -> remove code from childclass and comment below code
            //public void customer()
            //{
            //    Console.WriteLine("customer method from baseclass!");
            //}

            public virtual void customer()
            {
                Console.WriteLine("customer method from baseclass!");
            }
        }

        class childClass : baseClass
        {
            public override void customer()
            {
                //base.customer();                                        //baseclass or parent class cutomer method gets called
                Console.WriteLine("customer method from childclass!");   
            }
        }

        // Real-time Example
        /*
         * We need to develop an application to calculate bonus based on designation of the employees.
         * 1. designation=developer then either 50000 or 20% of the salary as a bonus (whichever is higher).
         * 2. designation=manager then either 50000 or 25% of the salary as a bonus (whichever is higher).
         * 3. designation=admin then will get fixed 50000 as a bonus. 
         */

        public class Employee
        {
            public int id { get; set; }
            public string name { get; set; }
            public string designation { get; set; }
            public double salary { get; set; }

            public virtual double calculate_bonus(double salary)
            {
                return 50000;
            }
        }

        public class Developer : Employee
        {
            public override double calculate_bonus(double salary)
            {
                double baseBonus = base.calculate_bonus(salary);
                double basedonsalary = salary * .20;

                if (baseBonus >= basedonsalary)
                    return baseBonus;
                else
                    return basedonsalary;
            }
        }

        public class Manager : Employee
        {
            public override double calculate_bonus(double salary)
            {
                double baseBonus = base.calculate_bonus(salary);
                double basedonsalary = salary * .25;

                if (baseBonus >= basedonsalary)
                    return baseBonus;
                else
                    return basedonsalary;
            }
        }

        public class Admin : Employee
        {

        }

        public static void bonus()
        {
            Employee emp1 = new Developer { 
                id=1,
                name="Radha",
                designation= "Developer",
                salary=500000
            };

            double bonus1 = emp1.calculate_bonus(emp1.salary);
            Console.WriteLine($"Name:{emp1.name}, Designation: {emp1.designation}, salary: {emp1.salary}, bonus: {bonus1}");
            Console.WriteLine();

            Employee emp2 = new Manager
            {
                id = 2,
                name = "Rahul",
                designation = "Manager",
                salary = 800000
            };

            double bonus2 = emp2.calculate_bonus(emp2.salary);
            Console.WriteLine($"Name:{emp2.name}, Designation: {emp2.designation}, salary: {emp2.salary}, bonus: {bonus2}");
            Console.WriteLine();

            Employee emp3 = new Admin
            {
                id = 3,
                name = "Raman",
                designation = "Admin",
                salary = 200000
            };

            double bonus3 = emp3.calculate_bonus(emp3.salary);
            Console.WriteLine($"Name:{emp3.name}, Designation: {emp3.designation}, salary: {emp3.salary}, bonus: {bonus3}");
            Console.WriteLine();
        }

    }
}
