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
    public partial class Form6 : Form
    {
        Graphics area; // área de dibujo

        public Form6()
        {
            InitializeComponent();
            area = areadibujo.CreateGraphics(); // Establezco área de dibujo
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btndibujar_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black); // color por defecto

            switch (cmbcolor.SelectedIndex) // colorear dependiendo de lo seleccionado
            {
                case 0: lapicero = new Pen(Color.Yellow); break;
                case 1: lapicero = new Pen(Color.Red); break;
                case 2: lapicero = new Pen(Color.Blue); break;
                case 3: lapicero = new Pen(Color.Black); break;
            }

            int interacciones = int.Parse(txtcantidad.Text); // cantidad de líneas a dibujar
            int espaciado = int.Parse(txtespaciado.Text); // espaciado asignado

            int puntoInicioX = int.Parse(txtpuntoinicioX.Text); // punto de inicio en el eje X
            int puntoInicioY = int.Parse(txtpuntoinicioY.Text); // punto de inicio en el eje Y
            int puntoFinX = int.Parse(txtpuntofinX.Text); // punto de fin en el eje X
            int puntoFinY = int.Parse(txtpuntofinY.Text); // punto de fin en el eje Y

            area.Clear(Color.White); // limpia área a blanco

            for (int i = 0; i < interacciones; i++)
            {
                area.DrawLine(lapicero, puntoInicioX + (espaciado * i), puntoInicioY, puntoFinX + (espaciado * i), puntoFinY);
                // dibuja línea por línea de acuerdo al color dado, en x varía según la interacción y en y va de puntoInicioY a puntoFinY
            }
        }

    }
}
