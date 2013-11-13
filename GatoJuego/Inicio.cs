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

        //Jugar
        private void button1_Click(object sender, EventArgs e)
        {
            //Verifica cual modo se eligió. 1 = usuario/usuario y 2 = usuario/computadora.
            int Modo = 0;
            if (radioButton1.Checked == true){
                Modo = 1;
            }
            if(radioButton2.Checked == true){
                Modo = 2;
            }

            if (Modo == 1)
            {
                //Invoca nuevo juego
                Juego nuevoJuego = new Juego(Modo);
                nuevoJuego.Show();
                this.Hide();
            }
            else{
                MessageBox.Show("¡Ups! ¡Lo sentimos!. Estamos en construcción de esta opción. ¡Elige la opción usuario-usuario y diviertete!", "Gato");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es el juego del Gato (o Tic Tac Toe): O y X, que marcan los espacios de un tablero de 3×3 alternadamente. Un jugador gana si consigue tener una línea de tres de sus símbolos: la línea puede ser horizontal, vertical o diagonal. ¡A jugar!", "Gato");
        }
    }
}
