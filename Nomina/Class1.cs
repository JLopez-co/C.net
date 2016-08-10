using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    class Class1
    {
        static void Main(String[] args) {
            Empleado empleado = new Empleado();
            empleado.NombreCompleto  = "Juan lopez";
            empleado.Documento = "1026297371";
            empleado.SueldoDiario = 20000m;
            empleado.Cargo = "Aprendiz";
            Console.WriteLine("Digira el salario del empelado ");
            int dias = int.Parse(Console.ReadLine());

            getDatos(empleado,dias);
            Console.ReadKey();
       }
        static void getDatos(Empleado empleado,int dias) {
            Console.WriteLine("El empleado  con nombre " + empleado.NombreCompleto+ " con documento "+empleado.Documento+",");
            Console.WriteLine("el cual desempeña el cardo de  "+empleado.Cargo+" tiene un salario de: "+empleado.CalcularSalario(dias));
        }
    }
}