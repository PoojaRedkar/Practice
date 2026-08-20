using System;
using System.Collections.Generic;
using System.Text;

namespace concepts.StaticKeywordDemo
{
    class static_nonstatic_variables
    {

        int x; // non-static variable
        static int y = 56; // static variable

        public static_nonstatic_variables(int x)
        {
            this.x=x;
        }

        public static void Main()
        {
            //static variables
            Console.WriteLine($"Static Variable Y :  { static_nonstatic_variables.y}");
            Console.WriteLine($"Static Variable Y : {y} ");

            //Non-static variable - object creation
            static_nonstatic_variables obj1 = new static_nonstatic_variables(78);
            static_nonstatic_variables obj2 = new static_nonstatic_variables(98);

            Console.WriteLine($"obj1 : {obj1.x} \nobj2 : {obj2.x}");
            Console.WriteLine($"Static Variable Y : {y} ");

            Console.ReadLine();
        }

    }
}
