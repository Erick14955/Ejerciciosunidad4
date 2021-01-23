using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unidad4
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
             int numero = int.Parse(CuadroNumero.Text);

            for (int i = 1; i <= 10; i++)
            {
                int resultado = i * numero;
                string R = i + "x" + numero + "=" + resultado + " \t\t";
                resultados.AppendText(R);
            }
        }
    }
}
