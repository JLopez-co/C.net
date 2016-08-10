using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1{
    class Program{
        static void Main(string[] args){
            //que lindo comentario, por que no se guardo...
            string nombreCompleto;
            int edad;
            char cumpli;
            Console.Title = "Mi edad";
            Console.WriteLine("Digita tu nombre: ");
            nombreCompleto = Console.ReadLine();
            Console.WriteLine("Digita tu año de nacimiento: ");
            edad=int.Parse(Console.ReadLine();
            Console.WriteLine("¿Ya cumpliste años? S/N ");
            cumpli = char.Parse(Console.ReadLine());
            if ((cumpli == 's') || (cumpli == 'S')){
                edad = (2016 - edad);
            }else if ((cumpli == 'n') || (cumpli == 'N')) {
                edad = (2015 - edad);
            }
            Console.WriteLine( nombreCompleto +" Tu edad es: "+edad+" años");
            Console.ReadLine();
        }
    }
}
