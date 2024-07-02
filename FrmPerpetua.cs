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
    public partial class FrmPerpetua : Form
    {
        public FrmPerpetua()
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

        private void btnLimpiarPerpetuo_Click(object sender, EventArgs e)
        {
            txtValorAnualidad.Text = "";
            txtTasaInteres.Text = "";
        }
        private List<object> ResultadosPerpetuo = new List<object>();
        private void btnCalcularPerpetuo_Click(object sender, EventArgs e)
        {
            try
            {
                double A;
                int N = Convert.ToInt32(txtPeriodo.Text);
                int N2 = N * 12;
                int n3 = N2 - 1;
                A = Convert.ToDouble(txtValorAnualidad.Text);
                double i = Convert.ToDouble(txtTasaInteres.Text) / 100;
                double P = Math.Round(A / i);
                double p2 = Math.Round(P * (Math.Pow(1+i,-n3)));
                string formattedA = A.ToString("N0");
                string formattedP1 = P.ToString("N0");
                string formattedP2 = p2.ToString("N0");
                ResultadosPerpetuo.Add(new { Presente = formattedP1, Interes = i,Anualidad = formattedA, Presente2 = formattedP2 });
                dgvResultadoresPerpetuos.DataSource = null;
                dgvResultadoresPerpetuos.DataSource = ResultadosPerpetuo.ToList();

            }catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios"+x);
            }
        }
    }
}
