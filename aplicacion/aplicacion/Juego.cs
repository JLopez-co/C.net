using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion
{
    class Juego{
        private decimal banca;
        private decimal montoI;
        public decimal Banca
        {
            get
            {
                return banca;
            }

            set
            {
                banca = value;
            }
        }

        public decimal MontoI
        {
            get
            {
                return montoI;
            }

            set
            {
                montoI = value;
            }
        }
        public decimal[] dinero(decimal MtoBanca,decimal montoJ,decimal montoInicial,String op){
            decimal[] a = new decimal[2];
            a[0] = 0;
            a[1] = 0;
            //Banca = MToBanca a[0]
            //MONTO = JUGADOR a[1]
            switch (op){
               case "Pon 1":
                    a[0] = MtoBanca + montoInicial;
                    a[1] = montoJ- montoInicial;
                    break;
               case "Pon 2":
                    a[0] = MtoBanca + (montoInicial*2);
                    a[1] = montoJ - (montoInicial * 2);
                    break;
                case "Toma 1":
                    a[0] = MtoBanca - montoInicial;
                    a[1] = montoJ + montoInicial;
                    break;
                case "Toma 2":
                    a[0] = MtoBanca - (montoInicial * 2);
                    a[1] = montoJ + (montoInicial * 2);
                    break;
                case "Toma todo :)":
                    a[1] = montoJ + MtoBanca;
                    a[0] = 0;
                    break;
            }
            return a;
        }

        public string opcion(int random){
            string op = "";
            string[] opciones ={
            "Pon 1",
            "Pon 2",
            "Toma 1",
            "Toma 2",
            "Toma todo :)"
           };
            op = opciones[random];
            return op;
        }
    }
}
