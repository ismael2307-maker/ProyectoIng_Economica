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
        public FrmIntCompuesto()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
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
            txtValorPresenteF.Clear();
            txtTasaInteresF.Clear();
            dgvResultadosFU.DataSource = null;
            dgvResultadosFU.Rows.Clear();
            txtPeriodoF.Clear();
        }
        private List<object> Resultados = new  List<object>();
        private void btnCalcularI_Click(object sender, EventArgs e)
        {
            double ValorPresent, ValorFuturo;
            double Tasa;
            double Periodo;

            try
            {
               ValorFuturo = Convert.ToDouble(txtValorFuturoI.Text);
               ValorPresent = Convert.ToDouble(txtValorPresenteI.Text);
               Periodo = Convert.ToDouble(txtPeriodoI.Text);
               Tasa = Convert.ToDouble(txtPeriodoI.Text);
              
                    if (cmbPeriodoI.SelectedItem.Equals("Anual") || cmbbInteres.Equals("Semestral"))
                    {
                     Tasa = Math.Pow(ValorFuturo/ValorPresent,1/ (Periodo * 2)) -1;
                     string formattedPresent1 = ValorPresent.ToString("N0");
                     string formattedFut1 = ValorFuturo.ToString("N0");
                   
                        Resultados.Add(new
                        {
                           ValorPresent = "$ " + formattedPresent1 ,
                           ValorFuturo = "$ " + formattedFut1,
                            Periodo = Periodo,
                            Tasa = Tasa
                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Mensual") || cmbbInteres.Equals("Semestral"))
                    {
                       Tasa = Math.Pow(ValorFuturo/ValorPresent,1/ (Periodo / 6)) -1;
                    string formattedPresent2 = ValorPresent.ToString("N0");
                    string formattedFut2 = ValorFuturo.ToString("N0");

                    Resultados.Add(new
                        {
                            ValorPresent = "$ " + formattedPresent2 ,
                            ValorFuturo = "$ " + formattedFut2,
                            Periodo = Periodo,
                            Tasa = Tasa
                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = Resultados.ToList();
                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Semestral") || cmbbInteres.Equals("Semestral"))
                    {
                       Tasa = Math.Pow(ValorFuturo/ValorPresent,1/ Periodo) -1;
                    string formattedPresent3 = ValorPresent.ToString("N0");
                    string formattedFut3 = ValorFuturo.ToString("N0");

                    Resultados.Add(new
                        {
                           ValorPresent= "$ " + formattedPresent3 ,
                           ValorFuturo = "$ " + formattedFut3,
                            Periodo = Periodo,
                            Tasa = Tasa
                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Trimestral") || cmbbInteres.Equals("Semestral"))
                    {
                       Tasa = Math.Pow(ValorFuturo/ValorPresent,1/ (Periodo / 2)) -1;
                    string formattedPresent4 = ValorPresent.ToString("N0");
                    string formattedFut4 = ValorFuturo.ToString("N0");
                    Resultados.Add(new
                        {
                            ValorPresent = "$ " + formattedPresent4 ,
                            ValorFuturo = "$ " + formattedFut4,
                            Periodo = Periodo,
                            Tasa = Tasa
                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Anual") || cmbbInteres.Equals("Anual"))
                    {
                       Tasa = Math.Pow((ValorFuturo/ValorPresent),1/ Periodo) -1;
                    string formattedPresent5 = ValorPresent.ToString("N0");
                    string formattedFut5 = ValorFuturo.ToString("N0");

                    Resultados.Add(new
                        {
                           ValorPresent= "$ " + formattedPresent5 ,
                           ValorFuturo = "$ " + formattedFut5,
                            Periodo = Periodo,
                            Tasa = Tasa
                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Mensual") || cmbbInteres.Equals("Anual"))
                    {
                      Tasa = Math.Pow(ValorFuturo / ValorPresent, 1 / (Periodo / 12)) - 1;
                    string formattedPresent6 = ValorPresent.ToString("N0");
                    string formattedFut6 = ValorFuturo.ToString("N0");
                    Resultados.Add(new
                      {
                        ValorPresent = "$ " + formattedPresent6 ,
                        ValorFuturo = "$ " + formattedFut6,
                        Periodo = Periodo,
                        Tasa = Tasa
                      });
                       dgvIntCompIn.DataSource = null;
                      dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Semestral") || cmbbInteres.Equals("Anual"))
                    {
                      Tasa = Math.Pow(ValorFuturo / ValorPresent, 1 / (Periodo / 2)) - 1;
                    string formattedPresent7 = ValorPresent.ToString("N0");
                    string formattedFut7 = ValorFuturo.ToString("N0");
                    Resultados.Add(new
                      {
                       ValorPresent = "$ " + formattedPresent7,
                       ValorFuturo = "$ " + formattedFut7,
                        Periodo = Periodo,
                        Tasa = Tasa
                      });
                       dgvIntCompIn.DataSource = null;
                      dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Trimestral") || cmbbInteres.Equals("Anual"))
                    {
                      Tasa = Math.Pow(ValorFuturo / ValorPresent, 1 / (Periodo / 4)) - 1;
                    string formattedPresent8 = ValorPresent.ToString("N0");
                    string formattedFut18 = ValorFuturo.ToString("N0");
                    Resultados.Add(new
                      {
                      ValorPresent = "$ " + formattedPresent8,
                      ValorFuturo = "$ " + formattedFut18,
                        Periodo = Periodo,
                        Tasa = Tasa
                      });
                       dgvIntCompIn.DataSource = null;
                      dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Anual") || cmbbInteres.Equals("Mensual"))
                    {
                      Tasa = Math.Pow(ValorFuturo / ValorPresent, 1 / (Periodo * 12)) - 1;
                    string formattedPresent9 = ValorPresent.ToString("N0");
                    string formattedFut9 = ValorFuturo.ToString("N0");
                    Resultados.Add(new
                      {
                        ValorPresent = "$ " + formattedPresent9,
                        ValorFuturo = "$ " + formattedFut9,
                        Periodo = Periodo,
                        Tasa = Tasa
                      });
                       dgvIntCompIn.DataSource = null;
                      dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Mensual") || cmbbInteres.Equals("Mensual"))
                    {
                      Tasa = Math.Pow(ValorFuturo / ValorPresent, 1 / Periodo) - 1;
                    string formattedPresent0 = ValorPresent.ToString("N0");
                    string formattedFut0= ValorFuturo.ToString("N0");
                    Resultados.Add(new
                      {
                        ValorPresent= "$ " + formattedPresent0,
                        ValorFuturo = "$ " + formattedFut0,
                        Periodo = Periodo,
                        Tasa = Tasa
                      });
                       dgvIntCompIn.DataSource = null;
                      dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Semestral") || cmbbInteres.Equals("Mensual"))
                    {
                      Tasa = Math.Pow(ValorFuturo / ValorPresent, 1 / (Periodo * 6)) - 1;
                    string formattedPresent11 = ValorPresent.ToString("N0");
                    string formattedFut11 = ValorFuturo.ToString("N0");
                    Resultados.Add(new
                      {
                       ValorPresent = "$ " + formattedPresent11,
                       ValorFuturo = "$ " + formattedFut11,
                        Periodo = Periodo,
                        Tasa = Tasa
                      });
                       dgvIntCompIn.DataSource = null;
                      dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Trimestral") || cmbbInteres.Equals("Mensual"))
                    {
                     Tasa = Math.Pow(ValorFuturo / ValorPresent, 1 / (Periodo * 12)) - 1;
                    string formattedPresent12 = ValorPresent.ToString("N0");
                    string formattedFut12 = ValorFuturo.ToString("N0");
                    Resultados.Add(new
                     {
                        ValorPresent = "$ " + formattedPresent12,
                        ValorFuturo = "$ " + formattedFut12,
                        Periodo = Periodo,
                        Tasa = Tasa
                     });
                     dgvIntCompIn.DataSource = null;
                     dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Anual") || cmbbInteres.Equals("Trimestral"))
                    {
                      Tasa = Math.Pow(ValorFuturo / ValorPresent, 1 / (Periodo * 4)) - 1;
                    string formattedPresent13 = ValorPresent.ToString("N0");
                    string formattedFut13 = ValorFuturo.ToString("N0");
                    Resultados.Add(new
                      {
                       ValorPresent = "$ " + formattedPresent13,
                       ValorFuturo = "$ " + formattedFut13,
                        Periodo = Periodo,
                        Tasa = Tasa
                      });
                       dgvIntCompIn.DataSource = null;
                      dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                     else if (cmbPeriodoI.SelectedItem.Equals("Mensual") || cmbbInteres.Equals("Trimestral"))
                     {
                      Tasa = Math.Pow(ValorFuturo / ValorPresent, 1 / (Periodo / 3)) - 1;
                    string formattedPresent14 = ValorPresent.ToString("N0");
                    string formattedFut14 = ValorFuturo.ToString("N0");
                    Resultados.Add(new
                      {
                        ValorPresent = "$ " + formattedPresent14,
                        ValorFuturo = "$ " + formattedFut14,
                        Periodo = Periodo,
                        Tasa = Tasa
                      });
                       dgvIntCompIn.DataSource = null;
                      dgvIntCompIn.DataSource = Resultados.ToList();

                     }
                     else if (cmbPeriodoI.SelectedItem.Equals("Semestral") || cmbbInteres.Equals("Trimestral"))
                     {
                      Tasa = Math.Pow(ValorFuturo / ValorPresent, 1 / (Periodo * 2)) - 1;
                    string formattedPresent15 = ValorPresent.ToString("N0");
                    string formattedFut15 = ValorFuturo.ToString("N0");
                    Resultados.Add(new
                      {
                        ValorPresent = "$ " + formattedPresent15,
                        ValorFuturo = "$ " + formattedFut15,
                        Periodo = Periodo,
                        Tasa = Tasa
                      });
                       dgvIntCompIn.DataSource = null;
                      dgvIntCompIn.DataSource = Resultados.ToList();

                     }
                     else if (cmbPeriodoI.SelectedItem.Equals("Trimestral") || cmbbInteres.Equals("Trimestral"))
                     {
                      Tasa = Math.Pow(ValorFuturo / ValorPresent, 1 / (Periodo * 4)) - 1;
                    string formattedPresent16 = ValorPresent.ToString("N0");
                    string formattedFut16 = ValorFuturo.ToString("N0");
                    Resultados.Add(new
                      {
                       ValorPresent = "$ " + formattedPresent16,
                       ValorFuturo = "$ " + formattedFut16,
                        Periodo = Periodo,
                        Tasa = Tasa
                      });
                       dgvIntCompIn.DataSource = null;
                      dgvIntCompIn.DataSource = Resultados.ToList();

                     }

            }
            catch (FormatException x)
            {

                MessageBox.Show("Rellene los campos necesarios " + x);
            }

        }

        //private void txtValorFuturoI_TextChanged(object sender, EventArgs e)
        //{
        //}

        private void txtValorFuturoI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
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
            dgvIntCompIn.DataSource = null;
            dgvIntCompIn.Rows.Clear();
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
            dgvIntCompP.DataSource = null;
            dgvIntCompP.Rows.Clear();
        }
        private List<object> ResultadosPeriodo = new List<object>();
        private void btnCalcularN_Click(object sender, EventArgs e)
        {
            double ValorFut, ValorPresente;
            double tasaint = 0, Periodo,i1,i2;
            if (rbdSicapiP.Checked == true)
            {
                try
                {
                    ValorFut = Convert.ToDouble(txtValorFuturoN.Text);
                    ValorPresente = Convert.ToDouble(txtValorPresenteN.Text);
                    i2 = Convert.ToDouble(txtTasaInteresN.Text);
                  

                    if (cmbInteresN.SelectedItem != null)
                    {

                        if (cmbInteresN.SelectedItem.Equals("Anual"))
                        {
                            tasaint = i2 / 100; //  Esto pasar el valor del textob a decimal. Ejemplo: Si meto 5, pasa a 0.05
                            double Numerador = Math.Log(ValorFut / ValorPresente);
                            double Denominador = Math.Log(1 + tasaint);
                            Periodo = Math.Round(Numerador / Denominador);
                            string formattedPres1 = ValorPresente.ToString("N0");
                            string formattedFut1 = ValorFut.ToString("N0");
                            ResultadosPeriodo.Add(new
                            {
                                ValorPresente = "$ " + formattedPres1,
                                ValorFut = "$ " + formattedFut1,
                                TasaInteres = tasaint,
                                Periodo = Periodo,
                            });
                            dgvIntCompP.DataSource = null;
                            dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                        }
                        else if (cmbInteresN.SelectedItem.Equals("Semestral"))
                        {
                           
                            i1 = i2 / 100; // Esto pasar el valor del textob a decimal. Ejemplo: Si meto 5, pasa a 0.05
                            tasaint = i1 / 2; // Una vez ya pasado a decimal, corvertimos a Semestres. Ejemplo: 0.05 pasa a 0.025
                            double Numerador = Math.Log(ValorFut / ValorPresente);
                            double Denominador = Math.Log(1 + tasaint);
                            Periodo = Math.Round(Numerador / Denominador);
                            string formattedPres = ValorPresente.ToString("N0");
                            string formattedFut = ValorFut.ToString("N0");
                            ResultadosPeriodo.Add(new
                            {
                                ValorPresente = "$ " + formattedPres,
                                ValorFut = "$ " + formattedFut,
                                TasaInteres = tasaint,
                                Periodo = Periodo

                            });
                            dgvIntCompP.DataSource = null;
                            dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                        }
                        else if (cmbInteresN.SelectedItem.Equals("Trimestral"))
                        {
                           
                            i1 = i2 / 100; // Esto pasar el valor del textob a decimal. Ejemplo: Si meto 5, pasa a 0.05
                            tasaint = i1 / 4; // Una vez ya pasado a decimal, corvertimos a trimestres. Ejemplo: 0.05 pasa a 0.125
                            double Numerador = Math.Log(ValorFut / ValorPresente);
                            double Denominador = Math.Log(1 + tasaint);
                            Periodo = Math.Round(Numerador / Denominador);
                            string formattedPres2 = ValorPresente.ToString("N0");
                            string formattedFut2 = ValorFut.ToString("N0");
                            ResultadosPeriodo.Add(new
                            {
                                ValorPresente = "$ " + formattedPres2,
                                ValorFut = "$ " + formattedFut2,
                                TasaInteres = tasaint,
                                Periodo = Periodo
                            });
                            dgvIntCompP.DataSource = null;
                            dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                        }
                        else if (cmbInteresN.SelectedItem.Equals("Mensual"))
                        {

                            i1 = i2 / 100; // Esto pasar el valor del textob a decimal. Ejemplo: Si meto 5, pasa a 0.05
                            tasaint = i1 / 12; // Una vez ya pasado a decimal, corvertimos a Mensual. Ejemplo: 0.05 pasa a 0.00416666666
                            double Numerador = Math.Log(ValorFut / ValorPresente);
                            double Denominador = Math.Log(1 + tasaint);
                            Periodo = Math.Round(Numerador / Denominador);
                            string formattedPres3 = ValorPresente.ToString("N0");
                            string formattedFut3 = ValorFut.ToString("N0");
                            ResultadosPeriodo.Add(new
                            {
                                ValorPresente = "$ " + formattedPres3,
                                ValorFut = "$ " + formattedFut3,
                                TasaInteres = tasaint,
                                Periodo = Periodo

                            });
                            dgvIntCompP.DataSource = null;
                            dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                        }
                    }
                }
                catch (FormatException x)
                {

                    MessageBox.Show("Rellene los campos necesarios " + x);
                }
            }
            else if (rbdNocapiP.Checked == true) 
            {
                ValorFut = Convert.ToDouble(txtValorFuturoN.Text);
                ValorPresente = Convert.ToDouble(txtValorPresenteN.Text);
                i2 = Convert.ToDouble(txtTasaInteresN.Text);

                if (cmbInteresN.SelectedItem.Equals("Anual"))
                {
                    tasaint = i2 / 100; //  Esto pasar el valor del textob a decimal. Ejemplo: Si meto 5, pasa a 0.05
                    double Numerador = Math.Log(ValorFut / ValorPresente);
                    double Denominador = Math.Log(1 + tasaint);
                    Periodo = Math.Round(Numerador / Denominador);
                    string formattedPres1 = ValorPresente.ToString("N0");
                    string formattedFut1 = ValorFut.ToString("N0");
                    ResultadosPeriodo.Add(new
                    {
                        ValorPresente = "$ " + formattedPres1,
                        ValorFut = "$ " + formattedFut1,
                        TasaInteres = tasaint,
                        Periodo = Periodo,
                    });
                    dgvIntCompP.DataSource = null;
                    dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                }
                else if (cmbInteresN.SelectedItem.Equals("Semestral"))
                {
                    /*baselog = 1 + tasaint;
                    baseF_P = Math.Log(ValorFut / ValorPresente);
                    Periodo = ((int)(baseF_P / Math.Log(baselog))) / 2;
                    */
                    i1 = i2 / 100; // Esto pasar el valor del textob a decimal. Ejemplo: Si meto 5, pasa a 0.05
                    tasaint = i1; // Una vez ya pasado a decimal, corvertimos a Semestres. Ejemplo: 0.05 pasa a 0.025
                    double Numerador = Math.Log(ValorFut / ValorPresente);
                    double Denominador = Math.Log(1 + tasaint);
                    Periodo = Math.Round(Numerador / Denominador);
                    string formattedPres = ValorPresente.ToString("N0");
                    string formattedFut = ValorFut.ToString("N0");
                    ResultadosPeriodo.Add(new
                    {
                        ValorPresente = "$ " + formattedPres,
                        ValorFut = "$ " + formattedFut,
                        TasaInteres = tasaint,
                        Periodo = Periodo

                    });
                    dgvIntCompP.DataSource = null;
                    dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                }
                else if (cmbInteresN.SelectedItem.Equals("Trimestral"))
                {
                    /*baselog = 1 + tasaint;
                    baseF_P = Math.Log(ValorFut / ValorPresente);
                    Periodo = ((int)(baseF_P / Math.Log(baselog))) /4;
                    */
                    i1 = i2 / 100; // Esto pasar el valor del textob a decimal. Ejemplo: Si meto 5, pasa a 0.05
                    tasaint = i1; // Una vez ya pasado a decimal, corvertimos a trimestres. Ejemplo: 0.05 pasa a 0.125
                    double Numerador = Math.Log(ValorFut / ValorPresente);
                    double Denominador = Math.Log(1 + tasaint);
                    Periodo = Math.Round(Numerador / Denominador);
                    string formattedPres2 = ValorPresente.ToString("N0");
                    string formattedFut2 = ValorFut.ToString("N0");
                    ResultadosPeriodo.Add(new
                    {
                        ValorPresente = "$ " + formattedPres2,
                        ValorFut = "$ " + formattedFut2,
                        TasaInteres = tasaint,
                        Periodo = Periodo
                    });
                    dgvIntCompP.DataSource = null;
                    dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                }
                else if (cmbInteresN.SelectedItem.Equals("Mensual"))
                {
                    /*baselog = 1 + tasaint;
                    baseF_P = Math.Log(ValorFut / ValorPresente);
                    Periodo = ((int)(baseF_P / Math.Log(baselog))) / 12;
                    */
                    i1 = i2 / 100; // Esto pasar el valor del textob a decimal. Ejemplo: Si meto 5, pasa a 0.05
                    tasaint = i1; // Una vez ya pasado a decimal, corvertimos a Mensual. Ejemplo: 0.05 pasa a 0.00416666666
                    double Numerador = Math.Log(ValorFut / ValorPresente);
                    double Denominador = Math.Log(1 + tasaint);
                    Periodo = Math.Round(Numerador / Denominador);
                    string formattedPres3 = ValorPresente.ToString("N0");
                    string formattedFut3 = ValorFut.ToString("N0");
                    ResultadosPeriodo.Add(new
                    {
                        ValorPresente = "$ " + formattedPres3,
                        ValorFut = "$ " + formattedFut3,
                        TasaInteres = tasaint,
                        Periodo = Periodo

                    });
                    dgvIntCompP.DataSource = null;
                    dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                }

            }
         }
        
        private List<object> resultados = new List<object>();
        private void btnCalcularF_Click(object sender, EventArgs e)
        {
            //SI en dado caso que quiera capitalizarlo
            if (rdbSi.Checked == true)
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
                        if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Años"))
                        {
                            i = i1 / 100;
                            f = p * Math.Pow((1 + i), n1);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ "+ formattedP, Interes = i, Periodo = n1, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();

                        }

                        else if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100);
                            n = n1 / 2;
                            f = p * Math.Pow((1 + i), n);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                        {
                            i = i1 / 100;
                            n = n1 / 4;
                            f = p * Math.Pow((1 + i), n);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                        {
                            i = i1 / 100;
                            n = n1 / 12;
                            f = p * Math.Pow((1 + i), n);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        // Cuando tenemos interes semestral con los diferentes periodos
                        else if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Años"))
                        {
                            i = (i1 / 100) / 2;
                            n = n1 * 2;
                            f = p * Math.Pow((1 + i), n);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100) / 2;
                            f = p * Math.Pow((1 + i), n1);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n1, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                        {
                            i = (i1 / 100) / 2;
                            n = n1 * 2;
                            f = p * Math.Pow((1 + i), n);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                        {
                            i = (i1 / 100) / 2;
                            n = n1 / 6;
                            f = p * Math.Pow((1 + i), n);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        // Cuando tenemos interes trimestral con los diferentes periodos
                        else if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Años"))
                        {
                            i = (i1 / 100) / 4;
                            n = n1 * 4;
                            f = p * Math.Pow((1 + i), n);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100) / 4;
                            n = n1 * 2;
                            f = p * Math.Pow((1 + i), n);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                        {
                            i = (i1 / 100) / 4;
                            f = p * Math.Pow((1 + i), n1);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n1, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                        {
                            i = (i1 / 100) / 4;
                            n = n1 / 3;
                            f = p * Math.Pow((1 + i), n);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        // Cuando tenemos interes mensual con los diferentes periodos
                        else if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Años"))
                        {
                            i = (i1 / 100) / 12;
                            n = n1 * 12;
                            f = p * Math.Pow((1 + i), n);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100) / 12;
                            n = n1 * 6;
                            f = p * Math.Pow((1 + i), n);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                        {
                            i = (i1 / 100) / 12;
                            n = n1 * 3;
                            f = p * Math.Pow((1 + i), n);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                        {
                            i = (i1 / 100) / 12;
                            f = p * Math.Pow((1 + i), n1);
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultados.Add(new { Presente = "C$ " + formattedP, Interes = i, Periodo = n1, Futuro = "C$ " + formattedF });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                    }
                }
                catch (FormatException x)
                {

                    MessageBox.Show("Rellene los campos necasarios");
                }
            } // NO en dado caso que no quiera capitalizarlo
            else if(rdbNo.Checked == true)
            {
                 double Pno = double.Parse(txtValorPresenteF.Text);
                double Ino = double.Parse(txtTasaInteresF.Text);
                double Nno = double.Parse(txtPeriodoF.Text);
                double Fo;

                Fo = Pno * Math.Pow((1 + Ino/100), Nno);
                string formattedP = Pno.ToString("N0");
                string formattedF = Fo.ToString("N0");

                resultados.Add(new { Presente = "C$ " + formattedP, Interes = Ino, Periodo = Nno, Futuro = "C$ " + formattedF });

                dgvResultadosFU.DataSource = null;
                dgvResultadosFU.DataSource = resultados.ToList();

            }
            

        }

        private List<object> resultadosP = new List<object>();
        private void btnCalcularP_Click(object sender, EventArgs e)
        {
            // SI en dado caso que quiera capitalizar
            if(rdbSi1.Checked == true)
            {
                double p, i, n, f;
                double i1, n1, i2;

                try
                {
                    f = double.Parse(txtValorFuturoP.Text);
                    i1 = double.Parse(txtTasaInteresP.Text);
                    n1 = double.Parse(txtPeriodoP.Text);

                    if (cmbInteresP.SelectedItem != null && cmbPeriodoP.SelectedItem != null)
                    {
                        if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Años"))
                        {
                            i = i1 / 100;
                            p = f / (Math.Pow((1 + i), n1));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n1, Presente = "C$ " + formattedF });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();

                        }

                        else if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                        {
                            i = i1 / 100;
                            n = n1 / 2;
                            p = f / (Math.Pow((1 + i), n));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                        {
                            i = i1 / 100;
                            n = n1 / 4;
                            p = f / (Math.Pow((1 + i), n));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                        {
                            i = i1 / 100;
                            n = n1 / 12;
                            p = f / (Math.Pow((1 + i), n));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        // Cuando tenemos interes semestral con los diferentes periodos
                        else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Años"))
                        {
                            i = (i1 / 100) / 2;
                            n = n1 * 2;
                            p = f / (Math.Pow((1 + i), n));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100) / 2;
                            p = f / (Math.Pow((1 + i), n1));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");

                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n1, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                        {
                            i = (i1 / 100) / 2;
                            n = n1 * 2;
                            p = f / (Math.Pow((1 + i), n));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                        {
                            i = (i1 / 100) / 2;
                            n = n1 / 6;
                            p = f / (Math.Pow((1 + i), n));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        // Cuando tenemos interes trimestral con los diferentes periodos
                        else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Años"))
                        {
                            i = (i1 / 100) / 4;
                            n = n1 * 4;
                            p = f / (Math.Pow((1 + i), n));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100) / 4;
                            n = n1 * 2;
                            p = f / (Math.Pow((1 + i), n));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                        {
                            i = (i1 / 100) / 4;
                            p = f / (Math.Pow((1 + i), n1));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");

                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n1, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                        {
                            i = (i1 / 100) / 4;
                            n = n1 / 3;
                            p = f / (Math.Pow((1 + i), n));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        // Cuando tenemos interes mensual con los diferentes periodos
                        else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Años"))
                        {
                            i = (i1 / 100) / 12;
                            n = n1 * 12;
                            p = f / (Math.Pow((1 + i), n));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100) / 12;
                            n = n1 * 6;
                            p = f / (Math.Pow((1 + i), n));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                        {
                            i = (i1 / 100) / 12;
                            n = n1 * 3;
                            p = f / (Math.Pow((1 + i), n));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");


                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                        {
                            i = (i1 / 100) / 12;
                            p = f / (Math.Pow((1 + i), n1));
                            string formattedP = p.ToString("N0");
                            string formattedF = f.ToString("N0");

                            resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = i, Periodo = n1, Presente = "C$ " + formattedP });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultadosP.ToList();
                        }

                    }
                }
                catch (FormatException x)
                {

                    MessageBox.Show("Rellene los campos necasarios");
                }
            } // NO en dado caso que no desea capitalizar
            else if(rdbNo1.Checked == true)
            {
                double Fno = double.Parse(txtValorFuturoP.Text);
                double Ino = double.Parse(txtTasaInteresP.Text);
                double Nno = double.Parse(txtPeriodoP.Text);
                double P;
                double Int = Ino / 100;

                P = Fno / (Math.Pow((1 + Int), Nno));
                string formattedP = P.ToString("N0");
                string formattedF = Fno.ToString("N0");


                resultadosP.Add(new { Futuro = "C$ " + formattedF, Interes = Int, Periodo = Nno, Presente = "C$ " + formattedP });

                dgvResultadosP.DataSource = null;
                dgvResultadosP.DataSource = resultadosP.ToList();
            }

        }

        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            txtValorFuturoP.Clear();
            txtTasaInteresP.Clear();
            txtPeriodoP.Clear();
            dgvResultadosP.DataSource = null;
            dgvResultadosP.Rows.Clear();
            txtValorFuturoP.Focus();
        }
    }
}

