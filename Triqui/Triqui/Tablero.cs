using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Triqui{
    class Tablero{
        private Boolean turno = false;
        private String[,] tab = new string[3,3];
        public string[,] Tab{
            get{return tab;}
            set{tab = value;}
        }
        public bool Turno{
            get {return turno;}
            set{turno = value;}
        }

        public string Jugar(string j1, string j2, Boolean tj, Boolean tj1,String jNom,String j1Nom){
            String marca="";
            int i=9, j=9;
            String respuesta = "nada";
                    if (tj == Turno) {
                        Console.WriteLine("Turno de " + jNom+" tu marca es: "+j1);
                        marca = j1;
                        Turno = true;
                    }
                    else if (tj1 == Turno){
                        Console.WriteLine("Turno de " + j1Nom+" tu marca es: "+j2);
                        marca = j2;
                        Turno = false;
                    }
                    Console.WriteLine("Digita la posicion y:");
                    i = Convert.ToInt32(Console.ReadLine());
                    i = valida(i);
                    Console.WriteLine("Digita la posicion x:");
                    j = int.Parse(Console.ReadLine());
                    j = valida(j);
            respuesta = existe(i, j,marca);
            
            string ganador = "";
            if (respuesta.Equals("True")) {
                ganador = "" + Turno;
            } else if (respuesta.Equals("Empate")) {
                ganador = "Empate";
            } else {
                ganador = "nada";
            }
            return ganador;   
        }
        public string existe(int v,int i,string marca){
            String respuesta,a;
            while (Tab[v, i] != v + "," + i){
                Console.WriteLine("aqui ya hay una marca, escoje otra posicion.");
                Console.WriteLine("Digita la posicion y:");
                v = Convert.ToInt32(Console.ReadLine());
                v = valida(v);
                Console.WriteLine("Digita la posicion x:");
                i = int.Parse(Console.ReadLine());
                i = valida(i);
            }
            respuesta = ValidarGanador(v, i, marca);
            a = respuesta;
            return a;
        }
        public int valida(int v){
            while (((v < 0) || (v > 2))){
                Console.WriteLine("Digita una posicion entre 1 y 3 ;)");
                v = int.Parse(Console.ReadLine());
            }
            return v;
        }
        public String ValidarGanador(int q, int w, String marca)
        {
            String Va = "False";
            Tab[q, w] = marca;
            if (Tab[q, w] != ""){
                //validaciones  horizontales
                if ((Tab[0, 0] == marca)&& (Tab[0,1] == marca)&& (Tab[0, 2] == marca)){
                    Va = "True";
                }
                if ((Tab[1, 0] == marca) && (Tab[1, 1] == marca) && (Tab[1, 2] == marca)){
                    Va = "True";
                }
                if ((Tab[2, 0] == marca) && (Tab[2, 1] == marca) && (Tab[2, 2] == marca)){
                    Va = "True";
                }
                //validaciones verticales
                if ((Tab[0, 0] == marca) && (Tab[1, 0] == marca) && (Tab[2, 0] == marca)){
                    Va = "True";
                }
                if ((Tab[0, 1] == marca) && (Tab[1, 1] == marca) && (Tab[2, 1] == marca)){
                    Va = "True";
                }
                if ((Tab[0, 2] == marca) && (Tab[1, 2] == marca) && (Tab[2, 2] == marca)){
                    Va = "True";
                }
                //Validaciones diagonales
                if ((Tab[0, 0] == marca) && (Tab[1, 1] == marca) && (Tab[2, 2] == marca)){
                    Va = "True";
                }
                if ((Tab[0, 2] == marca) && (Tab[1, 1] == marca) && (Tab[2, 0] == marca)){
                    Va = "True";
                }
                /*if ((Tab[0,0]!= 0+","+0) &&((Tab[0,1] != 0+","+1)) && (Tab[0,2] != 0+","+2) && (Tab[1,0] != 1+","+0) &&(Tab[1,1] != 1+","+1) && (Tab[1,2] != 1+","+2) && (Tab[2, 0] != 2+","+0) && (Tab[2, 1] != 2+","+1) && (Tab[2, 2] != 2+","+2)){
                    Va = "Empate";
                }*/
            }
            return Va;
        }
        public void mostrarTabla() {
            Console.WriteLine();
            Console.WriteLine(" " + Tab[0, 0] + " | " + Tab[0, 1] + " | " + Tab[0, 2]);
            Console.WriteLine(" -------------");
            Console.WriteLine(" " + Tab[1, 0] + " | " + Tab[1, 1] + " | " + Tab[1, 2]);
            Console.WriteLine(" -------------");
            Console.WriteLine(" " + Tab[2, 0] + " | " + Tab[2, 1] + " | " + Tab[2, 2]);
            Console.WriteLine();
        }
        public void Iniciar() {
            int a = Tab.GetLength(0);
            int b = Tab.GetLength(1);
            for (int i = 0; i < Tab.GetLength(0); i++){       
                for (int j = 0; j < Tab.GetLength(1); j++){
                    Tab[i, j] = i+","+j;
                }
            }
            Console.WriteLine();
            Console.WriteLine(" " + Tab[0,0] + " | " + Tab[0,1] + " | " + Tab[0,2]);
            Console.WriteLine(" -------------");
            Console.WriteLine(" " + Tab[1,0] + " | " + Tab[1,1] + " | " + Tab[1,2]);
            Console.WriteLine(" -------------");
            Console.WriteLine(" " + Tab[2,0] + " | " + Tab[2,1] + " | " + Tab[2,2]);
            Console.WriteLine();
        }
        public String Finalizar(string NJugador,string NJugador1, int CJugador,int CJugador1){
            string respuesta = "";
            if (CJugador > CJugador1) {
                respuesta=("Resultados: \n"+NJugador+" Gano con  "+ CJugador+ " y  "+NJugador1+" perdio con "+CJugador1);
            } else if (CJugador1 > CJugador) {
                respuesta = ("Resultados: \n" + NJugador1 + " Gano con  " + CJugador1 + " y  " + NJugador + " perdio con " + CJugador);
            } else {
                respuesta = ("Resultados: \n  El juego esta en empate: \n"+NJugador+" con puntaje de "+ CJugador+ " y  "+NJugador1+ " con puntaje de " + CJugador1);
            }
            return respuesta;
        }
    }
}
