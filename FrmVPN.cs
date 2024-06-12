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
    public partial class FrmVPN : Form
    {
        public FrmVPN()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double inversioInicial = double.Parse(txtInversionInicial.Text);
                double tasaDescuento = double.Parse(txtTasaDescuento.Text) / 100;

                double vpn = -inversioInicial;

                List<object> resultados = new List<object>();

                resultados.Add(new { Año = 0, FNE = -inversioInicial, VPN = -inversioInicial });

                foreach (DataGridViewRow row in dgvFlujosNetos.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        int año = int.Parse(row.Cells[0].Value.ToString());
                        double flujoNetoEfectivo = double.Parse(row.Cells[1].Value.ToString());

                        double valorPresenteNeto = flujoNetoEfectivo / Math.Pow(1 + tasaDescuento, año);
                        vpn += valorPresenteNeto;

                        resultados.Add(new { Año = año, FNE = flujoNetoEfectivo, VPN = valorPresenteNeto });
                    }
                }

                resultados.Add(new { Año = "Total", FNE = (double?)null, VPN = vpn });

                foreach (var resultado in resultados)
                {
                    dgvResultados.Rows.Add(resultado.GetType().GetProperty("Año").GetValue(resultado),
                                           resultado.GetType().GetProperty("FNE").GetValue(resultado),
                                           resultado.GetType().GetProperty("VPN").GetValue(resultado));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInversionInicial.Clear();
            txtTasaDescuento.Clear();
        }
    }
}
