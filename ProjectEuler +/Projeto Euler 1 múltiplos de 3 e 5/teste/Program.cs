using System;
using System.Globalization;
using teste;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            long soma1 = 0;
            long soma2 = 0;
            long n = 99;

            for (int i = 0; i < n; i++)
            {
                if ((i % 3 == 0 || i % 5 == 0))
                {
                    soma1 += i;
                }
            }
            Console.WriteLine(soma1);
            
            long a = (n - 1) / 3;
            long b = (n - 1) / 5;
            long c = (n - 1) / 15;
            
            soma2 = 3 * SomaAritimetica(a) + 5 * SomaAritimetica(b) - (15 * SomaAritimetica(c));
            Console.WriteLine(soma2);

            while (n != 0)
            {               

                soma2 = 3 * SomaAritimetica(a) + 5 * SomaAritimetica(b) - (15 * SomaAritimetica(c));
                Console.WriteLine(soma2);

                n -= n;
            }
          

        }

        static public long SomaAritimetica(long n)
        {
            long resultado = (n + 1) * n / 2;
            return resultado;
        }
    }
    
}
