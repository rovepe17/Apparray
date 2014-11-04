using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apparray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] notas;
            int cont1, cont2 = 0, cont3 = 0;
            float nota;
            Console.WriteLine("programa notas:");
            notas = new float[5];
            {
                for (cont1 = 0; cont1 < 5; cont1++)
                {
                    Console.WriteLine("digite nota");
                    nota = float.Parse(Console.ReadLine());
                    notas[cont1] = nota;
                    if (nota >= 3)
                    {
                        cont2 = cont2 + 1;
                    }
                    else
                    {
                        cont3 = cont3 + 1;
                    }
                }
                Console.WriteLine("las notas mayores de 3 son:" + cont2);
                Console.WriteLine("las notas mayores de 3 son:" + cont3);
                Console.ReadKey();
            }
        }
    }
}
