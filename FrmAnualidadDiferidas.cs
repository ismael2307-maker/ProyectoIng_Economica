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
    public partial class FrmAnualidadDiferidas : Form
    {
        public FrmAnualidadDiferidas()
        {
            InitializeComponent();
        }

        private void txtValorAnualidadPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteresPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarPresente_Click(object sender, EventArgs e)
        {
            txtValorAnualidadPresente.Text = "";
            txtTasaInteresPresente.Text = "";
            txtPeriodoPresente.Text = "";
            txtPeriodo2.Text = "";
        }

        private void txtPeriodo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private List<object> ResultadosPresente = new List<object>();

        private void btnCalcularPresente_Click(object sender, EventArgs e)
        {
            int Anualidad,Periodo1,Periodo2,p1,p2;
            double Interes,i1;
            try
            {
                Anualidad = Convert.ToInt32(txtValorAnualidadPresente.Text);
                i1 = Convert.ToDouble(txtTasaInteresPresente.Text);
                p1 = Convert.ToInt32(txtPeriodoPresente.Text);
                p2 = Convert.ToInt32(txtPeriodo2.Text);

                if (cmbInteresPresente.SelectedItem != null || cmbPeriodoPresente.SelectedItem != null)
                {
                    if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1;
                        Periodo2 = p2;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P});
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if(cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1 / 12;
                        Periodo2 = p2 / 12;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1 / 2;
                        Periodo2 = p2 / 2;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1 / 4;
                        Periodo2 = p2 / 4;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    //Fin de interes anual
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1 * 12;
                        Periodo2 = p2 * 12;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1;
                        Periodo2 = p2;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1 * 6;
                        Periodo2 = p2 * 6;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1 * 3;
                        Periodo2 = p2 * 3;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    //Fin de Interes Mensual
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1 * 2;
                        Periodo2 = p2 * 2;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1 / 6;
                        Periodo2 = p2 / 6;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1;
                        Periodo2 = p2;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1 / 2;
                        Periodo2 = p2 / 2;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    // Fin de Tasa Interes Semestral
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1 * 4;
                        Periodo2 = p2 * 4;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1 / 3;
                        Periodo2 = p2 / 3;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1 * 2;
                        Periodo2 = p2 * 2;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {
                        Interes = i1 / 100;
                        Periodo1 = p1;
                        Periodo2 = p2;

                        double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                        ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    //Fin Tasa Interes Trimestral
                }


            }catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios" +x);
            }
        }

        private void txtValorAnualidadFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteresFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodo1Futuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodo2Futuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarFuturo_Click(object sender, EventArgs e)
        {
            txtValorAnualidadFuturo.Text = "";
            txtTasaInteresFuturo.Text = "";
            txtPeriodo1Futuro.Text = "";
            txtPeriodo2Futuro.Text = "";
        }

        private List<object> ResultadosFuturo = new List<object>();
        private void btnCalcularFuturo_Click(object sender, EventArgs e)
        {
            int AnualidadFuturo,p1,p2,Periodo1,Periodo2;
            double TasaInteres, i1;
            try
            {
                AnualidadFuturo = Convert.ToInt32(txtValorAnualidadFuturo.Text);
                i1 = Convert.ToDouble(txtTasaInteresFuturo.Text);
                p1 = Convert.ToInt32(txtPeriodo1Futuro.Text);
                p2 = Convert.ToInt32(txtPeriodo2Futuro.Text);

                if (cmbInteresFuturo.SelectedItem != null || cmbPeriodoFuturo.SelectedItem != null)
                {
                    if (cmbInteresFuturo.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Años")) 
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1;
                        Periodo2 = p2;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new {Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 / 12;
                        Periodo2 = p2 / 12;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                   else if (cmbInteresFuturo.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                   {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 / 2;
                        Periodo2 = p2 / 2;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                   }
                   else if (cmbInteresFuturo.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                   {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 / 4;
                        Periodo2 = p2 / 4;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                   }
                    //Fin de tasa Interes Anual

                    else if (cmbInteresFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 * 12;
                        Periodo2 = p2 * 12;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1;
                        Periodo2 = p2;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 * 6;
                        Periodo2 = p2 * 6;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 * 3;
                        Periodo2 = p2 * 3;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    //Fin de Tasa Interes Mensual
                    else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 * 2;
                        Periodo2 = p2 * 2;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 / 6;
                        Periodo2 = p2 / 6;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1;
                        Periodo2 = p2;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 / 2;
                        Periodo2 = p2 / 2;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    // Fin de Tasa Interes Semestral

                    else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 * 4;
                        Periodo2 = p2 * 4;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 / 3;
                        Periodo2 = p2 / 3;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1;
                        Periodo2 = p2;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 / 2;
                        Periodo2 = p2 / 2;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    //Fin de Tasa Interes Semestral
                    else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 * 4;
                        Periodo2 = p2 * 4;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 / 3;
                        Periodo2 = p2 / 3;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1 * 2;
                        Periodo2 = p2 * 2;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo1 = p1;
                        Periodo2 = p2;
                        double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                        ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                    }
                    //Fin de Tasa interes Trimestral
                }
            }catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios");
            }
        }

        private void txtValorPresenteAnualidadVencida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInteresAnualidadVencida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoAnualidadVencida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarDiAp_Click(object sender, EventArgs e)
        {
            txtPeriodoAnualidadVencida.Text = "";
            txtInteresAnualidadVencida.Text = "";
            txtValorPresenteAnualidadVencida.Text = "";
        }

        private List<object> ResultadosAp = new List<object>();
        private void btnCalcularDiAp_Click(object sender, EventArgs e)
        {
            int Presente, Periodo, n;
            double TasaInteres, i1;
            try
            {
                Presente = Convert.ToInt32(txtValorPresenteAnualidadVencida.Text);
                i1 = Convert.ToDouble(txtInteresAnualidadVencida.Text);
                n = Convert.ToInt32(txtPeriodoAnualidadVencida.Text);

                if (cmbInteresA.SelectedItem != null || cmbPeriodoA.SelectedItem != null)
                {
                    if (cmbInteresA.SelectedItem.Equals("Anual") && cmbPeriodoA.SelectedItem.Equals("Años"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Anual") && cmbPeriodoA.SelectedItem.Equals("Meses"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n / 12;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Anual") && cmbPeriodoA.SelectedItem.Equals("Semestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n / 2;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Anual") && cmbPeriodoA.SelectedItem.Equals("Trimestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n / 4;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    //Fin de interes anual 
                    else if (cmbInteresA.SelectedItem.Equals("Mensual") && cmbPeriodoA.SelectedItem.Equals("Años"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n * 12;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Mensual") && cmbPeriodoA.SelectedItem.Equals("Meses"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Mensual") && cmbPeriodoA.SelectedItem.Equals("Semestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n * 6;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Mensual") && cmbPeriodoA.SelectedItem.Equals("Trimestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n * 3;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Semestral") && cmbPeriodoA.SelectedItem.Equals("Años"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n * 2;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Semestral") && cmbPeriodoA.SelectedItem.Equals("Meses"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n / 6;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Semestral") && cmbPeriodoA.SelectedItem.Equals("Semestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Semestral") && cmbPeriodoA.SelectedItem.Equals("Trimestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n / 2;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Trimestral") && cmbPeriodoA.SelectedItem.Equals("Años"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n * 4;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Trimestral") && cmbPeriodoA.SelectedItem.Equals("Meses"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n / 3;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Trimestral") && cmbPeriodoA.SelectedItem.Equals("Semestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n * 2;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresA.SelectedItem.Equals("Trimestral") && cmbPeriodoA.SelectedItem.Equals("Trimestres"))
                    {
                        TasaInteres = i1 / 100;
                        Periodo = n;
                        double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                        ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                        dgvResultadosAnualidadPresente.DataSource = null;
                        dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                    }


                }

            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios" + x);
            }
        }

        
    }
}
