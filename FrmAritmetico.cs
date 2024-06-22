using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIng_Economica
{
    public partial class FrmAritmetico : Form
    {
        public FrmAritmetico()
        {
            InitializeComponent();
        }

        private void txtAnualidadGA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInteresGA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoGA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtGradienteGA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarPresenteGA_Click(object sender, EventArgs e)
        {
            txtAnualidadGA.Text = "";
            txtInteresGA.Text = "";
            txtPeriodoGA.Text = "";
            txtGradienteGA.Text = "";
        }

        private void btnCalcularAnualidadGA_Click(object sender, EventArgs e)
        {
            double A1, G, i;
            int n;

            try
            {
                A1 = Convert.ToDouble(txtAnualidadGA.Text);
                i = Convert.ToDouble(txtInteresGA.Text);
                n = Convert.ToInt32(txtPeriodoGA.Text);
                G = Convert.ToDouble(txtGradienteGA.Text);

                
            }catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios" + x);
            }
        }
    }
}
