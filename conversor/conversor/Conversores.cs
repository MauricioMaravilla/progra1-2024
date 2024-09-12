using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor
{
    class Conversores {
        double[][] valores = new double[][] {
            new double[]{},//vacio solo para comenzar en 1
            new double[] {0,1, 7.73, 24.76, 36.89, 517.84, 8.75, 0.9 },//monedas
            new double[] {0,1, 100, 39.37, 3.28884, 1.196388, 1.09361, 0.001 },//longitud
            new double[] {0,1, 453.592, 16, 0.453592, 0.000446429 },//masa
            new double[] {0,1, 86400, 1440, 24, 0.142857, 0.032876643423, 0.0027397232876831892345 }//tiempo
        };
        public string[][] etiquetas = new string[][]{
            new string[] {},//vacio solo para comenzar en 1
            new string[] {"", "dolar","quetzal","lempira","cordoba","colon sv","euro"},//monedas
            new string[] {"", "metro","cm","pulgada","pie","vara","yarda","km"},//longitud
            new string[] {"", "libra","gramo","onza","kilogramo","tonelada larga",},//masa
            new string[] {"", "dia","sg","min","horas","semana","mes","año"},//tiempo
        };
        public double convertir(int de, int a, double cantidad, int opcion) { 
         return valores[opcion][a] / valores[opcion][de] * cantidad;

        }

    }
}


