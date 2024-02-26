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
    using System;
    using System.Windows.Forms;
    public partial class Form2 : Form
    {
        Graphics area; // area de dibujo
        private Form3 formulario3;
        private Form6 formulario6;
        private Form7 formulario7;

        public Form2()
        {

            InitializeComponent();
            formulario3 = new Form3();
            formulario6 = new Form6();
            formulario7 = new Form7();
            area = areadibujo.CreateGraphics(); //Establezco area de dibujo
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btndibujar_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black); // color por defecto

                switch(cmbcolor.SelectedIndex) // colorear dependiendo de lo seleccionado
                {

                    case 0: lapicero = new Pen(Color.Yellow); break;
                    case 1: lapicero = new Pen(Color.Red); break;
                    case 2: lapicero = new Pen(Color.Blue); break;
                    case 3: lapicero = new Pen(Color.Black); break;
                }
            int interacciones = int.Parse(txtcantidad.Text); // cantidad de lineas a dibujar
            int espaciado = int.Parse(txtespaciado.Text); // espaciado asignado

            area.Clear(Color.White); // limpia area a blanco

            int puntoinicio = 50; // inicio en un valor de y = 50

            for (int i = 0; i < interacciones; i++)
            {
                area.DrawLine(lapicero, 20, puntoinicio + (espaciado * i), 300, puntoinicio + (espaciado * i));
                //dibuja linea por linea de acuerdo al color dado, en x van de  20 a 300 y en y varia segun interaccion
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulario3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulario6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulario7.Show();
        }
    }
}
