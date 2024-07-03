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
    public partial class FrmTIR : Form
    {
        public FrmTIR()
        {
            InitializeComponent();
        }

      

        private void txtVpn1TIR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtVpn2TIR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInt1Tir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInt2TIR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarTIR_Click(object sender, EventArgs e)
        {
            
            txtVpn1TIR.Text = " ";
            txtVpn2TIR.Text = " ";
            txtInt1Tir.Text = " ";
            txtInt2TIR.Text = " ";
            dgvDatosTIR.DataSource = null;
            dgvDatosTIR.Rows.Clear();
        }

        private List<object> ResultadosTIR = new List<object>();
        private void btnCalCularTIR_Click(object sender, EventArgs e)
        {
            double VPN1, VPN2, INT1, INT2,TIR;
            try
            {
                VPN1 = Convert.ToDouble(txtVpn1TIR.Text);
                INT1 = Convert.ToDouble(txtInt1Tir.Text);
                VPN2 = Convert.ToDouble(txtVpn2TIR.Text);
                INT2 = Convert.ToDouble(txtInt2TIR.Text);
                TIR = Convert.ToDouble(txtInt2TIR.Text);
                

                TIR = INT1 - (VPN1 * (INT2 - INT1)/(VPN2 -VPN1));
                ResultadosTIR.Add(new
                {
                  
                    ValorPresente = VPN1,
                    ValorPresenteNeto2 = VPN2,
                    Interes1 = INT1,
                    Interes2 = INT2,
                    TIR = TIR,


            });

                dgvDatosTIR.DataSource = null;
                dgvDatosTIR.DataSource = ResultadosTIR.ToList();
            }
            catch(FormatException ex)
            {

                MessageBox.Show("Rellene los campos necesarios " + ex);
            }
        }
    }
}
