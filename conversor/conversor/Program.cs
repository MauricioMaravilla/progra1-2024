using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace conversor {
    class Program {
   static void Main(string[] args) {
     conversores objconversor = new conversores();
     string continuar = "s";
      while (continuar == "s") {
       Console.WriteLine("::.. menu..::");
       Console.WriteLine("1. monedas.");
       Console.WriteLine("2. longitud.");
       Console.WriteLine("3. masa.");
       Console.WriteLine("4. tiempo.");
       Console.WriteLine("0. salir");
       Console.Write("opcion: ");
       int opcion = int.Parse(Console.ReadLine());

        if (opcion == 0) {
           continuar = "n";
        } else {
          for (int i = 1; i < objconversor.etiquetas[opcion].length; i++) {
                            Console.WriteLine("{0}. {1}", i, < objconversor.etiquetas[opcion][i]);

          }
          Console.Write("de: ");
          int de = int.Parse(Console.ReadLine());

          Console.Write("a:");
          int a = int.Parse(Console.ReadLine());

          Console.Write("cantidad:");
          double cantidad = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0} \n", objconversor.convertir(de, a, cantidad, opcion));


        }


      }

   }