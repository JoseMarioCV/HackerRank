using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa faz o seguinte: acha numeros iguais assim fazendo com se tornen pares
            // por exemplo numa sequencia 1 1 1 2 2 2 3 e possivel achar 2 conjunto de numeros
            // iguais({1,1} , {2,2}) sobrando 3 numeros ({1, 2, 3}).
        
            int pares = 0;
            int[] meias = new int[9] {10 , 20 , 20 , 10 , 10 , 30 , 50 , 10 , 20 };
            Array.Sort(meias);//organiza vetor;
                              //0 1 2 3 4 5 6 7 8 9
                              //1 1 1 2 2 2 3

            if (meias.Length > 1)
            {
                for (int i = 0; i < meias.Length; i++)
                {

                    for (int j = i + 1 /*comando operação*/; j < meias.Length; j++)
                    {
                        if (meias[i] == meias[j])
                        {
                            pares++;
                            i++;
                            j++;
                            break;
                        }

                    }
                }
            }
            else { pares = 0; };

            foreach (int meia in meias) Console.Write("Meia " + meia + " ");
            Console.WriteLine();
            Console.WriteLine("Pares " + pares);
        }
    }
}
/*int[] meias = new int[100] { 44, 55, 11, 15, 4 , 72, 26, 91, 80,  14,
                                         43, 78, 70, 75, 36, 83, 78, 91, 17,  17,
                                         54, 65, 60, 21, 58, 98, 87, 45, 75,  97,
                                         81, 18, 51, 43, 84, 54, 66, 10, 44,  45,
                                         23, 38, 22, 44, 65, 9 , 78, 42, 100, 94,
                                         58, 5 , 11, 69, 26, 20, 19, 64, 64,  93,
                                         60, 96, 10, 10, 39, 94, 15, 4 , 3 ,  10,
                                         1 , 77, 48, 74, 20, 12, 83, 97, 5 ,  82,
                                         43, 15, 86, 5 , 35, 63, 24, 53, 27,  87,
                                         45, 38, 34, 7 , 48, 24, 100,14, 80,  54, };*/