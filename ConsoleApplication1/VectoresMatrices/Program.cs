using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresMatrices{
    class Program{
        static void Main(string[] args){
            var contador=0;
            
                Console.WriteLine("Digita un numero...");
                contador = int.Parse(Console.ReadLine());
            
            var q = contador;

            String[,] nombre = new string[contador,contador];
            for (int i = 0; i < nombre.GetLength(0); i++){
                q = q - 1;
                for (int j = 0; j < nombre.GetLength(1) ; j++){
                    
                    nombre[i, j] ="-";
                    if ((j==q) ||(i == j)){
                        nombre[i, j] = "X";
                    }
                    Console.Write(nombre[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
