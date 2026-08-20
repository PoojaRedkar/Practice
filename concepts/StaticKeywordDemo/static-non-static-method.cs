using System;
using System.Collections.Generic;
using System.Text;

namespace concepts.StaticKeywordDemo
{
    class static_non_static_method
    {
        int x = 69;
        static int y = 75;

        static void add()
        {
            //This is static block.
            //we can access the non-static members with the help of class object.
            //we can access static members directly or through class name.


            static_non_static_method obj1 = new static_non_static_method();
            Console.WriteLine("by using class : " + (obj1.x + static_non_static_method.y));  // non-static with obj = static by classname
            Console.WriteLine("by using class : " + (obj1.x + y)); // non-static with obj = static directly
        }

        void multiplication()
        {
            //This is a non-static method.
            //we can access static members directly or through class name.
            //we can access non-static members directcly or through this keyword.

            Console.WriteLine("multiplication : " + (this.x * static_non_static_method.y));
            Console.WriteLine("multiplication : " + (x * y));
        }

        public static void main()
        {
            //calling static method.
            static_non_static_method.add();
            add();

            //calling non-static method.
            static_non_static_method objmethod1 = new static_non_static_method();
            objmethod1.multiplication();

            Console.ReadLine();
        }


    }
}
