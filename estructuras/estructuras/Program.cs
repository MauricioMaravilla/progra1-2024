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
            //estructuras de control.
            //1. if. ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            Console.Write("edad:");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18) {
                Console.WriteLine("Bienvenido al mundo de la responsabilidades");
            } else {
                Console.WriteLine("eres un adolescente");
            }

            //pausa.
            Console.ReadLine();
        }
    }
}
