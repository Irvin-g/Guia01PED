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
    public partial class Form5 : Form
    {
       
      
        private Random random;
        int x, y; //Permite determinar la ubicacion del click
        public Form5()
        {
            InitializeComponent();
            random = new Random();
            
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Utilizamos el objeto Graphics proporcionado por el evento

            Pen lapiz = new Pen(Color.Black); // Declaramos color del PEN a utilizar

            if (listBox1.SelectedIndex == 0) // Si selecciona círculo
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256))); // Brush con color aleatorio
                int diametro = random.Next(50, 150); // Tamaño aleatorio en el rango de 50 a 150
                g.DrawEllipse(lapiz, x - diametro / 2, y - diametro / 2, diametro, diametro); // Dibujar círculo con posición y dimensiones aleatorias
                g.FillEllipse(sb, x - diametro / 2, y - diametro / 2, diametro, diametro); // Rellenar de color el círculo dado
            }
            else if (listBox1.SelectedIndex == 1) // Si selecciona rectángulo
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256))); // Brush con color aleatorio
                int ancho = random.Next(50, 150); // Ancho aleatorio en el rango de 50 a 150
                int alto = random.Next(50, 150); // Alto aleatorio en el rango de 50 a 150
                g.DrawRectangle(lapiz, x - ancho / 2, y - alto / 2, ancho, alto); // Dibujar rectángulo con posición y dimensiones aleatorias
                g.FillRectangle(sb, x - ancho / 2, y - alto / 2, ancho, alto); // Rellenar de color el rectángulo dado
            }
        }

        private void panel1_MouseClick_1(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Invalidate(); // Al cambiar la selección, se invalida el panel para volver a pintar las figuras
        }

    }
}
