using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Trinagulo{
    class Program{
        static void Main(string[] args){
            double [] longitud = new double[3];
            Console.Title = "Triangulos...";
            for (int i = 0; i < 3; i++){
                Console.WriteLine("Digita una longitud...  ");
                longitud[i]= double.Parse(Console.ReadLine());
            }
            if ( (((longitud[0] +longitud[1])== longitud[2]))      || (((longitud[2] + longitud[1]) == longitud[0]))  || (((longitud[2] + longitud[0]) == longitud[1])))
            {
                Console.WriteLine("las medidas" + longitud[0] + "," + longitud[1] + "," + longitud[2] + " dadas no son de ningun tipo de triangulo");
            }else if ((longitud[0] == longitud[1]) && (longitud[1] == longitud[2])) {
                Console.WriteLine("las medidas " + longitud[0] + "," + longitud[1] + "," + longitud[2] + " son de triangulo Equilatero");
            } else if ((longitud[0] == longitud[1]) || (longitud[1] == longitud[2]) ||(longitud[0] == longitud[2])) {
                Console.WriteLine("las medidas " + longitud[0] + "," + longitud[1] + "," + longitud[2] + " son de un triangulo Isosceles");
            } else if ((longitud[0] != longitud[1]) && (longitud[1] != longitud[2])&&(longitud[0] != longitud[2])) {
                Console.WriteLine("las medidas " + longitud[0] + "," + longitud[1] + "," + longitud[2] + " son de un triangulo Escaleno");
            }
            Console.ReadLine();
        }
    }
}
