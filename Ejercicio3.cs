using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unidad4
{
    public partial class Ejercicio3 : Form
    {
        int edad = 0;
        int i = 1;
        int edadmayor, edadmenor;
        int persons;
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            persons = int.Parse(cantpersonas.Text);
            cantpersonas.Visible = false;
            textpers.Visible = false;
            Aceptar.Visible = false;
            labedad.Visible = true;
            textedad.Visible = true;
            Aceptar1.Visible = true;
        }

        private void Aceptar1_Click(object sender, EventArgs e)
        {
            int edades = int.Parse(textedad.Text);
            edad += edades;
            textedad.Clear();
            if(i == 1)
            {
                edadmayor = edades;
                edadmenor = edades;
            }
            else
            {
                if(edades > edadmayor)
                {
                    edadmayor = edades;
                }
                if(edades < edadmenor)
                {
                    edadmenor = edades;
                }
            }
            if(i == persons)
            {
                double totaledades = Convert.ToDouble(edad);
                double totalpersonas = Convert.ToDouble(persons);
                double promedad = Convert.ToDouble(totaledades / totalpersonas);
                labedad.Visible = false;
                textedad.Visible = false;
                Aceptar1.Visible = false;
                labProm.Visible = true;
                labmayor.Visible = true;
                labmenor.Visible = true;
                textprom.Visible = true;
                textmayor.Visible = true;
                textmenor.Visible = true;
                textprom.Text = promedad.ToString("N2");
                textmayor.Text = edadmayor.ToString();
                textmenor.Text = edadmenor.ToString();
            }
            i++;
        }
    } 
}
