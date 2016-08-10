using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombre{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Digita tu nombre");
            string nombre = Console.ReadLine();
                        
            for (int i = (nombre.Length-1);  i>=0; i--){
                Console.WriteLine(nombre[i]);
            }
            Console.ReadLine();
        }
    }
}
