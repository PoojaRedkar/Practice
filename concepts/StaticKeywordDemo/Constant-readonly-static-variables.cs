using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace concepts.StaticKeywordDemo
{
    public class Constant_readonly_static_variables
    {
        readonly int i;         // readonly variable - value knows at the runtime. 
        //const float PI=3.14f;   // contant variable  - while declaration it is mandatory to intialize the value. 
        //static int y = 10;      // static variable   - created only once like constant

        public Constant_readonly_static_variables()
        {
            i = 900;
            i = 901;
        }

        public static void main()
        {
            Constant_readonly_static_variables c1 = new Constant_readonly_static_variables();
            //Console.WriteLine(PI); // compile time - value can not be change.
            //Console.WriteLine(y); //                 value can be change.
            //y = 250;
            //Console.WriteLine(y);
           // c1.i = 890;
            Console.WriteLine(c1.i);



        }
    }
}
