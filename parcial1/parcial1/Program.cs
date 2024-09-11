using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            String continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("\n \n * MENU *");
                Console.WriteLine("1. Conversor de monedas");
                Console.WriteLine("2. Conversor de masas");
                Console.WriteLine("3. Conversor de Volumen");
                Console.WriteLine("4. Conversor de Almacenamiento");
                Console.WriteLine("5. Conversor de Tiempo");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Opcion : ");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        monedas();
                        break;
                    case 2:
                        masas();
                        break;
                    case 3:
                        volumen();
                        break;
                    case 4:
                        almacenamiento();
                        break;
                    case 5:
                        tiempo();
                        break;
                    case 6:
                        continuar = "n";
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta \n\n");
                        break;
                }
            }
        }
        static void monedas()
        {
            // Definimos la matriz de tasas de conversión (10x10)
            double[,] tasas = {
            {1, 0.85, 0.76, 0.74, 1.34, 0.75, 7.13, 83.77, 5.47, 19},  // USD
            {1.18, 1, 0.89, 0.87, 1.58, 0.88, 1.62, 1.10, 0.81, 1.70},  // EUR
            {1.32, 1.12, 1, 0.97, 1.77, 0.99, 1.82, 1.24, 0.91, 1.91},  // GBP
            {1.35, 1.15, 1.03, 1, 1.83, 1.03, 1.86, 1.28, 0.93, 1.96},  // CAD (dolar canadiense)
            {0.75, 0.63, 0.56, 0.55, 1, 0.56, 1.02, 0.70, 0.50, 1.07},  // AUD (dolar australiano)  
            {1.33, 1.14, 1.01, 0.97, 1.79, 1, 1.80, 1.27, 0.93, 1.92},  // JPY
            {0.73, 0.62, 0.55, 0.54, 0.98, 0.56, 1, 0.70, 0.51, 1.06},  // CNY
            {1.07, 0.91, 0.81, 0.78, 1.43, 0.79, 1.42, 1, 0.73, 1.51},  // INR
            {1.45, 1.23, 1.10, 1.08, 2.00, 1.08, 1.96, 1.37, 1, 1.80},  // BRL
            {0.69, 0.59, 0.52, 0.51, 0.93, 0.52, 0.94, 0.66, 0.56, 1}   // MXN
            };

            // Nombres de las monedas
            string[] monedas = { "USD", "EUR", "GBP", "CAD", "AUD", "JPY", "CNY", "INR", "BRL", "MXN" };

            Console.WriteLine("Convertidor de monedas: \n\n ");
            Console.WriteLine("Seleccione la divisa de origen (0-9):");
            for (int i = 0; i < monedas.Length; i++)
            {
                Console.WriteLine($"{i}. {monedas[i]}");
            }
            int origen = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la divisa de destino (0-9):");
            for (int i = 0; i < monedas.Length; i++)
            {
                Console.WriteLine($"{i}. {monedas[i]}");
            }
            int destino = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el monto a convertir:");
            double monto = double.Parse(Console.ReadLine());

            double resultado = monto * tasas[origen, destino];
            Console.WriteLine($"El monto convertido es: {resultado} {monedas[destino]}");

            Console.ReadLine();
        }

        static void masas()
        {
            //definimos las tasas de conversion
            double[,] medidas = {
                {1, 0.45, 4.54, 45.36, 453.59, 2267.69,45359.24, 4535982.37, 453592370, 0.0005 },//LIBRA 
                {2.2, 1, 10, 100, 1000, 5000, 100000, 1000000, 1000000000, 0.001 },//KILOGRAMO
                {0.22, 0.1, 1, 10, 100, 500, 10000, 100000,100000000, 0.0001  },//HECTOGRAMO 
                {0.022, 0.01, 0.1, 1 , 10, 50, 1000, 10000, 1000000000, 0.00001 },//DECAGRAMO 
                {0.0022, 0.001, 0.01, 0.1, 1, 5, 100, 1000, 1000000, 0.000001 },//GRAMO 
                {0.000441, 0.0002, 0.002, 0.02, 0.2, 1, 20, 200, 200000, 0.0000001 },//QUILATE 
                {0.000022, 0.00001, 0.0001, 0.001, 0.001, 0.05, 1, 10, 10000, 0.00000001 },//CENTIGRAMO 
                {0.000002, 0.000001, 0.00001, 0.0001, 0.001, 0.005, 0.1, 1, 1000, 0.000000001},//MILIGRAMO 
                {0.0000000022, 0.000000001, 0.00000001, 0.0000001, 0.000001, 0.000005,0.0001, 0.001, 1, 0.000000000001 },//MICROGRAMO 
                {2204.6226218, 1000, 10000, 100000, 1000000 , 5000000, 100000000, 1000000000, 1000000000000, 1 },//TONELADA
            };
            // nombre de las medidas de masa
            string[] masas = { "Libra", "kilogramo", "Hectogramo", "Decagramo", "Gramo", "Quilate", "Centigramo", "Miligramo", "Microgramo", "Tonelada" };

            Console.WriteLine("Convertidor de masa:\n\n");
            Console.WriteLine("Seleccione la medida de origen (0-9):");
            for (int i = 0; i < masas.Length; i++)
            {
                Console.WriteLine($"{i}. {masas[i]}");
            }
            int origen = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la medida de destino (0-9):");
            for (int i = 0; i < masas.Length; i++)
            {
                Console.WriteLine($"{i}.{masas[i]}");
            }
            int destino = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el peso a convertir: ");
            double peso = double.Parse(Console.ReadLine());

            double resultado = peso * medidas[origen, destino];
            Console.WriteLine($"El peso convertido es :{resultado} {masas[destino]}");

            Console.ReadLine();
        }

        static void volumen()
        {
            //definimos las tasas de conversion
            double[,] medidas = {
                {1, 0.004, 3.785, 37.854, 378.541, 3785.41, 3785.41, 0.024, 8, 3785409.668 },// Galon
                {0.0000002641722, 1, 0.000001, 0.00001, 0.0001, 0.001, 0.001, 0.000000006110602, 0.000002113, 1  },// metro cubico
                {0.2641722, 0.001, 1, 10, 100, 1000, 1000, 0.006289813, 1.759751, 1000000   },// litro
                {0.02199688, 0.0001, 0.1, 1, 10, 100, 100, 0.00061106, 0.2113376, 100000 },// decilitro
                {0.002641722, 0.00001, 0.01, 0.1, 1, 10, 10, 0.000061106, 0.01759751, 10000 },// centilitro
                {0.000264172,0.000001 ,0.001, 0.01, 0.1, 1, 1, 0.000006111, 0.001759751,1000 },// centimetro cubico
                { 0.000219969, 0.000001, 0.001, 0.01, 0.1, 1, 1, 0.000006111, 0.002113376, 1000},// mililitro
                {35.997893497 , 0.163649997, 163.6499972, 1636.499972, 16364.99972, 163649.9972, 163649.9972, 1, 287.9832462, 163649997.2 },// Barril
                {0.104084082, 0.000473177, 0.473176567, 4.731765668 , 47.317656678, 473.1765668, 473.1765668, 0.002891394, 1, 473176.5668 },// pinta
                {0.0000002199688, 0.000000001, 0.000001, 0.00001, 0.0001, 0.001 ,0.001,  0.000000006289813, 0.000002113, 1  },// microlitro
            };

            // nombre de las medidas de volumen
            string[] volumen = { "Galon", "Metro cubico", "Litro", "Decilitro", "Centilitro", "Centimetro cubico", "Milimetro", "Barril", "Pinta", "Microlitro" };

            Console.WriteLine("Convertidor de volumen:\n\n");
            Console.WriteLine("Seleccione la medida de origen (0-9):");
            for (int i = 0; i < volumen.Length; i++)
            {
                Console.WriteLine($"{i}. {volumen[i]}");
            }
            int origen = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la medida de destino (0-9):");
            for (int i = 0; i < volumen.Length; i++)
            {
                Console.WriteLine($"{i}.{volumen[i]}");
            }
            int destino = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad a convertir: ");
            double cantidad = double.Parse(Console.ReadLine());

            double resultado = cantidad * medidas[origen, destino];
            Console.WriteLine($"El peso convertido es :{resultado} {volumen[destino]}");

            Console.ReadLine();

        }

        static void almacenamiento()
        {
            // definimos las tasas de conversion
            double[,] medidas = {
                {1, 1024, 1048575.98, 1073741708,1099511509000, 1125899785000000,1152921380000000000,9223371041000001000, 2305842760000000000, 9007198282000000  },//Exabyte
                {0.000976562, 1, 1023.999952, 1048575.859, 1073741679, 1099511480000, 1125899755000000, 9007198042000000, 2251799511000000, 8796091838000  },//Petabyte
                {0.0000009536743358, 0.000976563, 1, 1023.99991, 1048575.908, 1073741730, 1099511531000, 8796092251000, 2199023063000, 8589933839 },//Terabyte
                {0.0000000009313226752, 0.0000009536744448, 0.000976563, 1, 1024, 1048576, 1073741824, 8589934592 , 2147483648,8388608 },//Gigabyte
                { 0.0000000000009094948, 0.0000000009313227, 0.0000009536744, 0.000976563, 1, 1024, 1048576, 8388608, 2097152, 8192  },//Megabyte
                {0.0000000000000008881785156, 0.0000000000009094948242, 0.0000000009313226562, 0.0000009536743164, 0.000976563, 1, 1024, 8192, 2048, 8 },//kilobyte
                {0.0000000000000000008674, 0.0000000000000008881785393, 0.0000000000009094947815, 0.0000000009313225746, 0.0000009536743164, 0.000976563, 4, 8, 2, 0.0078125 },//byte
                {0.0000000000000000001084, 0.0000000000000001110223174, 0.0000000000001136868477, 0.0000000001164153218, 0.0000001192092896, 0.00012207, 0.125, 1,0.25, 0.000976563 },//bit
                {0.0000000000000000004337, 0.0000000000000004440892696, 0.0000000000004547473907, 0.0000000004656612873, 0.0000004768371582, 0.000488281, 0.5, 4, 1, 0.00390625 },//nibble
                {0.0000000000000041110223145, 0.000000000000113686853, 0.000000000116415332, 0.0000001192092896, 0.00012207, 0.125,128, 1024, 256, 1 },//kilobit

            };

            // nombre de las medidas de almacenamiento
            string[] almacenamiento = { "Exabyte", "Petabyte", "Terabyte", "Gigabyte", "Megabyte", "kilobyte", "byte", "bit", "Nibble", "Kilobit" };

            Console.WriteLine("Convertidor de almacenamiento:\n\n");
            Console.WriteLine("Seleccione la medida de origen (0-9):");
            for (int i = 0; i < almacenamiento.Length; i++)
            {
                Console.WriteLine($"{i}. {almacenamiento[i]}");
            }
            int origen = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la medida de destino (0-9):");
            for (int i = 0; i < almacenamiento.Length; i++)
            {
                Console.WriteLine($"{i}.{almacenamiento[i]}");
            }
            int destino = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad a convertir: ");
            double cantidad = double.Parse(Console.ReadLine());

            double resultado = cantidad * medidas[origen, destino];
            Console.WriteLine($"La cantidad convertida es :{resultado} {almacenamiento[destino]}");

            Console.ReadLine();
        }

        static void tiempo()
        {
            //definimos la tasa de conversion
            double[,] medidas = {
            {1, 0.001,0.000001, 0.000000001, 0.000000000016666666667, 0.00000000000027777777778, 0.000000000000011574074074, 0.0000000000000016534391082, 0.00000000000000038025705377, 0.00000000000000003169 },//Nanosegundos
            {1000, 1, 0.001, 0.000001, 0.000000016666666667, 0.00000000027777777778, 0.000000000011574074074, 0.0000000000016534391082, 0.00000000000038025705377, 0.000000000000031688087814 },//Microsegundos
            {1000000, 1000, 1, 0.001, 0.0000166667, 0.00000027777777778, 0.000000011574074074, 0.0000000016534391082, 0.00000000038025705377, 0.000000000031688087814 },//Milisegundos
            {1000000000, 1000000, 1000, 1, 0.0166666667,0.0002777778, 0.0000115741, 0.0000016534, 0.00000038025705377, 0.000000031688087814 },//Segundos
            {60000000000, 60000000, 60000, 60, 1, 0.0166666667, 0.0006944444,0.0000992063, 0.0000228154, 0.0000019013 },//Minuto
            { 3600000000000, 3600000000, 3600000, 3600, 60, 1, 0.0416666667, 0.0059523808, 0.0013689254, 0.0001140771},//Horas
            {86400000000000,86400000000, 86400000, 86400,1440, 24, 1, 0.1428571389, 0.0328542094, 0.0027378508 },//Dias
            { 604800016560000, 604800016560, 604800016.56, 604800.01656, 10080.000276, 168.0000046, 7.0000001916, 1, 0.2299794724, 0.019164956},//Semanas
            {2629800000000000, 2629800000000, 2629800000, 2629800, 43830, 730.5, 30.4375, 4.3482141667, 1, 0.0833333333 },//Meses
            {31557600000000000, 31557600000000, 31557600000, 31557600, 525960, 8766, 365.25, 52.17857, 12, 1  },//Años
            };

            //nomrbre de las medidas de tiempo
            string[] tiempo = { "Nanosegundos", "Microsegundos", "Milisegundos", "Segundos", "Minutos", "Horas", "Dias", "Semanas", "Meses", "Año" };

            Console.WriteLine("Convertidor de almacenamiento:\n\n");
            Console.WriteLine("Seleccione la medida de origen (0-9):");
            for (int i = 0; i < tiempo.Length; i++)
            {
                Console.WriteLine($"{i}. {tiempo[i]}");
            }
            int origen = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la medida de destino (0-9):");
            for (int i = 0; i < tiempo.Length; i++)
            {
                Console.WriteLine($"{i}.{tiempo[i]}");
            }
            int destino = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad a convertir: ");
            double cantidad = double.Parse(Console.ReadLine());

            double resultado = cantidad * medidas[origen, destino];
            Console.WriteLine($"La cantidad convertida es :{resultado} {tiempo[destino]}");

            Console.ReadLine();
        }
    }
}
