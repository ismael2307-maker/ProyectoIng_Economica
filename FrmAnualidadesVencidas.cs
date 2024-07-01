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
    public partial class FrmAnualidadesVencidas : Form
    {
        public FrmAnualidadesVencidas()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            //Ignorar
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

        private void txtTasaInteresAnualidadPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoAnualidadPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarAnualidadVencida_Click(object sender, EventArgs e)
        {
            txtValorAnualidadPresente.Clear();
            txtTasaInteresAnualidadPresente.Clear();
            txtPeriodoAnualidadPresente.Clear();
        }
        private List<object> ResultadosPresente = new List<object>();

        private void btnCalculaAnualidadVencida_Click(object sender, EventArgs e)
        {
            int Anualidad, Periodo, p1;
            double Interes, i1;
            if (rdbNo.Checked==true)
            {
                try
                {
                    Anualidad = Convert.ToInt32(txtValorAnualidadPresente.Text);
                    i1 = Convert.ToDouble(txtTasaInteresAnualidadPresente.Text);
                    p1 = Convert.ToInt32(txtPeriodoAnualidadPresente.Text);
                    if (cmbInteresAnualidadPresente.SelectedItem != null || cmbPeriodoAnualidadPresente.SelectedItem != null)
                    {
                        if (cmbInteresAnualidadPresente.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1/12;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1/2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1/4;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        //Fin de interes anual
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 * 12;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 * 6;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 * 3;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        //Fin de Interes Mensual
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 * 2;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 / 6;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1;
                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 / 2;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        // Fin de Tasa Interes Semestral
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 *4;
                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo= p1/ 3;
                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 * 2;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1;
                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        //Fin Tasa Interes Trimestral
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Rellene los campos necesarios" +ex);
                }
            }
            else if (rdbSi.Checked==true)
            {
                var metodo3 = new Metodos();
                string interesPresente = cmbInteresAnualidadPresente.SelectedItem.ToString();
                string periodoPresente = cmbPeriodoAnualidadPresente.SelectedItem.ToString();
                double TasaperiodoPresente = Convert.ToDouble(txtTasaInteresAnualidadPresente.Text);
                double valorAnualidadPresente = Convert.ToDouble(txtValorAnualidadPresente.Text);
                int periodo1Presente = Convert.ToInt32(txtPeriodoAnualidadPresente.Text);
                metodo3.CalcularPresenteVencida(interesPresente, periodoPresente, TasaperiodoPresente, valorAnualidadPresente, periodo1Presente, ResultadosPresente, dgvResultadosPresente);
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

        private void txtInteresFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoFuturo_KeyPress(object sender, KeyPressEventArgs e)
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
            txtValorAnualidadFuturo.Clear();
            txtInteresFuturo.Clear();
            txtPeriodoFuturo.Clear();
        }
        private List<object> ResultadosFuturo = new List<object>();

        private void btnCalcularFuturo_Click(object sender, EventArgs e)
        {
            int AnualidadFuturo, p1, Periodo;
            double TasaInteres, i1;
            if (rdbNoF.Checked==true)
            {
                try
                {
                    AnualidadFuturo = Convert.ToInt32(txtValorAnualidadFuturo.Text);
                    i1 = Convert.ToDouble(txtInteresFuturo.Text);
                    p1 = Convert.ToInt32(txtPeriodoFuturo.Text);


                    if (cmbInteresAnualidadVencidaFuturo.SelectedItem != null || cmbPeriodoAnualidadVencida.SelectedItem != null)
                    {
                        if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1;

                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 / 12;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 / 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 / 4;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        //Fin de tasa Interes Anual

                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 * 12;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 * 6;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 * 3;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        //Fin de Tasa Interes Mensual
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 * 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 / 6;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo= p1 / 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        // Fin de Tasa Interes Semestral


                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 * 4;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();

                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 / 3;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 * 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        //Fin de Tasa interes Trimestral
                    }
                }
                catch (FormatException x)
                {
                    MessageBox.Show("Rellene los campos necesarios");
                }
            }
            else if (rdbSiF.Checked==true)
            {
                var metodos4 = new Metodos();
                string InteresFuturo = cmbInteresAnualidadVencidaFuturo.SelectedItem.ToString();
                string PeriodoFuturo = cmbPeriodoAnualidadVencida.SelectedItem.ToString();
                double TasaInteres1 = Convert.ToDouble(txtInteresFuturo.Text);
                double valorAnualidadFuturo = Convert.ToDouble(txtValorAnualidadFuturo.Text);
                int Periodo1 = Convert.ToInt32(txtPeriodoFuturo.Text);

                metodos4.CalcularFuturoAnualidadVencida(InteresFuturo, PeriodoFuturo, TasaInteres1, valorAnualidadFuturo, Periodo1, ResultadosFuturo, dgvResultadosFuturo);

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
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
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

        private void btnLimpiarAnualidadPresente_Click(object sender, EventArgs e)
        {
            txtValorPresenteAnualidadVencida.Clear();
            txtInteresAnualidadVencida.Clear();
            txtPeriodoAnualidadVencida.Clear();
        }
        private List<object> ResultadosAp = new List<object>();

        private void btnCalcularAnualidadPresente_Click(object sender, EventArgs e)
        {
            int Presente, Periodo, n;
            double TasaInteres, i1;
            if (rdbNoPP.Checked== true)
            {
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
            else if (rdbSiPP.Checked==true)
            {
                var metodo9 = new Metodos();
                string interesPresenteAp = cmbInteresA.SelectedItem.ToString();
                string periodoPresenteAp = cmbPeriodoA.SelectedItem.ToString();
                double TasaInteresPresente = Convert.ToDouble(txtInteresAnualidadVencida.Text);
                double valorPresenteAp2 = Convert.ToDouble(txtValorPresenteAnualidadVencida.Text);
                int periodoAp = Convert.ToInt32(txtPeriodoAnualidadVencida.Text);

                metodo9.AnualidadPresente(interesPresenteAp, periodoPresenteAp, TasaInteresPresente, valorPresenteAp2, periodoAp, ResultadosAp, dgvResultadosAnualidadPresente);
            }
        }

        private void txtValorFuturoAnualidadFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInteresAnualidadFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoAnualidadFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarAnualidadFuturo_Click(object sender, EventArgs e)
        {
            txtValorAnualidadFuturo.Clear();
            txtInteresAnualidadFuturo.Clear();
            txtPeriodoAnualidadFuturo.Clear();

        }
        private List<object> ResultadosAf = new List<object>();
        private void btnCalcularAnualidadFuturo_Click(object sender, EventArgs e)
        {
            int Futuro, Periodo, n;
            double TasaInteres, i1;
            if (rdbNop.Checked== true)
            {

                try
                {
                    Futuro = Convert.ToInt32(txtValorFuturoAnualidadFuturo.Text);
                    i1 = Convert.ToDouble(txtInteresAnualidadFuturo.Text);
                    n = Convert.ToInt32(txtPeriodoAnualidadFuturo.Text);

                    if (cmbInteresAF.SelectedItem != null || cmbPeriodoAF.SelectedItem != null)
                    {
                        if (cmbInteresAF.SelectedItem.Equals("Anual") && cmbPeriodoAF.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Anual") && cmbPeriodoAF.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 12;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();

                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Anual") && cmbPeriodoAF.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 2;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Anual") && cmbPeriodoAF.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 4;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        //Fin de interes anual 
                        else if (cmbInteresAF.SelectedItem.Equals("Mensual") && cmbPeriodoAF.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 12;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Mensual") && cmbPeriodoAF.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Mensual") && cmbPeriodoAF.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 6;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Mensual") && cmbPeriodoAF.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 3;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Semestral") && cmbPeriodoAF.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 2;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Semestral") && cmbPeriodoAF.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 6;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Semestral") && cmbPeriodoAF.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Semestral") && cmbPeriodoAF.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 2;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Trimestral") && cmbPeriodoAF.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 4;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Trimestral") && cmbPeriodoAF.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 3;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Trimestral") && cmbPeriodoAF.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 2;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Trimestral") && cmbPeriodoAF.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }


                    }

                }
                catch (FormatException x)
                {
                    MessageBox.Show("Rellene los campos necesarios" + x);
                }

            }
            else if (rdbSip.Checked==true)
            {
                var metodos8 = new Metodos();
                string interesFuturoAf = cmbInteresAF.SelectedItem.ToString();
                string periodoFuturoAf = cmbPeriodoAF.SelectedItem.ToString();
                double tasaInteresFuturoAf = Convert.ToDouble(txtInteresAnualidadFuturo.Text);
                double valorAnualidadFuturoAf = Convert.ToDouble(txtValorFuturoAnualidadFuturo.Text);
                int periodo1FuturoAf = Convert.ToInt32(txtPeriodoAnualidadFuturo.Text);

                metodos8.AnualidadFuturo(interesFuturoAf, periodoFuturoAf, tasaInteresFuturoAf, valorAnualidadFuturoAf, periodo1FuturoAf, ResultadosAf, dgvResultadosAnualidadFuturo);
            }
        }
    }
}
