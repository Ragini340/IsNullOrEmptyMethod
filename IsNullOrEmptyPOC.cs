using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNullOrEmptyMethod
{
   public class IsNullOrEmptyPOC
    {
        // To make similar method as IsNullOrEmpty
        public static bool check(string s)
        {
            return (s == null || s == String.Empty) ? true : false;
        }

       public static void Main(string[] args)
        {
            string s1 = "RaginiRagini";

            //Declaring String s2.Empty;
            string s2 = "";
            string s3 = null;

            bool b1 = check(s1);
            bool b2 = check(s2);
            bool b3 = check(s3);

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
        }
    }
}

