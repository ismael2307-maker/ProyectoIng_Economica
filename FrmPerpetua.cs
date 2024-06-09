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
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarPerpetuo_Click(object sender, EventArgs e)
        {
            txtValorPresente.Text = "";
            txtTasaInteres.Text = "";
        }
        private List<object> ResultadosPerpetuo = new List<object>();
        private void btnCalcularPerpetuo_Click(object sender, EventArgs e)
        {
            try
            {
                double A;
                double p = Convert.ToDouble(txtValorPresente.Text);
                double i = Convert.ToDouble(txtTasaInteres.Text) / 100;
                A = p * i;
                ResultadosPerpetuo.Add(new { P = p, Interes = i,A = A});
                dgvResultadoresPerpetuos.DataSource = null;
                dgvResultadoresPerpetuos.DataSource = ResultadosPerpetuo.ToList();
            }catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios");
            }
        }
    }
}
