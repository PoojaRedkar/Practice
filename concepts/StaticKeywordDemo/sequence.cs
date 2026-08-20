using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace concepts.StaticKeywordDemo
{
    class sequence
    {
        //static contructor.
        //Execute only once.
        //first block of the code to be executed in the class.
        //before main method body start executing , this constructor will execute.
        static sequence()
        {
            Console.WriteLine("Inside static constructor..");
        }

        //non-static contructor.
        //execute once per object.
        //when we create an instance, this contructor will execute.
        public sequence(int i=10)
        {
            Console.WriteLine("Inside non-static constructor..");
        }

        //program execution will start from the main method.
        //but before executing the main method body , it will execute the static constructor.
        public static void main()
        {
            Console.WriteLine("Main method execution start...");
            sequence s1 = new sequence();
            sequence s2 = new sequence();
            Console.WriteLine("Main method execution end...");
            Console.ReadLine();
        }
    }
}
