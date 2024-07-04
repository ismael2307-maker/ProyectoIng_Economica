using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
         List<object> ResultadosPresenteSimple = new List<object>();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double ValorPresenteFu;
                double TasaInteresFu, PeriodoFu;
                ValorPresenteFu = Convert.ToDouble(txtValorPresenteF.Text);
                TasaInteresFu = Convert.ToDouble(txtTasaInteresF.Text);
                PeriodoFu = Convert.ToDouble(txtPeriodoF.Text);
                double p;
                double interes,Futuro;
                
                if (cmbInteresSimple.SelectedItem != null || cmbPeriodoSimple.SelectedItem != null)
                {
                    if (cmbInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoSimple.SelectedItem.Equals("Meses"))
                    {
                        p = PeriodoFu / 12;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes  * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");

                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoSimple.SelectedItem.Equals("Años"))
                    {
                        p = PeriodoFu;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoSimple.SelectedItem.Equals("Semestres"))
                    {
                        p = PeriodoFu * 0.5;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        p = PeriodoFu / 4;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Mensual") && cmbPeriodoSimple.SelectedItem.Equals("Años"))
                    {
                        p = PeriodoFu * 12;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Mensual") && cmbPeriodoSimple.SelectedItem.Equals("Meses"))
                    {
                        p = PeriodoFu;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Mensual") && cmbPeriodoSimple.SelectedItem.Equals("Semestres"))
                    {
                        p = PeriodoFu * 6;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Mensual") && cmbPeriodoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        p = PeriodoFu * 3;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Semestral") && cmbPeriodoSimple.SelectedItem.Equals("Años"))
                    {
                        p = PeriodoFu * 2;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Semestral") && cmbPeriodoSimple.SelectedItem.Equals("Meses"))
                    {
                        p = PeriodoFu / 6;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();

                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Semestral") && cmbPeriodoSimple.SelectedItem.Equals("Semestres"))
                    {
                        p = PeriodoFu * 0.5;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Semestral") && cmbPeriodoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        p = PeriodoFu / 2;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoSimple.SelectedItem.Equals("Años"))
                    {
                        p = PeriodoFu * 4;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoSimple.SelectedItem.Equals("Meses"))
                    {
                        p = PeriodoFu / 3;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoSimple.SelectedItem.Equals("Semestres"))
                    {
                        p = PeriodoFu * 2;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        p = PeriodoFu;
                        interes = TasaInteresFu / 100;
                        Futuro = ValorPresenteFu * (1 + (interes * p));
                        string formattedP = ValorPresenteFu.ToString("N0");
                        string formattedF = Futuro.ToString("N0");
                        ResultadosPresenteSimple.Add(new { Presente = "C$ " + formattedP, Interes = interes, Periodo = p, Futuro = "C$ " + formattedF });

                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = ResultadosPresenteSimple.ToList();
                    }
                }
               
            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios");
            }

        }

        private void txtValorFuturoP_TextChanged(object sender, EventArgs e)
        {
           //Ignorar
        }

        //CALCULAR VALOR PRESENTE
        private List<object> ResultadosP = new List<object>();
        private void btnCalcularP_Click(object sender, EventArgs e)
        {
            try 
            {
                double ValorFuturoPe = Convert.ToDouble(txtValorFuturoP.Text);
                double TasaInteresPe = Convert.ToDouble(txtTasaInteresP.Text);
                double PeriodoPe = Convert.ToDouble(txtPeriodoP.Text);
                double p, interes,Presente;
               

                if (cmbInteresFuturoSimple.SelectedItem != null || cmbPeriodoFuturoSimple.SelectedItem !=null)
                {
                    if(cmbInteresFuturoSimple.SelectedItem.Equals("Anual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        p = PeriodoPe;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Anual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Meses"))
                    {
                        p = PeriodoPe / 12;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Anual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Semestres"))
                    {
                        p = PeriodoPe * 0.5;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Anual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        p = PeriodoPe / 4;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Mensual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        p = PeriodoPe * 12;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Mensual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Meses"))
                    {
                        p = PeriodoPe;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Mensual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Semestres"))
                    {
                        p = PeriodoPe * 6;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Mensual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        p = PeriodoPe * 3;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Semestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        p = PeriodoPe * 2;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Semestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Meses"))
                    {
                        p = PeriodoPe / 6;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Semestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Semestres"))
                    {
                        p = PeriodoPe;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Semestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        p = PeriodoPe / 2;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        p = PeriodoPe * 4;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Meses"))
                    {
                        p = PeriodoPe / 3;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Semestres"))
                    {
                        p = PeriodoPe * 2;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        p = PeriodoPe;
                        interes = TasaInteresPe / 100;
                        Presente = ValorFuturoPe / (1 + (interes * p));
                        double Presente2 = Math.Round(Presente);
                        string formattedF = ValorFuturoPe.ToString("N0");
                        string formattedP2 = Presente2.ToString("N0");
                        ResultadosP.Add(new { Futuro = "C$ " + formattedF, Periodo = p, Interes = interes, Presente = "C$ " + formattedP2 });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = ResultadosP.ToList();
                    }

                }

                
            }
            catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios");
            }
        }

        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            txtValorFuturoP.Text = "";
            txtTasaInteresP.Text = "";
            txtPeriodoP.Text = "";
        }

        //CALCULAR VALOR DEL INTERES
        private List<object> ResultadosInteresS = new List<object>();
        private void btnCalcularI_Click(object sender, EventArgs e)
        {
            try
            {
                double ValorFuturoIn = Convert.ToDouble(txtValorFuturoI.Text);
                double ValorPresenteIn = Convert.ToDouble(txtValorPresenteI.Text);
                double PeriodoIn = Convert.ToDouble(txtPeriodoI.Text);
                double p,interes;
               

                if (cmbTipoTasa.SelectedItem != null || cmbPeriodoInteresSimple != null) 
                {
                    if (cmbTipoTasa.SelectedItem.Equals("Anual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Meses"))
                    {
                        p = PeriodoIn / 12;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Anual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Años"))
                    {
                        p = PeriodoIn;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Anual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Semestres"))
                    {
                        p = PeriodoIn * 0.5;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Anual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Trimestres"))
                    {
                        p = PeriodoIn / 4;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Mensual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Años"))
                    {
                        p = PeriodoIn * 12;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Mensual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Meses"))
                    {
                        p = PeriodoIn;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Mensual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Semestres"))
                    {
                        p = PeriodoIn * 6;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Mensual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Trimestres"))
                    {
                        p = PeriodoIn * 3;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Semestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Años"))
                    {
                        p = PeriodoIn * 2;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Semestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Meses"))
                    {
                        p = PeriodoIn / 6;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Semestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Semestres"))
                    {
                        p = PeriodoIn;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Semestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Trimestres"))
                    {
                        p = PeriodoIn / 2;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Trimestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Años"))
                    {
                        p = PeriodoIn * 4;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Trimestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Meses"))
                    {
                        p = PeriodoIn / 3;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Trimestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Semestres"))
                    {

                        p = PeriodoIn * 2;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Trimestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Trimestres"))
                    {
                        p = PeriodoIn;
                        double Numerador = (ValorFuturoIn / ValorPresenteIn) - 1;
                        double Denominador = p;
                        interes = Numerador / Denominador;
                        string formattedF = ValorFuturoIn.ToString("N0");
                        string formattedP = ValorPresenteIn.ToString("N0");
                        ResultadosInteresS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$ " + formattedP, Periodo = p, Interes = interes });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = ResultadosInteresS.ToList();

                    }
                }
            }
            catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios " + x);

            }catch(DivideByZeroException ex)
            {
                MessageBox.Show("El periodo no puede ser cero.", "Error de division por cero"+ex);
            }catch(NullReferenceException i)
            {
                MessageBox.Show("Ha ocurrido un error. Vuelva digitar valores validos");
            }
        }
        private List<object> ResultadosPeriodoS = new List<object>();
        private void btnCalcularN_Click(object sender, EventArgs e)
        {
            try 
            {
                double ValorFuturoNe = Convert.ToDouble(txtValorFuturoN.Text);
                double ValorPresenteNe = Convert.ToDouble(txtValorPresenteN.Text);
                double TasaInteresNe = Convert.ToDouble(txtTasaInteresN.Text);
                //int Periodo = (int)((ValorFuturoNe / ValorPresenteNe - 1) / (TasaInteresNe));
                double interes;

                interes = TasaInteresNe / 100;
                double Numerador = (ValorFuturoNe / ValorPresenteNe) - 1;
                double denominador = TasaInteresNe;
                double Periodo = (Numerador / denominador);
                int Periodo2 = (int)(Periodo * 100);
                string formattedF = ValorFuturoNe.ToString("N0");
                string formattedP = ValorPresenteNe.ToString("N0");
                ResultadosPeriodoS.Add(new { Futuro = "C$ " + formattedF, Presente = "C$" + formattedP, Interes = interes, Periodo = Periodo2 });
                dgvResultadosN.DataSource = null;
                dgvResultadosN.DataSource = ResultadosPeriodoS.ToList();


            }
            catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios " + x);
            }catch(DivideByZeroException ex)
            {
                MessageBox.Show("El periodo no puede ser cero.", "Error de division por cero" + ex);
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

        private void btnLimpiarI_Click(object sender, EventArgs e)
        {
            txtValorFuturoI.Text = "";
            txtValorPresenteI.Text = "";
            txtPeriodoI.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //ignorar

        }
    }
}
