using System;

namespace Descobrir_quantos_vales
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            string[] path = new string[8] {"U", "D", "D", "D", "U", "D", "U", "U" };
            int nivelMar = 0;
            int altitude = 0;
            int contadorVale = 0;

            foreach(string degraus in path)
            {
                if(degraus == "U")
                {
                    altitude = altitude + 1;
                }
                else if (degraus == "D")
                {
                    altitude = altitude - 1;
                }
                Console.WriteLine("Altitude: " + altitude);



            }

        }
    }
}
