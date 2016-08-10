using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Notas{
    class Program{
        static void Main(string[] args){
            double notas=0,parceReales;
            string promedio= "Promedio = (";
            int numero,i;
            Console.Title="Notas de un estudiante";
            Console.WriteLine("Digita el numero de nontas a realizar... ");
            numero = int.Parse(Console.ReadLine());
            for ( i = 1; i <= numero; i++){
                Console.WriteLine("Ingresa la nota # " + i + " ...");
                parceReales = double.Parse(Console.ReadLine());
                while ((parceReales < 0.0) || (parceReales > 5.0)){
                    Console.WriteLine("Digita la nota en el rango de 0,0 y 5,0 recuerda el , ej 3,0");
                    Console.WriteLine("Ingresa la nota # " + i + " ...");
                    parceReales = double.Parse(Console.ReadLine());
                }
    
                notas= (notas+ parceReales);
            }
            i = i - 1;
            notas = (notas / i);
            Console.WriteLine("Tu nota es "+notas);
            if ((notas >= 0.0) && (notas <= 1.9))
            {
                Console.WriteLine("Deficiente");
            }
            else if ((notas >= 2.0) && (notas <= 2.9))
            {
                Console.WriteLine("Insuficiente");
            }
            else if ((notas >= 3.0) && (notas <= 3.9))
            {
                Console.WriteLine("Aceptable");
            }
            else if ((notas >= 4.0) && (notas <= 4.9))
            {
                Console.WriteLine("Sobresaliente");
            }
            else if ((notas == 5.0))
            {
                Console.WriteLine("Excelente");
            }
            else {
                Console.WriteLine("ERROR ");    
            }
            Console.ReadLine();
        }
    }
}
