using System;
using System.Collections.Generic;

namespace Repeated_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aba";
            long n = 10;
            char[] c = s.ToCharArray();
            long total_full_string = n / s.Length; //10/3 = 3,3333 como é long = 3
            long resto = n % s.Length; //10%3 = 1
            long count = 0;

            for (int i = 0; i < s.Length/*3*/; i++)
            {
                if (c[i] == 'a')
                {
                    count++;//2
                }
            }
            count *= total_full_string;
            for (int i = 0; i < resto; i++)
            {
                if (c[i] == 'a') count++;

            }
            Console.WriteLine(count);
            Console.WriteLine(total_full_string);
            Console.WriteLine(resto);
            Console.WriteLine(c);

            
        }
    }
}
