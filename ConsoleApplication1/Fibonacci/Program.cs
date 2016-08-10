using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci{
    class Program{
        static void Main(string[] args){
            int x=0,y= 1,r=1;
            Console.Title = ("Serie Figonachi");
            Console.WriteLine("Digita El numero de resultados de la serie figonachi");
            int numeroResultados = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numeroResultados; i++){
                Console.Write(r + ",");
                r = x + y;
                x = y;
                y = r;
            }
            Console.ReadLine();
        }

    }
}
