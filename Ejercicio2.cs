using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unidad4
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(CuadroNumero.Text);
            int elevacion = int.Parse(CuadroElevacion.Text);
            int resultado = numero * numero;

            for(int i = 1; i < elevacion-1; i++)
            {
                resultado = resultado * numero;
            }

            Result.Text = resultado.ToString();
        }
    }
}
