using System;
using System.Collections.Generic;
using System.Text;

namespace concepts.StaticKeywordDemo
{
    class Exampleinterview
    {

        static int a = 0;
        int b = 0;

        public void Increment()
        {
            a++; 
            b++;
        }

        public void Show()
        {
            Console.WriteLine(a + " " + b);
        }

        //---------------------------------------------------------------------------

        static int apple = 5;
        int banana = 10;

        public void change()
        {
            apple  += 5;
            banana += 5;
        }

        public static void main()
        {
            //Exampleinterview ei = new Exampleinterview();  
            //Exampleinterview ei2 = new Exampleinterview();

            //ei.Increment();
            //ei.Show();      //a=1 , b=1

            //ei.Increment(); 
            //ei.Show();      //a=2 , b=2

            //ei2.Show();      //a=2 , b=0
            //ei2.Increment(); 
            //ei2.Show();      //a=3 , b=1


            Exampleinterview calc = new Exampleinterview();
            calc.change();

            Console.WriteLine(apple);           //10

            Exampleinterview calc2 = new Exampleinterview();
            calc2.change();

            Console.WriteLine(apple);           //15
            Console.WriteLine(calc.banana);     //15
            Console.WriteLine(calc2.banana);    //15
            Console.WriteLine(calc2.banana);    //15
            Console.WriteLine(calc2.banana);    //15
        }

    }
}
