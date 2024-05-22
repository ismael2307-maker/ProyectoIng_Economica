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

                        int N = dgvResultadosF.Rows.Add();

                        dgvResultadosF.Rows[N].Cells[0].Value = p;
                        dgvResultadosF.Rows[N].Cells[1].Value = i;
                        dgvResultadosF.Rows[N].Cells[2].Value = n;
                        dgvResultadosF.Rows[N].Cells[3].Value = f;

                    }

                    if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Años"))
                    {
                        i2 = i1 / 100;
                        i = i2 / 12;
                        n = n1;
                        f = p * (1 + (i * n));

                        int N = dgvResultadosF.Rows.Add();

                        dgvResultadosF.Rows[N].Cells[0].Value = p;
                        dgvResultadosF.Rows[N].Cells[1].Value = i;
                        dgvResultadosF.Rows[N].Cells[2].Value = n;
                        dgvResultadosF.Rows[N].Cells[3].Value = f;
                    }
                    if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1;
                        f = p * (1 + (i * n));

                        int N = dgvResultadosF.Rows.Add();

                        dgvResultadosF.Rows[N].Cells[0].Value = p;
                        dgvResultadosF.Rows[N].Cells[1].Value = i;
                        dgvResultadosF.Rows[N].Cells[2].Value = n;
                        dgvResultadosF.Rows[N].Cells[3].Value = f;
                    }
                    if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1;
                        f = p * (1 + (i * n));

                        int N = dgvResultadosF.Rows.Add();

                        dgvResultadosF.Rows[N].Cells[0].Value = p;
                        dgvResultadosF.Rows[N].Cells[1].Value = i;
                        dgvResultadosF.Rows[N].Cells[2].Value = n;
                        dgvResultadosF.Rows[N].Cells[3].Value = f;
                    }
                }
            }
            catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necasarios");
            }

        }

        private void txtValorFuturoP_TextChanged(object sender, EventArgs e)
        {
           //Ignorar
        }

        //CALCULAR VALOR PRESENTE
        private void btnCalcularP_Click(object sender, EventArgs e)
        {
            double p, f, i, n;
            double i1;

            try
            {
                f = double.Parse(txtValorFuturoP.Text);
                i1 = double.Parse(txtTasaInteresP.Text);
                n = double.Parse(txtPeriodoP.Text);

                i = i1 / 100;

                p = f / (1 + (i * n));

                int N = dgvResultadosF.Rows.Add();

                dgvResultadosP.Rows[N].Cells[0].Value = f;
                dgvResultadosP.Rows[N].Cells[1].Value = i;
                dgvResultadosP.Rows[N].Cells[2].Value = n;
                dgvResultadosP.Rows[N].Cells[3].Value = p;
            }
            catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios"+x);
            }
        }

        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            txtValorFuturoP.Text = "";
            txtTasaInteresP.Text = "";
            txtPeriodoP.Text = "";
        }

        //CALCULAR VALOR DEL INTERES
        private void btnCalcularI_Click(object sender, EventArgs e)
        {
            double i,f,p,n;
            double FP,n1;

            
            try 
            {
                f = double.Parse(txtValorFuturoI.Text);
                p = double.Parse(txtValorPresenteI.Text);
                n1 = double.Parse(txtPeriodoI.Text);

                n = n1 / 12;
                FP = f / p - 1;
                i = FP / n;

                int N = dgvResultadosF.Rows.Add();
                dgvResultadosI.Rows[N].Cells[0].Value = f;
                dgvResultadosI.Rows[N].Cells[1].Value = p;
                dgvResultadosI.Rows[N].Cells[2].Value = n;
                dgvResultadosI.Rows[N].Cells[3].Value = i;

            }
            catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios"+x);
            }
        }

        private void btnCalcularN_Click(object sender, EventArgs e)
        {
            double f,p,i;
            double i1,FP;
            double n;

            try
            {
                f = double.Parse(txtValorFuturoN.Text);
                p = double.Parse(txtValorPresenteN.Text);
                i1 = double.Parse(txtTasaInteresN.Text);

                i = i1 / 100;
                FP = f / p - 1;
                n = FP / i;
                
                

                int N = dgvResultadosF.Rows.Add();
                dgvResultadosN.Rows[N].Cells[0].Value = p;
                dgvResultadosN.Rows[N].Cells[1].Value = i;
                dgvResultadosN.Rows[N].Cells[2].Value = f;
                dgvResultadosN.Rows[N].Cells[3].Value = n;
            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios"+x);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {

        }

        private void txtValorFuturoN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorPresenteN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteresN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorFuturoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteresP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorFuturoI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorPresenteI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
