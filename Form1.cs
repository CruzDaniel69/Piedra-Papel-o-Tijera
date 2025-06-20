using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piedra_papel_tijera
{
    public partial class frmPiedraPapelTijera : Form
    {
        int contarpuntos = 0, contarpuntosPC = 0;
        string jugador="", PC="";
        public frmPiedraPapelTijera()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            string[] seleccion = { "piedra", "papel", "tijera" };
            Random random = new Random();
            if (rbtnPapel1.Checked==true)
            {
                jugador = "papel";
            }
            else if (rbtnPiedra1.Checked==true)
            {
                jugador = "piedra";
            }
            else if (rbtnTijera1.Checked)
            {
                jugador = "tijera";
            }
            else
            {
                MessageBox.Show("Selecciona una opcion");
            }

            PC = seleccion[random.Next(0, 3)];

            if (PC == "piedra")
            {
                rbtnPiedra2.Checked = true;
            }
            else if (PC == "papel")
            {
                rbtnPapel2.Checked = true;
            }
            else if (PC == "tijera")
            {
                rbtnTijera2.Checked = true;
            }
            else
            {
                rbtnTijera2.Checked = true;
            }
            //comparar los resultados
            if (PC == jugador)
            {
                lblGanador.ForeColor = Color.White;
                lblGanador.BackColor = Color.YellowGreen;
                lblGanador.Text = "empate";
            }
            else if ((jugador == "piedra") && (PC == "tijera")||(jugador == "papel") && (PC == "piedra")|| (jugador == "tijera") && (PC == "papel"))
            {
                lblGanador.BackColor = Color.DarkGoldenrod;
                lblGanador.ForeColor= Color.White;
                lblGanador.Text = "Ganaste";
                contarpuntos++;
                txtScore1.Text=contarpuntos.ToString();
            }
            else
            {
                lblGanador.BackColor = Color.DarkRed;
                lblGanador.ForeColor = Color.White;
                lblGanador.Text = "Perdiste";
                contarpuntosPC++;
                txtScore2.Text = contarpuntosPC.ToString();
            }
            if (contarpuntos == 3)
            {
                MessageBox.Show("Felicidades, Ganaste el juego");
                Close();
            }
            else if (contarpuntosPC == 3)
            {
                MessageBox.Show("La computadora gano el juego");
                Close();
            }
        }
    }
}
