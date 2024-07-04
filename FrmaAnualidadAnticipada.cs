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
    public partial class FrmaAnualidadAnticipada : Form
    {
        public FrmaAnualidadAnticipada()
        {
            InitializeComponent();
        }

        private void tbgDefinicion_Click(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void txtValorAnualidadPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInteresPresente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            txtValorAnualidadPresente.Text = "";
            txtInteresPresente.Text = "";
            txtPeriodoPresente.Text = "";
        }
        List<object> ResultadosPresente = new List<object>();
        private void button4_Click(object sender, EventArgs e)
        {
          if (rdbNo.Checked == true) { 
            try
            {
                double ValorAnualidadPresente, Interes, i1, AnualidadPresente;
                int periodo1, p1;

                ValorAnualidadPresente = Convert.ToDouble(txtValorAnualidadPresente.Text);
                i1 = Convert.ToDouble(txtInteresPresente.Text);
                p1 = Convert.ToInt32(txtPeriodoPresente.Text);
                if (cmbInteresPresente.SelectedItem != null || cmbPeriodoPresente.SelectedItem != null)
                {
                    if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {
                        Interes = i1 / 100;
                        periodo1 = p1;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        string formattedA = AnualidadPresente.ToString("N0");
                        string formattedAP = ValorAnualidadPresente.ToString("N0");
                        ResultadosPresente.Add(new { Anualidad ="C$ "+formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();


                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 / 12;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 / 2;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 / 4;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 * 12;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 * 6;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 * 3;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 * 2;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 / 6;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                                string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 / 2;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 * 4;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 / 3;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 * 2;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            string formattedA = AnualidadPresente.ToString("N0");
                            string formattedAP = ValorAnualidadPresente.ToString("N0");
                            ResultadosPresente.Add(new { Anualidad = "C$ " + formattedAP, Interes = Interes, Periodo = periodo1, Presente = "C$ " + formattedA });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                }
            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios " + x);
            }
          } 
          else if (rdbSi.Checked == true)
          {
                var metodo3 = new Metodos();
                string interesPresente = cmbInteresPresente.SelectedItem.ToString();
                string periodoPresente = cmbPeriodoPresente.SelectedItem.ToString();
                double TasaperiodoPresente = Convert.ToDouble(txtInteresPresente.Text);
                double valorAnualidadPresente = Convert.ToDouble(txtValorAnualidadPresente.Text);
                int periodo1Presente = Convert.ToInt32(txtPeriodoPresente.Text);
                metodo3.CalcularPresenteAnticipado(interesPresente, periodoPresente, TasaperiodoPresente, valorAnualidadPresente, periodo1Presente,ResultadosPresente, dgvResultadosPresente);
            }
        }
        //Fin presente
        List<object> ResultadosFuturo = new List<object>();
        private void btnCalcularFuturo_Click(object sender, EventArgs e)
        {
            double AnualidadFuturo,TasaInteresFuturo,i1;
            int Periodo, p1;
            if (rdbNoFuturo.Checked == true)
            {
                try
                {
                    AnualidadFuturo = Convert.ToDouble(txtValorAnualidadFuturo.Text);
                    i1 = Convert.ToDouble(txtTasaInteresFuturo.Text);
                    p1 = Convert.ToInt32(txtPeriodoFuturo.Text);
                    if (cmbInteresAnualidadF.SelectedItem != null && cmbPeriodoFuturo.SelectedItem != null)
                    {
                        if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ "+ formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 12;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();

                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 4;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();

                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 12;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 6;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 3;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 6;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 4;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 3;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            string formattedF = AnualidadFuturo.ToString("N0");
                            string formattedAF = Futuro.ToString("N0");
                            ResultadosFuturo.Add(new { Anualidad = "C$ " + formattedF, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = "C$ " + formattedAF });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                    }
                }
                catch (FormatException x)
                {
                    MessageBox.Show("Rellene los campos necesarios" + x);
                }
            }else if (rdbSiFuturo.Checked == true)
            {
                var metodos4 = new Metodos();
                string InteresFuturo = cmbInteresAnualidadF.SelectedItem.ToString();
                string PeriodoFuturo = cmbPeriodoFuturo.SelectedItem.ToString();
                double TasaInteres = Convert.ToDouble(txtTasaInteresFuturo.Text);
                double valorAnualidadFuturo = Convert.ToDouble(txtValorAnualidadFuturo.Text);
                int Periodo1 = Convert.ToInt32(txtPeriodoFuturo.Text);

                metodos4.CalcularFuturoAnticipado(InteresFuturo,PeriodoFuturo,TasaInteres,valorAnualidadFuturo,Periodo1,ResultadosFuturo,dgvResultadosFuturo);
            }
        }// boton futuro

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
            txtValorAnualidadFuturo.Text = "";
            txtTasaInteresFuturo.Text = "";
            txtPeriodoFuturo.Text = "";
        }
        //Fin Futuro

        private void txtValorPresenteAnualidadAnticipada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInteresAnualidadAnticipada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoAnualidadAnticipada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtValorPresenteAnualidadAnticipada.Text = "";
            txtInteresAnualidadAnticipada.Text = "";
            txtPeriodoAnualidadAnticipada.Text = "";
        }

        List<object> ResultadosAp = new List<object>();
        private void btnCalcularAp_Click(object sender, EventArgs e)
        {
            double i1;
            int p1;
            double valorPresenteAp = Convert.ToDouble(txtValorPresenteAnualidadAnticipada.Text);
            double TasaInteresAp = Convert.ToDouble(txtInteresAnualidadAnticipada.Text);
            int PeriodoAp = Convert.ToInt32(txtPeriodoAnualidadAnticipada.Text);
            //double AnualidadPresente = valorPresenteAp * ((TasaInteresAp * Math.Pow(1 + TasaInteresAp, PeriodoAp)) / (Math.Pow(1 + TasaInteresAp, PeriodoAp) - 1));
            if (rdbNoAnualidadAnticipadaPresente.Checked == true)
            {

                if (cmbInteresAp.SelectedItem != null && cmbPeriodoAp.SelectedItem != null)
                {
                    if (cmbInteresAp.SelectedItem.Equals("Semestral") && cmbPeriodoAp.SelectedItem.Equals("Años"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp * 2;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();

                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Semestral") && cmbPeriodoAp.SelectedItem.Equals("Meses"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp / 6;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Semestral") && cmbPeriodoAp.SelectedItem.Equals("Semestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Semestral") && cmbPeriodoAp.SelectedItem.Equals("Trimestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp / 2;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Anual") && cmbPeriodoAp.SelectedItem.Equals("Años"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Anual") && cmbPeriodoAp.SelectedItem.Equals("Meses"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp / 12;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Anual") && cmbPeriodoAp.SelectedItem.Equals("Semestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp / 2;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Anual") && cmbPeriodoAp.SelectedItem.Equals("Trimestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp / 4;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }

                    else if (cmbInteresAp.SelectedItem.Equals("Mensual") && cmbPeriodoAp.SelectedItem.Equals("Años"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp * 12;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Mensual") && cmbPeriodoAp.SelectedItem.Equals("Meses"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Mensual") && cmbPeriodoAp.SelectedItem.Equals("Semestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp * 6;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Mensual") && cmbPeriodoAp.SelectedItem.Equals("Trimestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp * 3;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Trimestral") && cmbPeriodoAp.SelectedItem.Equals("Años"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp * 4;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }

                    else if (cmbInteresAp.SelectedItem.Equals("Trimestral") && cmbPeriodoAp.SelectedItem.Equals("Meses"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp / 3;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Trimestral") && cmbPeriodoAp.SelectedItem.Equals("Semestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp * 2;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAp.SelectedItem.Equals("Trimestral") && cmbPeriodoAp.SelectedItem.Equals("Trimestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        string formattedP = valorPresenteAp.ToString("N0");
                        string formattedAP = AnualidadPresente.ToString("N0");
                        ResultadosAp.Add(new { ValorPresente = "C$ " + formattedP, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAP });
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                        dgvResultadosAnualidadPresenteAnticipada.DataSource = ResultadosAp.ToList();
                    }
                }
            }
            else if (rdbSiAnualidadAnticipadaPresente.Checked == true)
            {
                var metodo9 = new Metodos();
                string interesPresenteAp = cmbInteresAp.SelectedItem.ToString();
                string periodoPresenteAp = cmbPeriodoAp.SelectedItem.ToString();
                double TasaInteresPresente = Convert.ToDouble(txtInteresAnualidadAnticipada.Text);
                double valorPresenteAp2 = Convert.ToDouble(txtValorPresenteAnualidadAnticipada.Text);
                int periodoAp = Convert.ToInt32(txtPeriodoAnualidadAnticipada.Text);

                metodo9.AnualidadPresente(interesPresenteAp,periodoPresenteAp,TasaInteresPresente,valorPresenteAp2,periodoAp,ResultadosAp, dgvResultadosAnualidadPresenteAnticipada);
            }
        }
        //Fin AnualidadPresente
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
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
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

        private void btnLimpiarAf_Click(object sender, EventArgs e)
        {
            txtValorFuturoAnualidadFuturo.Text = "";
            txtInteresAnualidadFuturo.Text = "";
            txtPeriodoAnualidadFuturo.Text = "";

        }
        List<object> ResultadosAf = new List<object>();
        private void btnCalcularAf_Click(object sender, EventArgs e)
        {
            if (rdbNoAnualidadAnticipadaAF.Checked == true)
            {
                try
                {
                    double i1;
                    int p1;
                    double ValorFuturoAf = Convert.ToDouble(txtValorFuturoAnualidadFuturo.Text);
                    double TasaInteresAf = Convert.ToDouble(txtInteresAnualidadFuturo.Text);
                    int PeriodoAf = Convert.ToInt32(txtPeriodoAnualidadFuturo.Text);


                    if (cmbInteresAf.SelectedItem != null && cmbPeriodoAf.SelectedItem != null)
                    {
                        if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Meses"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf / 12;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf / 2;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Trimestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf / 4;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Mensual") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf * 12;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Mensual") && cmbPeriodoAf.SelectedItem.Equals("Meses"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Mensual") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf * 6;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Mensual") && cmbPeriodoAf.SelectedItem.Equals("Trimestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf * 3;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Semestral") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf * 2;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Semestral") && cmbPeriodoAf.SelectedItem.Equals("Meses"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf / 6;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Semestral") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Semestral") && cmbPeriodoAf.SelectedItem.Equals("Trimestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf / 2;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Trimestral") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf * 4;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Trimestral") && cmbPeriodoAf.SelectedItem.Equals("Meses"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf / 3;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Trimestral") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf * 2;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Trimestral") && cmbPeriodoAf.SelectedItem.Equals("Trimestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            string formattedF = ValorFuturoAf.ToString("N0");
                            string formattedAF = AnualidadFuturo.ToString("N0");
                            ResultadosAf.Add(new { Futuro = "C$ " + formattedF, Interes = i1, Periodo = p1, Anualidad = "C$ " + formattedAF });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }

                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Rellene los campos necesarios" + ex);
                }
            }
            else if (rdbSiAnualidadAnticipadaAF.Checked == true)
            {
                var metodos8 = new Metodos();
                string interesFuturoAf = cmbInteresAf.SelectedItem.ToString();
                string periodoFuturoAf = cmbPeriodoAf.SelectedItem.ToString();
                double tasaInteresFuturoAf = Convert.ToDouble(txtInteresAnualidadFuturo.Text);
                double valorAnualidadFuturoAf = Convert.ToDouble(txtValorFuturoAnualidadFuturo.Text);
                int periodo1FuturoAf = Convert.ToInt32(txtPeriodoAnualidadFuturo.Text);

                metodos8.AnualidadFuturo(interesFuturoAf, periodoFuturoAf, tasaInteresFuturoAf, valorAnualidadFuturoAf, periodo1FuturoAf, ResultadosAf, dgvResultadosAnualidadFuturo);
            }
        }

        private void cmbInteresAf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtInteresAnualidadFuturo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            //ignorar
        }
    }
}
