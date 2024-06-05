using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoIng_Economica
{
    public partial class FrmInteresAcumulado : Form
    {
        public FrmInteresAcumulado()
        {
            InitializeComponent();
        }

        private void txtValorPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorPresente.Text = "";
            txtTasaInteres.Text = "";
            txtPeriodo.Text = "";
        }
        private List<object> ResultadosAcumulado = new List<object>();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double P, i = 0, I = 0, n = 0;
            double i1,n1;

            try 
            {
                P = double.Parse(txtValorPresente.Text);
                i1 = double.Parse(txtTasaInteres.Text);
                n1 = double.Parse(txtPeriodo.Text);

                n = n1 / 12;
                i = i1 / 100;
                I = P * i * n;

                ResultadosAcumulado.Add(new{Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                dtgvResultadosAcumulados.DataSource = null;
                dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;

            }
            catch (FormatException x) 
            {
                MessageBox.Show("Rellene los campos necesarios"+x);
            }
        }
    }
}
