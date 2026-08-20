using System;
using System.Collections.Generic;
using System.Text;

namespace concepts.StaticKeywordDemo
{
    public static class Common
    {
        public static bool isEmpty(string value) {

            if (value.Length > 0)
            {
                return true;
            }

            return false;
        }

        public static string getMachineName()
        {

            return System.Environment.MachineName;
        }
    }
}
