using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miprimerproyecto
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("num1:");
            sbyte num1 = sbyte.Parse(Console.ReadLine());

            Console.Write("num2:");
            sbyte num2 = sbyte.Parse(Console.ReadLine());

            int suma = num1 + num2;
            Console.WriteLine("la suma de {0} + {1} = {2}", num1, num2, suma);


            //pausa.
            Console.ReadLine();
            

        }
    }
}
