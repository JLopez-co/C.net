using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triqui{
    class Jugador{
        private Boolean turno;
        private String marca;
        private int puntaje;
        private string nombre;
        public Jugador(string nombre,string marca,Boolean turno){
            Nombre = nombre;
            Marca = marca;
            puntaje = 0;
            Turno = turno;
        }
        public Boolean Turno{
            get{return turno;}
            set{turno = value;}
        }
        public string Marca{
            get{return marca;}
            set{marca = value;}
        }
        public int Puntaje{
            get{return puntaje;}
            set{puntaje = value;}
        }
        public string Nombre{
            get{
                return nombre;}
            set{nombre = value;}
        }
    }
}
