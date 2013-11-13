using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GatoJuego
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Modo = 0;
            if (radioButton1.Checked == true){
                Modo = 1;
            }
            if(radioButton2.Checked == true){
                Modo = 2;
            }

            Juego nuevoJuego = new Juego(Modo);
            nuevoJuego.Show();
            this.Hide();
        }
    }
}
