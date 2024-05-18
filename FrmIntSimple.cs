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
    public partial class FrmIntSimple : Form
    {
        public FrmIntSimple()
        {
            InitializeComponent();
        }

        private void txtValorPresenteF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteresF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoF_KeyPress(object sender, KeyPressEventArgs e)
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
            txtValorPresenteF.Text = "";
            txtTasaInteresF.Text = "";
            txtPeriodoF.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double p, i, n, f;
            double i1, n1, i2;

            try 
            {
                p = double.Parse(txtValorPresenteF.Text);
                i1 = double.Parse(txtTasaInteresF.Text);
                n1 = double.Parse(txtPeriodoF.Text);

                if (cmbInteresF.SelectedItem != null && cmbPeriodoF.SelectedItem != null)
                {
                    if (cmbInteresF.SelectedItem.Equals("Anual") || cmbPeriodoF.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1 / 12;
                        f = p * (1 + (i * n));

                        int N = dtgvResultadosF.Rows.Add();

                        dtgvResultadosF.Rows[N].Cells[0].Value = p;
                        dtgvResultadosF.Rows[N].Cells[1].Value = i;
                        dtgvResultadosF.Rows[N].Cells[2].Value = n;
                        dtgvResultadosF.Rows[N].Cells[3].Value = f;

                    }

                    if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Años"))
                    {
                        i2 = i1 / 100;
                        i = i2 / 12;
                        n = n1;
                        f = p * (1 + (i * n));

                        int N = dtgvResultadosF.Rows.Add();

                        dtgvResultadosF.Rows[N].Cells[0].Value = p;
                        dtgvResultadosF.Rows[N].Cells[1].Value = i;
                        dtgvResultadosF.Rows[N].Cells[2].Value = n;
                        dtgvResultadosF.Rows[N].Cells[3].Value = f;
                    }
                    if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1;
                        f = p * (1 + (i * n));

                        int N = dtgvResultadosF.Rows.Add();

                        dtgvResultadosF.Rows[N].Cells[0].Value = p;
                        dtgvResultadosF.Rows[N].Cells[1].Value = i;
                        dtgvResultadosF.Rows[N].Cells[2].Value = n;
                        dtgvResultadosF.Rows[N].Cells[3].Value = f;
                    }
                    if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1;
                        f = p * (1 + (i * n));

                        int N = dtgvResultadosF.Rows.Add();

                        dtgvResultadosF.Rows[N].Cells[0].Value = p;
                        dtgvResultadosF.Rows[N].Cells[1].Value = i;
                        dtgvResultadosF.Rows[N].Cells[2].Value = n;
                        dtgvResultadosF.Rows[N].Cells[3].Value = f;
                    }
                }
            }
            catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necasarios");
            }

        }
    }
}
