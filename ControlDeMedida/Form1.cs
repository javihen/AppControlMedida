using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeMedida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Liamos el control listBox 
            lstResultado.Items.Clear();
            //Definicion de variable
            double mts, cmt, plg, pies, yarda;
            //capturar el valor de metros
            mts = double.Parse(txtMetros.Text);
            //realizar el procedimiento
            cmt = mts * 100;
            plg = cmt / 2.54;
            pies = plg / 12;
            yarda = pies / 3;
            //mostrar los resultados en listbox
            lstResultado.Items.Add("** RESUMENES DE CONVERSIONES **");
            lstResultado.Items.Add("MEDIDAS EN METROS: "+mts.ToString("0.00"));
            lstResultado.Items.Add(" ---------------------------------------------");
            lstResultado.Items.Add("MEDIDAS EN CENTIMETROS: " + cmt.ToString("0.00"));
            lstResultado.Items.Add("MEDIDAS EN PULGADAS: " + plg.ToString("0.00"));
            lstResultado.Items.Add("MEDIDAS EN PIES: " + pies.ToString("0.00"));
            lstResultado.Items.Add("MEDIDAS EN YARDAS: " + yarda.ToString("0.00"));

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            lstResultado.Items.Clear();
            txtMetros.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro de cerrar?", "medidas", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
