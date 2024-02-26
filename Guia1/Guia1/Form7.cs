using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1
{
    public partial class Form7 : Form
    {
        enum Posicion // Define un set de constantes que pueden ser asignados a una variable
        {
            Izquierda, Derecha, Arriba, Abajo
        }
        private int x; // Coordenada en x
        private int y; // Coordenada en y
        private Posicion objposicion; // Variable del enum Posicion
        private List<Point> serpiente; // Lista para almacenar los segmentos de la serpiente
        private Point comida; // Posición de la comida
        private const int TamanioCelda = 20; // Tamaño de cada celda

        public Form7()
        {
            InitializeComponent();
            x = 50; // Iniciamos x en 50
            y = 50; // Iniciamos y en 50
            objposicion = Posicion.Abajo; // Por defecto definimos que se mueve hacia abajo

            serpiente = new List<Point>(); // Inicializar la lista de la serpiente
            serpiente.Add(new Point(5, 5)); // Posición inicial de la serpiente

            comida = GenerarComida(); // Generar posición inicial de la comida

            // Configuración de la ventana de juego
            DoubleBuffered = true;
            KeyPreview = true;
            //ClientSize = new Size(400, 400);
            //Text = "Juego de la Serpiente";
            //BackColor = Color.Black;

            // Iniciar el temporizador
            System.Windows.Forms.Timer timermov = new System.Windows.Forms.Timer();
            timermov.Interval = 100;
            timermov.Tick += timermov_Tick;
            timermov.Start();
        }

        private void timermov_Tick(object sender, EventArgs e)
        {
            Point cabeza = serpiente[0];
            Point nuevaCabeza = cabeza;

            switch (objposicion)
            {
                case Posicion.Derecha:
                    nuevaCabeza.X += 1;
                    break;
                case Posicion.Izquierda:
                    nuevaCabeza.X -= 1;
                    break;
                case Posicion.Arriba:
                    nuevaCabeza.Y -= 1;
                    break;
                case Posicion.Abajo:
                    nuevaCabeza.Y += 1;
                    break;
            }

            if (nuevaCabeza == comida)
            {
                serpiente.Insert(0, nuevaCabeza); // Agregamos la nueva cabeza en la posición actual
                comida = GenerarComida();
            }
            else
            {
                serpiente.Insert(0, nuevaCabeza);
                if (serpiente.Count > 1)
                    serpiente.RemoveAt(serpiente.Count - 1); // Quitamos la última cola si no se ha comido
            }

            if (nuevaCabeza.X < 0 || nuevaCabeza.X >= ClientSize.Width / TamanioCelda ||
                nuevaCabeza.Y < 0 || nuevaCabeza.Y >= ClientSize.Height / TamanioCelda)
            {
                
                ReiniciarJuego();
                return;
            }

            if (serpiente.Skip(1).Any(seg => seg == nuevaCabeza))
            {
               
                ReiniciarJuego();
                return;
            }

            Invalidate();
        }
        private Point GenerarComida()
        {
            // Generar una posición aleatoria para la comida
            Random rand = new Random();
            int x = rand.Next(ClientSize.Width / TamanioCelda);
            int y = rand.Next(ClientSize.Height / TamanioCelda);
            return new Point(x, y);
        }

        private void ReiniciarJuego()
        {
            // Reiniciar el juego
            serpiente.Clear();
            serpiente.Add(new Point(5, 5));
            objposicion = Posicion.Abajo;
            comida = GenerarComida();
            Invalidate();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Form7_KeyDown_1(object sender, KeyEventArgs e)
        {
            // Cambiar la dirección de la serpiente según la tecla presionada
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (objposicion != Posicion.Derecha)
                        objposicion = Posicion.Izquierda;
                    break;
                case Keys.Right:
                    if (objposicion != Posicion.Izquierda)
                        objposicion = Posicion.Derecha;
                    break;
                case Keys.Up:
                    if (objposicion != Posicion.Abajo)
                        objposicion = Posicion.Arriba;
                    break;
                case Keys.Down:
                    if (objposicion != Posicion.Arriba)
                        objposicion = Posicion.Abajo;
                    break;
            }
        }

        private void Form7_Paint_1(object sender, PaintEventArgs e)
        {
            // Dibujar fondo cuadriculado
            for (int i = 0; i < ClientSize.Width / TamanioCelda; i++)
            {
                for (int j = 0; j < ClientSize.Height / TamanioCelda; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        e.Graphics.FillRectangle(Brushes.LightGray, i * TamanioCelda, j * TamanioCelda, TamanioCelda, TamanioCelda);
                    }
                }
            }

            //e.Graphics.DrawImage(new Bitmap("error by 404.png"), x, y, 65, 65);

            foreach (Point segmento in serpiente)
            {
                e.Graphics.FillRectangle(Brushes.Green, segmento.X * TamanioCelda, segmento.Y * TamanioCelda, TamanioCelda, TamanioCelda);
            }

            e.Graphics.FillEllipse(Brushes.Red, comida.X * TamanioCelda, comida.Y * TamanioCelda, TamanioCelda, TamanioCelda);
        }
    }
}
