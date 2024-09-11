using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write(" Num1 : ");​
            sbyte num1 = sbyte.Parse(Console.ReadLine());​​​   
            Boolean comprobar = true;
            Console.WriteLine(" El valor es: {0} ", comprobar);

            Console.WriteLine(" Num2 : ");​​
            sbyte num2 = sbyte.Parse(Console.ReadLine());​​​   
            Console.WriteLine(" Nombre : ");
            string nombre = Console.ReadLine();​​  

            int suma = num1 + num2;

            Console.WriteLine(" La suma de {0} + {1} = {2} ", num1, num2, suma);
            Console.WriteLine(" Hola {0} bienvenido ", nombre);

            DateTime fechaActual = new DateTime();
            fechaActual = DateTime.Now;
            Console.WriteLine(" La fecha actual es: {0} ", fechaActual);
            //Pausa.
            Console.ReadLine();
        }
    }
}
