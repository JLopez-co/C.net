using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matris
{
    class Program
    {
        static void Main(string[] args){

            var contador = 0;
            var contador1 = 0;
            Console.WriteLine("Digita un numero...");
            contador = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita un numero...");
            contador1 = int.Parse(Console.ReadLine());
            String[,] nombre = new string[contador, contador1];
            var a = nombre.GetLength(0);
            var b = nombre.GetLength(1);
            a = a - 1;
            b = b - 1;
            for (int i = 0; i < nombre.GetLength(0); i++){
                for (int j = 0; j < nombre.GetLength(1); j++){
                    nombre[i, j] ="-";
                    if (((i == 0)&&(j==0))  ||  ((a==i) && (j==0))  || ((b == j) && (i == 0)) || ((j == b) && (i==a))) {
                        nombre[i, j] = "X";
                    }
                    Console.Write(nombre[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
