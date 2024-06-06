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
            txtValorPresenteF.Text = "";
            txtTasaInteresF.Text = "";
            txtPeriodoF.Text = "";
        }
        private List<object> Resultados = new  List<object>();
        private void btnCalcularI_Click(object sender, EventArgs e)
        {
            int ValorPresent, ValorFuturo,Periodo;
            double Tasa, IAnual, IMensual,ITrimestral,ISemestral;

            try
            {
               ValorFuturo = Convert.ToInt32(txtValorFuturoI.Text);
               ValorPresent = Convert.ToInt32(txtValorPresenteI.Text);
               Periodo = Convert.ToInt32(txtPeriodoI.Text);
               Tasa = Convert.ToDouble(txtPeriodoI.Text);
               IAnual = Convert.ToDouble(txtPeriodoI.Text);
               IMensual = Convert.ToDouble(txtPeriodoI.Text);
               ISemestral = Convert.ToDouble(txtPeriodoI.Text);
               ITrimestral = Convert.ToDouble(txtPeriodoI.Text);

                if (cmbPeriodoI.SelectedItem != null)
                {
                    if (cmbPeriodoI.SelectedItem.Equals("Anual"))
                    {
                        Tasa = Math.Sqrt(ValorFuturo / ValorPresent) - 1;
                        Resultados.Add(new
                        {
                            ValorPresente = ValorPresent,
                            ValorFut = ValorFuturo,
                            Periodo = Periodo,
                            Tasa = Tasa
                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Mensual"))
                    {
                        IAnual = Math.Sqrt(ValorFuturo / ValorPresent) - 1;
                        IMensual = Math.Pow(1 + IAnual, 1.0 / 12) - 1;
                        Resultados.Add(new
                        {
                            ValorPresente = ValorPresent,
                            ValorFut = ValorFuturo,
                            Periodo = Periodo,
                            Tasa = Tasa

                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = Resultados.ToList();

                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Semestral"))
                    {
                        IAnual = Math.Sqrt(ValorFuturo/ ValorPresent) - 1;
                        ISemestral = IAnual * 0.5;
                        Resultados.Add(new 
                        {
                            ValorPresente = ValorPresent,
                            ValorFut = ValorFuturo,
                            Periodo = Periodo,
                            Tasa = Tasa
                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = Resultados.ToList();
                        
                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Trimestral"))
                    {
                        IAnual = Math.Sqrt(ValorFuturo / ValorPresent) - 1;
                        ITrimestral = IAnual * 0.25;
                        Resultados.Add(new 
                        {
                            ValorPresente = ValorPresent,
                            ValorFut = ValorFuturo,
                            Periodo = Periodo,
                            Tasa = Tasa

                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = Resultados.ToList();
                     

                    }

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
        private List<object> ResultadosPeriodo = new List<object>();
        private void btnCalcularN_Click(object sender, EventArgs e)
        {
            double ValorFut, ValorPresente;
            double tasaint, periodo, baselog, baseF_P;
            try
            {
                ValorFut = Convert.ToDouble(txtValorFuturoP.Text);
                ValorPresente = Convert.ToDouble(txtValorPresenteN.Text);
                tasaint = Convert.ToDouble(txtTasaInteresN.Text);
                 periodo= Convert.ToDouble(txtPeriodoP.Text);
                baselog= Convert.ToDouble(txtPeriodoP.Text);
                baseF_P = Convert.ToDouble(txtPeriodoP.Text);


                if (cmbInteresN.SelectedItem != null)
                {
                    baselog = 1 + tasaint;
                    baseF_P = Math.Log(ValorFut / ValorPresente);
                    periodo = ((int)(baseF_P/ Math.Log(baselog)));
                    if (cmbInteresN.SelectedItem.Equals("Anual"))
                    {
                        ResultadosPeriodo.Add(new
                        {
                            ValorFuturo = ValorFut,
                            ValorPresente = ValorPresente,
                            TasaInteres = tasaint,
                            Periodo = periodo
                        });
                        dgvIntCompP.DataSource = null;
                        dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                    }
                    else if (cmbInteresN.SelectedItem.Equals("Semestral"))
                    {
                        baselog = 1 + tasaint;
                        baseF_P = Math.Log(ValorFut / ValorPresente);
                        periodo = ((int)(baseF_P / Math.Log(baselog))) / 2;
                        ResultadosPeriodo.Add( new 
                        {
                            ValorFuturo = ValorFut,
                            ValorPresente = ValorPresente,
                            TasaInteres = tasaint,
                            Periodo = periodo

                        });
                        dgvIntCompP.DataSource = null;
                        dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                    }
                    else if (cmbInteresN.SelectedItem.Equals("Trimestral"))
                    {
                        baselog = 1 + tasaint;
                        baseF_P = Math.Log(ValorFut / ValorPresente);
                        periodo = ((int)(baseF_P / Math.Log(baselog))) /4;
                        ResultadosPeriodo.Add(new 
                        {
                            ValorFuturo = ValorFut,
                            ValorPresente = ValorPresente,
                            TasaInteres = tasaint,
                            Periodo = periodo
                        });
                        dgvIntCompP.DataSource = null;
                        dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                    }
                    else if (cmbInteresN.SelectedItem.Equals("Mensual"))
                    {
                        baselog = 1 + tasaint;
                        baseF_P = Math.Log(ValorFut / ValorPresente);
                        periodo = ((int)(baseF_P / Math.Log(baselog))) / 12;
                        ResultadosPeriodo.Add(new 
                        {
                            ValorFuturo = ValorFut,
                            ValorPresente = ValorPresente,
                            TasaInteres = tasaint,
                            Periodo = periodo

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
        
        private List<object> resultados = new List<object>();
        private void btnCalcularF_Click(object sender, EventArgs e)
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

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n1, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();

                    }

                    else if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                    {
                        i = i1 / 100;
                        n = n1 / 2;
                        f = p * Math.Pow((1 + i), n);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                    {
                        i = i1 / 100;
                        n = n1 / 4;
                        f = p * Math.Pow((1 + i), n);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1 / 12;
                        f = p * Math.Pow((1 + i), n);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    // Cuando tenemos interes semestral con los diferentes periodos
                    else if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1 * 2;
                        f = p * Math.Pow((1 + i), n);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                    {
                        i = i1 / 100;
                        f = p * Math.Pow((1 + i), n1);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n1, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                    {
                        i = i1 / 100;
                        n = n1 / 2;
                        f = p * Math.Pow((1 + i), n);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1 / 6;
                        f = p * Math.Pow((1 + i), n);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    // Cuando tenemos interes trimestral con los diferentes periodos
                    else if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1 * 4;
                        f = p * Math.Pow((1 + i), n);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                    {
                        i = i1 / 100;
                        n = n1 * 2;
                        f = p * Math.Pow((1 + i), n);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                    {
                        i = i1 / 100;
                        f = p * Math.Pow((1 + i), n1);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n1, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1 / 3;
                        f = p * Math.Pow((1 + i), n);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    // Cuando tenemos interes mensual con los diferentes periodos
                    else if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1 * 12;
                        f = p * Math.Pow((1 + i), n);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                    {
                        i = i1 / 100;
                        n = n1 * 6;
                        f = p * Math.Pow((1 + i), n);

                       
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                    {
                        i = i1 / 100;
                        n = n1 * 3;
                        f = p * Math.Pow((1 + i), n);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        f = p * Math.Pow((1 + i), n1);

                        
                        resultados.Add(new { Presente = p, Interes = i, Periodo = n1, Futuro = f });

                        dgvResultadosFU.DataSource = null;
                        dgvResultadosFU.DataSource = resultados.ToList();
                    }

                }
            }
            catch (FormatException x)
            {

                MessageBox.Show("Rellene los campos necasarios");
            }

        }

        private void btnCalcularP_Click(object sender, EventArgs e)
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


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n1, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();

                    }

                    else if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                    {
                        i = i1 / 100;
                        n = n1 / 2;
                        p = f / (Math.Pow((1 + i), n));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                    {
                        i = i1 / 100;
                        n = n1 / 4;
                        p = f / (Math.Pow((1 + i), n));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                    if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1 / 12;
                        p = f / (Math.Pow((1 + i), n));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                    // Cuando tenemos interes semestral con los diferentes periodos
                    else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1 * 2;
                        p = f / (Math.Pow((1 + i), n));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP  .DataSource = resultados.ToList();
                    }

                    else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                    {
                        i = i1 / 100;
                        p = f / (Math.Pow((1 + i), n1));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n1, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                    {
                        i = i1 / 100;
                        n = n1 / 2;
                        p = f / (Math.Pow((1 + i), n));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP                      .DataSource = resultados.ToList();
                    }

                    else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1 / 6;
                        p = f / (Math.Pow((1 + i), n));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                    // Cuando tenemos interes trimestral con los diferentes periodos
                    else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1 * 4;
                        p = f / (Math.Pow((1 + i), n));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                    {
                        i = i1 / 100;
                        n = n1 * 2;
                        p = f / (Math.Pow((1 + i), n));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                    {
                        i = i1 / 100;
                        p = f / (Math.Pow((1 + i), n1));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n1, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1 / 3;
                        p = f / (Math.Pow((1 + i), n));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                    // Cuando tenemos interes mensual con los diferentes periodos
                    else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1 * 12;
                        p = f / (Math.Pow((1 + i), n));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                    {
                        i = i1 / 100;
                        n = n1 * 6;
                        p = f / (Math.Pow((1 + i), n));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                    {
                        i = i1 / 100;
                        n = n1 * 3;
                        p = f / (Math.Pow((1 + i), n));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                    else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        p = f / (Math.Pow((1 + i), n1));


                        resultados.Add(new { Futuro = f, Interes = i, Periodo = n1, Presente = p });

                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = resultados.ToList();
                    }

                }
            }
            catch (FormatException x)
            {

                MessageBox.Show("Rellene los campos necasarios");
            }

        }

        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            txtValorFuturoP.Clear();
            txtTasaInteresP.Clear();
            txtPeriodoP.Clear();
            txtValorFuturoP.Focus();
        }
    }
}

