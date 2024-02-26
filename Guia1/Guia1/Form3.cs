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
    public partial class Form3 : Form
    {
        enum Posicion //define un set de constantes que pueden ser asignados a una variable
        {
            izquierda, derecha, arriba, abajo
        }
        private int x; //coordenada en x
        private int y; //coordenada en y
        private Posicion objposicion; //variable del enum Posicion

        public Form3()
        {
            InitializeComponent();
            x = 50; //iniciamos x en 50
            y = 50; //iniciamos y en 50
            objposicion = Posicion.abajo; //Por defecto definimos que se mueve hacia abajo
        }

        private void timermov_Tick(object sender, EventArgs e)
        {
            if (objposicion == Posicion.derecha)
            { x += 10; } //Desplazarse 10 pixeles a la derecha
            else if (objposicion == Posicion.izquierda)
            { x -= 10; } //Desplazarse 10 pixeles a la izquierda
            else if (objposicion == Posicion.arriba)
            { y -= 10; } //10 pixeles hacia arriba
            else if (objposicion == Posicion.abajo)
            { y += 10; } //10 pixeles hacia abajo

            Invalidate(); //Invaliuda la superficie del control y hace que se vuelva a dibujar el control
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("fondo.png"), x, y, 65, 65);
            //Se Dibuja la imagen agrefa al proyecto y se establece el punto inicial y el tamaño
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //Si se presiona la tecla de flecha izquierda
            {
                objposicion = Posicion.izquierda;
            }
            else if (e.KeyCode == Keys.Right) //Si se presiona la tecla flecha derecha
            {
                objposicion = Posicion.derecha;
            }
            else if (e.KeyCode == Keys.Up) //Si se presiona la flecha ariba
            {
                objposicion = Posicion.arriba;
            }
            else if (e.KeyCode == Keys.Down)  //Si se presionala flecha abajo
            {
                objposicion = Posicion.abajo;
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
