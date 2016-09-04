using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion
{
    public partial class Form1 : Form{
        List<Jugador> jugadores = new List<Jugador>();
        Juego tab = new Juego();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e){

        }

        private void button1_Click(object sender, EventArgs e){
            Jugador nuevoJugador = new Jugador();
            nuevoJugador.Nombre = TxtNombre.Text;
            nuevoJugador.Monto = nUJugador.Value;
            jugadores.Add(nuevoJugador);
            LCreado.Text= "Un nuevo jugador " + nuevoJugador.Nombre;
            TxtNombre.Text = "";
            int c = jugadores.Count;
            if (c == 1){
                nUpMonto.Enabled=false;
                tab.MontoI = nUpMonto.Value;
                nUJugador.Increment = nUpMonto.Value;
            }
            else if (c >= 2){
                button2.Enabled = true;
            }
            nUJugador.Value = nUpMonto.Value;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Desbancando des = new Desbancando(jugadores, tab.MontoI);
            des.Show();
            this.Hide();
        }
    }
}
