using System;
using System.Collections.Generic;
using System.Text;

namespace concepts.StaticKeywordDemo
{
    class details
    {
        public static void showDetails()
        {
            CustomerDetails _custDetails = new CustomerDetails();
            _custDetails.customerID = 1001;
            _custDetails.customerName = "Meena";

            //Common common = new Common();
            if (!Common.isEmpty(_custDetails.customerName))
            {
                Console.WriteLine("Inside non empty values..");
            }
            else
            {
                Console.WriteLine("Inside empty values..");
            }

            var machineName = Common.getMachineName();

            Console.WriteLine(machineName);
        }

    }    

}
