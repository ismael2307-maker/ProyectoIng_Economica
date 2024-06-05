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
            
            try
            {
                int ValorFuturoCompI = Convert.ToInt32(txtValorFuturoI.Text);
                int ValorPresenteCompI = Convert.ToInt32(txtValorPresenteI.Text);
                int PeriodoCompI = Convert.ToInt32(txtPeriodoI.Text);
                double TasaInteresCompI = Convert.ToDouble(txtPeriodoI.Text);
                double IAnual = Convert.ToDouble(txtPeriodoI.Text);
                double IMensual = Convert.ToDouble(txtPeriodoI.Text);
                double ISemestral = Convert.ToDouble(txtPeriodoI.Text);
                double ITrimestral = Convert.ToDouble(txtPeriodoI.Text);

                if (cmbPeriodoI.SelectedItem != null)
                {
                    if (cmbPeriodoI.SelectedItem.Equals("Anual"))
                    {
                        IntCompI.Add(new InteresCompuestoI
                        {
                            ValorFuturoCompI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteCompI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoCompI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteresCompI = Math.Sqrt(ValorFuturoCompI / ValorPresenteCompI) - 1,
                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = IntCompI;
                        NoColumns();
                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Mensual"))
                    {
                        IntCompI.Add(new InteresCompuestoI
                        {

                            ValorFuturoCompI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteCompI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoCompI = Convert.ToInt32(txtPeriodoI.Text),
                            IAnual = Math.Sqrt(ValorFuturoCompI / ValorPresenteCompI) - 1,
                            IMensual = Math.Pow(1 + IAnual, 1.0 / 12) - 1,
                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = IntCompI;
                        NoColumns() ;
                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Semestral"))
                    {
                        IntCompI.Add(new InteresCompuestoI
                        {
                            ValorFuturoCompI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteCompI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoCompI = Convert.ToInt32(txtPeriodoI.Text),
                            IAnual = Math.Sqrt(ValorFuturoCompI / ValorPresenteCompI) - 1,
                            ISemestral = IAnual * 0.5,
                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = IntCompI;
                        NoColumns();
                    }
                    else if (cmbPeriodoI.SelectedItem.Equals("Trimestral"))
                    {
                        IntCompI.Add(new InteresCompuestoI
                        {

                            ValorFuturoCompI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteCompI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoCompI = Convert.ToInt32(txtPeriodoI.Text),
                            IAnual = Math.Sqrt(ValorFuturoCompI / ValorPresenteCompI) - 1,
                            ITrimestral = IAnual * 0.25,
                        });
                        dgvIntCompIn.DataSource = null;
                        dgvIntCompIn.DataSource = IntCompI;
                        NoColumns() ;

                    }

                }
            }
            catch (FormatException x)
            {

                MessageBox.Show("Rellene los campos necesarios " + x);
            }

        }

        private void NoColumns()
        {
            if (dgvIntCompIn.Columns.Contains("IMensual"))
            {
                dgvIntCompIn.Columns["IMensual"].Visible = false;
            }
            else if (dgvIntCompIn.Columns.Contains("IAnual"))
            {
                dgvIntCompIn.Columns["IAnual"].Visible = false;
            }
            else if (dgvIntCompIn.Columns.Contains("ISemestral"))
            {
                dgvIntCompIn.Columns["ISemestral"].Visible= false;
            }
            else if (dgvIntCompIn.Columns.Contains("ITrimestral"))
            {
                dgvIntCompIn.Columns["ITrimestral"].Visible = false;
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

        private void btnCalcularN_Click(object sender, EventArgs e)
        {
            try
            {
                int ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text);
                int ValorPresenteP = Convert.ToInt32(txtValorPresenteN.Text);
                double TasaInteresP = Convert.ToDouble(txtTasaInteresN.Text);
                double PeriodoP = Convert.ToDouble(txtPeriodoP.Text);
                double baseLog = Convert.ToDouble(txtPeriodoP.Text);
                double F_P = Convert.ToDouble(txtPeriodoP.Text);


                if (cmbInteresN.SelectedItem != null)
                {
                    if (cmbInteresN.SelectedItem.Equals("Anual"))
                    {
                        IntCompP.Add(new InteresCompuestoP
                        {
                            ValorFuturoCompP = Convert.ToInt32(txtValorFuturoP.Text),
                            ValorPresenteCompP = Convert.ToInt32(txtValorPresenteN.Text),
                            TasaInteresCompP = Convert.ToDouble(txtTasaInteresN.Text),
                            baseLog = 1 + TasaInteresP,
                            F_P = Math.Log(ValorFuturoP / ValorPresenteP),
                            PeriodoCompP = ((int)(F_P / Math.Log(baseLog))),
                        });
                        dgvIntCompP.DataSource = null;
                        dgvIntCompP.DataSource = IntCompP;
                    }
                    else if (cmbInteresN.SelectedItem.Equals("Semestral"))
                    {
                        IntCompP.Add(new InteresCompuestoP
                        {

                            ValorFuturoCompP = Convert.ToInt32(txtValorFuturoP.Text),
                            ValorPresenteCompP = Convert.ToInt32(txtValorPresenteN.Text),
                            TasaInteresCompP = Convert.ToDouble(txtTasaInteresN.Text),
                            baseLog = 1 + TasaInteresP,
                            F_P = Math.Log(ValorFuturoP / ValorPresenteP),
                            PeriodoCompP = ((int)(F_P / Math.Log(baseLog))) / 2,
                        });
                        dgvIntCompP.DataSource = null;
                        dgvIntCompP.DataSource = IntCompP;
                    }
                    else if (cmbInteresN.SelectedItem.Equals("Trimestral"))
                    {
                        IntCompP.Add(new InteresCompuestoP
                        {

                            ValorFuturoCompP = Convert.ToInt32(txtValorFuturoP.Text),
                            ValorPresenteCompP = Convert.ToInt32(txtValorPresenteN.Text),
                            TasaInteresCompP = Convert.ToDouble(txtTasaInteresN.Text),
                            baseLog = 1 + TasaInteresP,
                            F_P = Math.Log(ValorFuturoP / ValorPresenteP),
                            PeriodoCompP = ((int)(F_P / Math.Log(baseLog))) / 4,
                        });
                        dgvIntCompP.DataSource = null;
                        dgvIntCompP.DataSource = IntCompP;
                    }
                    else if (cmbInteresN.SelectedItem.Equals("Mensual"))
                    {
                        IntCompP.Add(new InteresCompuestoP
                        {

                            ValorFuturoCompP = Convert.ToInt32(txtValorFuturoP.Text),
                            ValorPresenteCompP = Convert.ToInt32(txtValorPresenteN.Text),
                            TasaInteresCompP = Convert.ToDouble(txtTasaInteresN.Text),
                            baseLog = 1 + TasaInteresP,
                            F_P = Math.Log(ValorFuturoP / ValorPresenteP),
                            PeriodoCompP = ((int)(F_P / Math.Log(baseLog))) / 12,
                        });
                        dgvIntCompP.DataSource = null;
                        dgvIntCompP.DataSource = IntCompP;
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

