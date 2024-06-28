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
    public partial class FrmGeometrico : Form
    {
        public FrmGeometrico()
        {
            InitializeComponent();
        }

        private void txtAnuualidadPGeom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIntPGeom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIntNomPGeom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoPGeom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private List<object> ResultadoGeométrico = new List<object>();
        private void btnLimpiarGeom_Click(object sender, EventArgs e)
        {
            int Valor_Anualidad, Periodo,p1,p2,p3;
            double tasaInteres, tasaNominal, resultados, Presente, i, i2,n,i3,n2,i4;

            try
            {
                Valor_Anualidad = Convert.ToInt32(txtAnuualidadPGeom.Text);
                Periodo = Convert.ToInt32(txtPeriodoPGeom.Text);
                p1 = Convert.ToInt32(txtPeriodoPGeom.Text);
                p2 = Convert.ToInt32(txtPeriodoPGeom.Text);
                p3 = Convert.ToInt32(txtPeriodoPGeom.Text);
                tasaInteres = Convert.ToDouble(txtIntPGeom.Text);
                tasaNominal = Convert.ToDouble(txtIntNomPGeom.Text);
                i = Convert.ToDouble(txtIntNomPGeom.Text);
                i2 = Convert.ToDouble(txtIntNomPGeom.Text);
                n = Convert.ToDouble(txtIntNomPGeom.Text);
                i3 = Convert.ToDouble(txtIntNomPGeom.Text);
                n2 = Convert.ToDouble(txtIntNomPGeom.Text);
                i4 = Convert.ToDouble(txtIntNomPGeom.Text);


                if (cmbPeriodo.SelectedItem != null && cmbTasaInt.SelectedItem != null && cmbTasaNom.SelectedItem != null)
                {
                    if (cmbPeriodo.SelectedItem.Equals("Anual") || cmbTasaInt.SelectedItem.Equals("Anual") || cmbTasaNom.SelectedItem.Equals("Anual"))
                    {

                        resultados = Valor_Anualidad * (((Math.Pow(1 + tasaNominal, Periodo) / Math.Pow(1 + tasaInteres, Periodo)) - 1) / (tasaNominal - tasaInteres));

                        ResultadoGeométrico.Add(new
                        {
                            VAnualidad = Valor_Anualidad,
                            Tasa_Interés = tasaInteres,
                            Tasa_Nominal = tasaNominal,
                            Periodo = Periodo,
                            Presente_Geométrico = resultados
                        });
                        dgvCalculoPGeometrico.DataSource = null;
                        dgvCalculoPGeometrico.DataSource = ResultadoGeométrico.ToList();
                    }
                    if (cmbPeriodo.SelectedItem.Equals("Semestral") || cmbTasaInt.SelectedItem.Equals("Semestral") || cmbTasaNom.SelectedItem.Equals("Semestral"))
                    {

                        i = tasaNominal / 2;
                        i2 = tasaInteres / 2;
                        p1 = Periodo / 2;
                        resultados = Valor_Anualidad * (((Math.Pow(1 + i, p1) / Math.Pow(1 + i2, p1)) - 1) / (i - i2));

                        ResultadoGeométrico.Add(new
                        {
                            VAnualidad = Valor_Anualidad,
                            Tasa_Interés = tasaInteres,
                            Tasa_Nominal = tasaNominal,
                            Periodo = Periodo,
                            Presente_Geométrico = resultados
                        });
                        dgvCalculoPGeometrico.DataSource = null;
                        dgvCalculoPGeometrico.DataSource = ResultadoGeométrico.ToList();
                    }
                    if (cmbPeriodo.SelectedItem.Equals("Trimestral") || cmbTasaInt.SelectedItem.Equals("Trimestral") || cmbTasaNom.SelectedItem.Equals("Trimestral"))
                    {

                        n = tasaNominal / 4;
                        i3 = tasaInteres / 4;
                        p2 = Periodo / 4;
                        resultados = Valor_Anualidad * (((Math.Pow(1 + n, p2) / Math.Pow(1 + i3, p2)) - 1) / (n - i3));

                        ResultadoGeométrico.Add(new
                        {
                            VAnualidad = Valor_Anualidad,
                            Tasa_Interés = tasaInteres,
                            Tasa_Nominal = tasaNominal,
                            Periodo = Periodo,
                            Presente_Geométrico = resultados
                        });
                        dgvCalculoPGeometrico.DataSource = null;
                        dgvCalculoPGeometrico.DataSource = ResultadoGeométrico.ToList();
                    }
                    if (cmbPeriodo.SelectedItem.Equals("Mensual") || cmbTasaInt.SelectedItem.Equals("Mensual") || cmbTasaNom.SelectedItem.Equals("Mensual"))
                    {

                        n2 = tasaNominal / 12;
                        i4 = tasaInteres / 12;
                        p3 = Periodo / 12;
                        resultados = Valor_Anualidad * (((Math.Pow(1 + n2, p3) / Math.Pow(1 + i4, p1)) - 1) / (n2 - i4));

                        ResultadoGeométrico.Add(new
                        {
                            VAnualidad = Valor_Anualidad,
                            Tasa_Interés = tasaInteres,
                            Tasa_Nominal = tasaNominal,
                            Periodo = Periodo,
                            Presente_Geométrico = resultados
                        });
                        dgvCalculoPGeometrico.DataSource = null;
                        dgvCalculoPGeometrico.DataSource = ResultadoGeométrico.ToList();
                    }
                }
            }
            catch ( FormatException x)
            {

                MessageBox.Show("Rellene los campos necesarios " + x);
            }
    }

        private void btnLimpGeom_Click(object sender, EventArgs e)
        {
            txtAnuualidadPGeom.Text = " ";
            txtIntNomPGeom.Text = "";
            txtIntPGeom.Text = "";
            txtPeriodoPGeom.Text = "";
            dgvCalculoPGeometrico.DataSource = null;
            dgvCalculoPGeometrico.Rows.Clear();
            cmbPeriodo.SelectedIndex = -1;
            cmbPeriodo.Items.Clear();
            cmbTasaInt.SelectedIndex = -1;
            cmbTasaInt.Items.Clear();
            cmbTasaNom.SelectedIndex = -1;
            cmbTasaNom.Items.Clear();
        }
    }
}

