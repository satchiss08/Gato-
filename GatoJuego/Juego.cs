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

        //Nueva jugada
        private void button3_Click(object sender, EventArgs e)
        {
            bool ganador1 = false;
            bool ganador2 = false;

            int match = 0;

            //Casos de las casillas
            for (int contador = 0; contador <= 8; contador++)
            {
                if ((textBox1.Text.Equals((contador+1).ToString())) && (casilla[contador] == 0))
                {
                    match = 1;
                    //Pone la casilla en no disponible
                    casilla[contador] = 1;
                    //Verifica cual jugador está jugando. Jugador 1
                    if (estado == 0)
                    {
                        jugador1[contador] = 1;
                        //case para cada imagen en el panel
                        switch (contador){
                            case 0:
                                panel1.BackgroundImage = Properties.Resources.prueba1;
                                break;
                            case 1:
                                panel2.BackgroundImage = Properties.Resources.prueba1;
                                break;
                            case 2:
                                panel3.BackgroundImage = Properties.Resources.prueba1;
                                break;
                            case 3:
                                panel4.BackgroundImage = Properties.Resources.prueba1;
                                break;
                            case 4:
                                panel5.BackgroundImage = Properties.Resources.prueba1;
                                break;
                            case 5:
                                panel6.BackgroundImage = Properties.Resources.prueba1;
                                break;
                            case 6:
                                panel7.BackgroundImage = Properties.Resources.prueba1;
                                break;
                            case 7:
                                panel8.BackgroundImage = Properties.Resources.prueba1;
                                break;
                            case 8:
                                panel9.BackgroundImage = Properties.Resources.prueba1;
                                break;
                        }                       
                        ganador1 = verificarGanador(jugador1);
                        estado = 1;
                    }
                    //Verifica cual jugador está jugando. Jugador 2
                    else if (estado == 1)
                    {
                        jugador2[contador] = 1;
                        //case para cada imagen en el panel
                        switch (contador){
                            case 0:
                                panel1.BackgroundImage = Properties.Resources.prueba2;
                                break;
                            case 1:
                                panel2.BackgroundImage = Properties.Resources.prueba2;
                                break;
                            case 2:
                                panel3.BackgroundImage = Properties.Resources.prueba2;
                                break;
                            case 3:
                                panel4.BackgroundImage = Properties.Resources.prueba2;
                                break;
                            case 4:
                                panel5.BackgroundImage = Properties.Resources.prueba2;
                                break;
                            case 5:
                                panel6.BackgroundImage = Properties.Resources.prueba2;
                                break;
                            case 6:
                                panel7.BackgroundImage = Properties.Resources.prueba2;
                                break;
                            case 7:
                                panel8.BackgroundImage = Properties.Resources.prueba2;
                                break;
                            case 8:
                                panel9.BackgroundImage = Properties.Resources.prueba2;
                                break;
                        }
                        ganador2 = verificarGanador(jugador2);
                        estado = 0;
                    }
                }
            }
            //En caso de que se ponga una casilla ocupada o inexistente
            if(match == 0){
                    MessageBox.Show("¡Lo sentimos! La casilla que especificaste no está disponible", "Gato");
            }

            //Limpia el textbox con la casilla
            textBox1.Clear();

            //Muestra cual jugador está en juego
            ponerJugador();

            //Muestra quien es el ganador
            mostrarGanador(ganador1, ganador2);        
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

        //Muestra quien es el ganador
        private void mostrarGanador(bool jugador1, bool jugador2)
        {
            if ((jugador1 == true) && (juego == false)){
                MessageBox.Show("¡En hora buena jugador 1! Has ganado la partida", "Gato");
            }
            else if ((jugador2 == true) && (juego == false)){
                MessageBox.Show("¡En hora buena jugador 2! Has ganado la partida", "Gato");
            }  
        }
        
        //Verifica si hay un jugador ganador
        private bool verificarGanador(int[] jugador)
        {
            //Horizontal arriba
            if ((jugador[0] == 1) && (jugador[1] == 1) && (jugador[2] == 1)){
                juego = false;
                return true;                
            }
            //Horizontal medio
            else if ((jugador[3] == 1) && (jugador[4] == 1) && (jugador[5] == 1)){
                juego = false;
                return true;                
            }
            //Horizontal abajo
            else if ((jugador[6] == 1) && (jugador[7] == 1) && (jugador[8] == 1)){
                juego = false;
                return true;               
            }
            //Vertical izquierda
            else if ((jugador[0] == 1) && (jugador[3] == 1) && (jugador[6] == 1)){
                juego = false;
                return true;               
            }
            //Vertical medio
            else if ((jugador[1] == 1) && (jugador[4] == 1) && (jugador[7] == 1)){
                juego = false;
                return true;               
            }
            //Vertical derecha
            else if ((jugador[2] == 1) && (jugador[5] == 1) && (jugador[8] == 1)){                
                juego = false;
                return true;
            }
            //Diagonal izquierda
            else if ((jugador[0] == 1) && (jugador[4] == 1) && (jugador[8] == 1)){
                juego = false;
                return true;                
            }
            //Diagonal derecha
            else if ((jugador[2] == 1) && (jugador[4] == 1) && (jugador[6] == 1)){
                juego = false;
                return true;                
            }
            else{
                return false;
            }
        }

        //Nuevo juego
        private void button1_Click(object sender, EventArgs e)
        {
            //Limpia variables, array, paneles, etc.
            juego = true;
            estado = 0;
            for (int n = 0; n <= 8; n++){
                casilla[n] = 0;
            }
            for (int n = 0; n <= 8; n++){
                jugador1[n] = 0;
            }
            for (int n = 0; n <= 8; n++){
                jugador2[n] = 0;
            }
            panel1.BackgroundImage = null;
            panel2.BackgroundImage = null;
            panel3.BackgroundImage = null;
            panel4.BackgroundImage = null;
            panel5.BackgroundImage = null;
            panel6.BackgroundImage = null;
            panel7.BackgroundImage = null;
            panel8.BackgroundImage = null;
            panel9.BackgroundImage = null;

            textBox1.Clear();
            textBox3.Clear();
        }

        //Salir del juego
        private void button2_Click(object sender, EventArgs e)
        {
            Inicio nuevoInicio = new Inicio();
            this.Close();
            nuevoInicio.Show();
        }
    }
}
