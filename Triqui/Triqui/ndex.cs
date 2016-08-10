using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Triqui{
    class ndex {
        static void Main(string[] args){
            Console.WriteLine("¡Bienvenidos! Jugadores");
            Console.WriteLine("Danos tus datos jugador 1...");
            Console.WriteLine("Digita tu nombre jugador 1");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digita tu marca "+nombre);
            string marca = Console.ReadLine();
            Boolean turno = false;
            Jugador j = new Jugador(nombre,marca,turno);
            Console.Clear();
            Console.WriteLine("Danos tus datos jugador 2...");
            Console.WriteLine("Digita tu nombre jugador 2");
            nombre = Console.ReadLine();
            Console.WriteLine("Digita tu marca "+nombre);
            marca = Console.ReadLine();
            turno = true;
            Jugador j1 = new Jugador(nombre, marca, turno);
            Tablero tab = new Tablero();
            Console.Clear();
            done:
            tab.Iniciar();
            string consulta="nada";
            do{
                consulta=tab.Jugar(j.Marca, j1.Marca, j.Turno, j1.Turno, j.Nombre, j1.Nombre);
                Console.Clear();
                tab.mostrarTabla();
            } while (consulta=="nada");
            if (consulta == "False")
            {
                j1.Puntaje++;
            }
            else if (consulta == "True")
            {
                j.Puntaje++;
            }
            else if (consulta == "Empate") {
                Console.WriteLine("El juego termino en empate, Ops...");
            }
            string r= tab.Finalizar(j.Nombre, j1.Nombre, j.Puntaje, j1.Puntaje);
            Console.WriteLine(r);
            Console.WriteLine("Desean jugar denuevo? S/s");
            r = Console.ReadLine();
            if ((r.Equals("s")) || (r.Equals("S"))){
                Console.Clear();    
                goto done;
            }
            else {
                Console.WriteLine("Fin del juego resultados: \n "+ tab.Finalizar(j.Nombre, j1.Nombre, j.Puntaje, j1.Puntaje));
            }
            Console.ReadKey();
        }
    }
}
