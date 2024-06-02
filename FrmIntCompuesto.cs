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
    public partial class FrmIntCompuesto : Form
    {
        public List<InteresCompuestoI> IntCompI = new List<InteresCompuestoI>();
        public List<InteresCompuestoP> IntCompP = new List<InteresCompuestoP>();
        public FrmIntCompuesto()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

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
                    // Cuando tenemos interes anual con los diferentes periodos
                    if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        f = p * Math.Pow((1 + i), n1);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n1;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                    {
                        i = i1 / 100;
                        n = n1 / 2;
                        f = p * Math.Pow((1 + i), n);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                    {
                        i = i1 / 100;
                        n = n1 / 4;
                        f = p * Math.Pow((1 + i), n);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1 / 12;
                        f = p * Math.Pow((1 + i), n);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    // Cuando tenemos interes semestral con los diferentes periodos
                    if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1 * 2;
                        f = p * Math.Pow((1 + i), n);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                    {
                        i = i1 / 100;
                        f = p * Math.Pow((1 + i), n1);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n1;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                    {
                        i = i1 / 100;
                        n = n1 / 2;
                        f = p * Math.Pow((1 + i), n);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1 / 6;
                        f = p * Math.Pow((1 + i), n);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    // Cuando tenemos interes trimestral con los diferentes periodos
                    if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1 * 4;
                        f = p * Math.Pow((1 + i), n);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                    {
                        i = i1 / 100;
                        n = n1 * 2;
                        f = p * Math.Pow((1 + i), n);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                    {
                        i = i1 / 100;
                        f = p * Math.Pow((1 + i), n1);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n1;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1 / 3;
                        f = p * Math.Pow((1 + i), n);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    // Cuando tenemos interes mensual con los diferentes periodos
                    if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1 * 12;
                        f = p * Math.Pow((1 + i), n);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                    {
                        i = i1 / 100;
                        n = n1 * 6;
                        f = p * Math.Pow((1 + i), n);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                    {
                        i = i1 / 100;
                        n = n1 * 3;
                        f = p * Math.Pow((1 + i), n);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        f = p * Math.Pow((1 + i), n1);

                        int N = dgvResultadosFU.Rows.Add();
                        dgvResultadosFU.Rows[N].Cells[0].Value = p;
                        dgvResultadosFU.Rows[N].Cells[1].Value = i;
                        dgvResultadosFU.Rows[N].Cells[2].Value = n1;
                        dgvResultadosFU.Rows[N].Cells[3].Value = f;
                    }

                }
            }
            catch (FormatException x)
            {

                MessageBox.Show("Rellene los campos necasarios");
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

        private void txtTasaInteresF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void btnLimpiarF_Click(object sender, EventArgs e)
        {
            txtValorPresenteF.Text = "";
            txtTasaInteresF.Text = "";
            txtPeriodoF.Text = "";
        }

        private void btnCalcularI_Click(object sender, EventArgs e)
        {

        }

        //private void txtValorFuturoI_TextChanged(object sender, EventArgs e)
        //{
            
            
        //}

        private void txtValorFuturoI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar>= 32 && e.KeyChar<=45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorPresenteI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
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

        private void btnLimpiarI_Click(object sender, EventArgs e)
        {
            txtValorFuturoI.Text = "";
            txtValorPresenteI.Text = "";
            txtPeriodoI.Text = "";


        }

        private void txtValorFuturoN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorPresenteN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
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

        private void btnLimpiarN_Click(object sender, EventArgs e)
        {
            txtValorFuturoN.Text = "";
            txtValorPresenteN.Text = "";
            txtTasaInteresN.Text = "";
        }
    }
}
