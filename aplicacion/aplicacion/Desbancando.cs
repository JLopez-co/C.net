using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion{
    public partial class Desbancando : Form{
        private Juego tab = new Juego();
        private List<Jugador> lista = new List<Jugador>();
        public decimal monBanca;
        public decimal monInicial;
        public int c;
        public Boolean turno = true;
        public Desbancando(List<Jugador> jugadores, decimal montoI) {
            monInicial=montoI;
            for (int i = 0; i < jugadores.Count; i++) {
                lista.Add(jugadores[i]);
            }
            InitializeComponent();
            timer1.Start();
        }

        private void Desbancando_Load(object sender, EventArgs e){
            c =0;
            Banca.Text = Banca.Text + (monInicial*lista.Count);
            lblJugador.Text = "Jugador: "+lista[0].Nombre;
            MontoJ.Text = "Dinero del jugador: " + lista[0].Monto;
        }
        private void btnDetener_Click(object sender, EventArgs e) {
            decimal[] resS = new decimal[2];
            monBanca = Convert.ToDecimal(Banca.Text);
            String a = ("Dale. ¿Que esperas?. ");
            if (turno==true) {
                timer1.Stop();
                Decimal montoJugador = lista[c].Monto;
                resS = tab.dinero(monBanca, montoJugador, monInicial,LMensaje.Text);
                lista[c].Monto = resS[1];
                if (resS[0]<1){
                    String men = Environment.NewLine+"Lista de jugadores:"+ Environment.NewLine;
                    foreach (var item in lista){
                        men = men + " Jugador: "+item.Nombre +" Dinero:"+item.Monto+ Environment.NewLine;
                    }
                    MessageBox.Show("No hay nada en la banca"+men);
                    Form1 sa = new Form1();
                    sa.Show();
                    this.Hide();
                }else{
                    Banca.Text = Convert.ToString(resS);
                }
                if (resS[1] < 0){
                    MessageBox.Show(lista[c].Nombre + ": Perdiste. nos debes " + resS[1] + " Paganos...");
                    lista.RemoveAt(c);
                }else if(resS[0]>0){
                    MessageBox.Show(lista[c].Nombre+": Sigues vivo tienes " + resS[1] + "$");
                }
                Banca.Text =""+resS[0];
                if (c + 1 >= lista.Count){
                    c = 0;
                }else{
                    c++;
                }
                if (lista.Count==1){
                    MessageBox.Show("Tu gananas " + lista[0].Nombre+ " Con " + lista[0].Monto+ " $");
                    Form1 sa = new Form1();
                    sa.Show();
                    this.Hide();
                }
                lblJugador.Text = "Jugador: " + lista[c].Nombre;
                MontoJ.Text = "Dinero del jugador: " + lista[c].Monto;
                btnDetener.Text = "¡Jugar!";
                LMensaje.Text = a;
                turno = false;
            }else if (turno==false) {
                btnDetener.Text = "Detener";
                timer1.Start();
                turno = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e){
            Random rr = new Random();
            int r = rr.Next(0, 5);
            LMensaje.Text = tab.opcion(r);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
