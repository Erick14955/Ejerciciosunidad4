using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio = new Ejercicio1();
            ejercicio.Show();
        }

        private void Ejercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio1 = new Ejercicio2();
            ejercicio1.Show();
        }

        private void Ejercicio3_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio2 = new Ejercicio3();
            ejercicio2.Show();
        }
    }
}
