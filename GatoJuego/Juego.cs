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
    public partial class Juego : Form
    {
        //Dice el modo en el que se está jugando
        int Modo = 0;

        //Dice quien juega. 0 = Jugador1 y 1 = Jugador2
        int estado = 0;

        //Dice estado del juego. true si se sigue en juego, false si ha finalizado
        bool juego = true;

        //Dice las casillas del gato (general, jugador1 y jugador2)
        int[] casilla = new int[9];
        int[] jugador1 = new int[9];
        int[] jugador2 = new int[9];

        public Juego(int modo)
        {
            InitializeComponent();
            Modo = modo;
        }

        private void Juego_Click(object sender, EventArgs e)
        {
            
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            //Verifica el modo que se va a jugar
            if (Modo == 1){
                textBox3.Text = "Jugador 1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool ganador1 = false;
            bool ganador2 = false;            

            //Casos de las casillas
            if ((textBox1.Text.Equals("1")) && (casilla[1] == 0)){
                //Pone la casilla en no disponible
                casilla[1] = 1;
                //Verifica cual jugador está jugando
                if (estado == 0){
                    jugador1[1] = 1;
                    panel1.BackgroundImage = Properties.Resources.prueba1;
                    ganador1 = verificarGanador(jugador1);
                    estado = 1;
                }
                else if (estado == 1){
                    jugador2[1] = 1;
                    panel1.BackgroundImage = Properties.Resources.prueba2;
                    ganador2 = verificarGanador(jugador2);
                    estado = 0;
                }
            }
            else if ((textBox1.Text.Equals("2")) && (casilla[2] == 0)){
                //Pone la casilla en no disponible
                casilla[2] = 1;
                //Verifica cual jugador está jugando
                if (estado == 0){
                    jugador1[2] = 1;
                    panel2.BackgroundImage = Properties.Resources.prueba1;
                    ganador1 = verificarGanador(jugador1);
                    estado = 1;
                }
                else if (estado == 1){
                    jugador2[2] = 1;
                    panel2.BackgroundImage = Properties.Resources.prueba2;
                    ganador2 = verificarGanador(jugador2);
                    estado = 0;
                }
            }
            else if (textBox1.Text.Equals("3") && (casilla[3] == 0)){
                //Pone la casilla en no disponible
                casilla[3] = 1;
                //Verifica cual jugador está jugando
                if (estado == 0){
                    jugador1[3] = 1;
                    panel3.BackgroundImage = Properties.Resources.prueba1;
                    ganador1 = verificarGanador(jugador1);
                    estado = 1;
                }
                else if (estado == 1){
                    jugador2[3] = 1;
                    panel3.BackgroundImage = Properties.Resources.prueba2;
                    ganador2 = verificarGanador(jugador2);
                    estado = 0;
                }
            }
            else if ((textBox1.Text.Equals("4")) && (casilla[4] == 0)){
                //Pone la casilla en no disponible
                casilla[4] = 1;
                //Verifica cual jugador está jugando
                if (estado == 0){
                    jugador1[4] = 1;
                    panel4.BackgroundImage = Properties.Resources.prueba1;
                    ganador1 = verificarGanador(jugador1);
                    estado = 1;
                }
                else if (estado == 1){
                    jugador2[4] = 1;
                    panel4.BackgroundImage = Properties.Resources.prueba2;
                    ganador2 = verificarGanador(jugador2);
                    estado = 0;
                }
            }
            else if ((textBox1.Text.Equals("5")) && (casilla[5] == 0)){
                //Pone la casilla en no disponible
                casilla[5] = 1;
                //Verifica cual jugador está jugando
                if (estado == 0){
                    jugador1[5] = 1;
                    panel5.BackgroundImage = Properties.Resources.prueba1;
                    ganador1 = verificarGanador(jugador1);
                    estado = 1;
                }
                else if (estado == 1){
                    jugador2[5] = 1;
                    panel5.BackgroundImage = Properties.Resources.prueba2;
                    ganador2 = verificarGanador(jugador2);
                    estado = 0;
                }
            }
            else if ((textBox1.Text.Equals("6")) && (casilla[6] == 0)){
                //Pone la casilla en no disponible
                casilla[6] = 1;
                //Verifica cual jugador está jugando
                if (estado == 0){
                    jugador1[6] = 1;
                    panel6.BackgroundImage = Properties.Resources.prueba1;
                    ganador1 = verificarGanador(jugador1);
                    estado = 1;
                }
                else if (estado == 1){
                    jugador2[6] = 1;
                    panel6.BackgroundImage = Properties.Resources.prueba2;
                    ganador2 = verificarGanador(jugador2);
                    estado = 0;
                }
            }
            else if ((textBox1.Text.Equals("7")) && (casilla[7] == 0)){
                //Pone la casilla en no disponible
                casilla[7] = 1;
                //Verifica cual jugador está jugando
                if (estado == 0){
                    jugador1[7] = 1;
                    panel7.BackgroundImage = Properties.Resources.prueba1;
                    ganador1 = verificarGanador(jugador1);
                    estado = 1;
                }
                else if (estado == 1){
                    jugador2[7] = 1;
                    panel7.BackgroundImage = Properties.Resources.prueba2;
                    ganador2 = verificarGanador(jugador2);
                    estado = 0;
                }
            }
            else if ((textBox1.Text.Equals("8")) && (casilla[8] == 0)){
                //Pone la casilla en no disponible
                casilla[8] = 1;
                //Verifica cual jugador está jugando
                if (estado == 0){
                    jugador1[8] = 1;
                    panel8.BackgroundImage = Properties.Resources.prueba1;
                    ganador1 = verificarGanador(jugador1);
                    estado = 1;
                }
                else if (estado == 1){
                    jugador2[8] = 1;
                    panel8.BackgroundImage = Properties.Resources.prueba2;
                    ganador2 = verificarGanador(jugador2);
                    estado = 0;
                }
            }
            else if ((textBox1.Text.Equals("9")) && (casilla[9] == 0)){
                //Pone la casilla en no disponible
                casilla[9] = 1;
                //Verifica cual jugador está jugando
                if (estado == 0){
                    jugador1[9] = 1;
                    panel9.BackgroundImage = Properties.Resources.prueba1;
                    ganador1 = verificarGanador(jugador1);
                    estado = 1;
                }
                else if (estado == 1){
                    jugador2[9] = 1;
                    panel9.BackgroundImage = Properties.Resources.prueba2;
                    ganador2 = verificarGanador(jugador2);
                    estado = 0;
                }
            }
            else{
                MessageBox.Show("¡Lo sentimos! La casilla que especificaste no está disponible", "Gato");
            }

            textBox1.Clear();

            //Muestra cual jugador está en juego
            ponerJugador();

            if ((ganador1 == true) && (juego == false)){
                MessageBox.Show("¡En hora buena jugador 1! Has ganado la partida", "Gato");
            }
            else if ((ganador2 == true) && (juego == false)){
                MessageBox.Show("¡En hora buena jugador 2! Has ganado la partida", "Gato");
            }           
        }

        //Muestra cual jugador está en juego
        private void ponerJugador()
        {
            if (estado == 0){
                textBox3.Text = "Jugador 1";
            }
            else if (estado == 1){
                textBox3.Text = "Jugador 2";
            }
        }

        //Verifica si hay un jugador ganador
        private bool verificarGanador(int[] jugador)
        {
            //Horizontal arriba
            if ((jugador[1] == 1) && (jugador[2] == 1) && (jugador[3] == 1)){
                juego = false;
                return true;
                
            }
            //Horizontal medio
            else if ((jugador[4] == 1) && (jugador[5] == 1) && (jugador[6] == 1)){
                juego = false;
                return true;
                
            }
            //Horizontal abajo
            else if ((jugador[7] == 1) && (jugador[8] == 1) && (jugador[9] == 1)){
                juego = false;
                return true;                
            }
            //Vertical izquierda
            else if ((jugador[1] == 1) && (jugador[4] == 1) && (jugador[7] == 1)){
                juego = false;
                return true;               
            }
            //Vertical medio
            else if ((jugador[2] == 1) && (jugador[5] == 1) && (jugador[8] == 1)){
                juego = false;
                return true;               
            }
            //Vertical derecha
            else if ((jugador[3] == 1) && (jugador[6] == 1) && (jugador[9] == 1)){                
                juego = false;
                return true;
            }
            //Diagonal izquierda
            else if ((jugador[1] == 1) && (jugador[5] == 1) && (jugador[9] == 1)){
                juego = false;
                return true;                
            }
            //Diagonal derecha
            else if ((jugador[3] == 1) && (jugador[5] == 1) && (jugador[7] == 1)){
                juego = false;
                return true;                
            }
            else{
                return false;
            }
        }
    }
}
