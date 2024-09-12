using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Área (Superficie)");
            Console.WriteLine("-------------------------------");

            string[] unidades = { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea" };
            double[] conversiones = { 0.092903, 0.836127, 0.836127, 1, 0.01, 0.00064516, 0.01 };

            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Convertir de Pie Cuadrado");
            Console.WriteLine("2. Convertir de Vara Cuadrada");
            Console.WriteLine("3. Convertir de Yarda Cuadrada");
            Console.WriteLine("4. Convertir de Metro Cuadrado");
            Console.WriteLine("5. Convertir de Tareas");
            Console.WriteLine("6. Convertir de Manzana");
            Console.WriteLine("7. Convertir de Hectárea");

            Console.Write("Opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el valor a convertir: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Convertir de Pie Cuadrado");
                    resultado = ConvertirPieCuadrado(valor, unidades, conversiones);
                    break;
                case 2:
                    Console.WriteLine("Convertir de Vara Cuadrada");
                    resultado = ConvertirVaraCuadrada(valor, unidades, conversiones);
                    break;
                case 3:
                    Console.WriteLine("Convertir de Yarda Cuadrada");
                    resultado = ConvertirYardaCuadrada(valor, unidades, conversiones);
                    break;
                case 4:
                    Console.WriteLine("Convertir de Metro Cuadrado");
                    resultado = valor; // No es necesario convertir, ya que es la unidad base
                    break;
                case 5:
                    Console.WriteLine("Convertir de Tareas");
                    resultado = ConvertirTareas(valor, unidades, conversiones);
                    break;
                case 6:
                    Console.WriteLine("Convertir de Manzana");
                    resultado = ConvertirManzana(valor, unidades, conversiones);
                    break;
                case 7:
                    Console.WriteLine("Convertir de Hectárea");
                    resultado = ConvertirHectarea(valor, unidades, conversiones);
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    return;
            }

            Console.WriteLine($"El resultado es: {resultado} {unidades[opcion - 1]}");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static double ConvertirPieCuadrado(double valor, string[] unidades, double[] conversiones)
        {
            return valor / conversiones[0];
        }

        static double ConvertirVaraCuadrada(double valor, string[] unidades, double[] conversiones)
        {
            return valor / conversiones[1];
        }

        static double ConvertirYardaCuadrada(double valor, string[] unidades, double[] conversiones)
        {
            return valor / conversiones[2];
        }

        static double ConvertirTareas(double valor, string[] unidades, double[] conversiones)
        {
            return valor / conversiones[4];
        }

        static double ConvertirManzana(double valor, string[] unidades, double[] conversiones)
        {
            return valor / conversiones[5];
        }

        static double ConvertirHectarea(double valor, string[] unidades, double[] conversiones)
        {
            return valor / conversiones[6];
        }
    }
}
