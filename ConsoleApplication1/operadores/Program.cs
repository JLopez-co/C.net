using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores{
    class Program{
        static void Main(string[] args){
            //Que lindo comentario
            int resultado, cantidadMultiplicar;
            Console.Title=("Tablas de multiplicar");
            Console.Write("Digita el maximo de tablas que deseas ver...");
            cantidadMultiplicar = int.Parse(Console.ReadLine());
            /*for (int i = 1; i <= cantidadMultiplicar; i++){
                   for (int j = 1; j <= 10; j++){
                       resultado = i * j;
                       Console.WriteLine(i +" X "+ j +" = "+ resultado);

                   }
               }*/
            int i=1,j=1;
            while (i<=cantidadMultiplicar){
                while (j<=10){
                    resultado = i * j;
                    Console.WriteLine(i + " X " + j + " = " + resultado);
                    j++;
                }
                i++;
            }
            
            Console.ReadLine();
        }
    }
}
