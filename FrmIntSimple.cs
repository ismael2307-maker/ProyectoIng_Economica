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
        public List<InteresSimpleF> Fs = new List<InteresSimpleF> ();
        public List<InteresSimpleP> Ps = new List<InteresSimpleP> ();
        public List<InteresSimpleI> Is = new List<InteresSimpleI> ();
        public List<InteresSimpleN> Ns = new List<InteresSimpleN> ();
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
            try
            {
                int ValorPresenteFu = Convert.ToInt32(txtValorPresenteF.Text);
                double TasaInteresFu = Convert.ToDouble(txtTasaInteresF.Text);
                int PeriodoFu = Convert.ToInt32(txtPeriodoF.Text);
                double Futuro = ValorPresenteFu * (1 + (TasaInteresFu * PeriodoFu));
                if (cmbInteresSimple.SelectedItem != null || cmbPeriodoSimple.SelectedItem != null)
                {
                    if (cmbInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoSimple.SelectedItem.Equals("Meses"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu / 12)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoSimple.SelectedItem.Equals("Años"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu / 2)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu / 4)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Mensual") && cmbPeriodoSimple.SelectedItem.Equals("Años"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 12)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Mensual") && cmbPeriodoSimple.SelectedItem.Equals("Meses"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Mensual") && cmbPeriodoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 6)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Mensual") && cmbPeriodoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 3)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Semestral") && cmbPeriodoSimple.SelectedItem.Equals("Años"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 2)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Semestral") && cmbPeriodoSimple.SelectedItem.Equals("Meses"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu / 6)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Semestral") && cmbPeriodoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Semestral") && cmbPeriodoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu / 2)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoSimple.SelectedItem.Equals("Años"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 4)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoSimple.SelectedItem.Equals("Meses"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu / 3)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 2)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 2)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
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
        private void btnCalcularP_Click(object sender, EventArgs e)
        {
            try 
            {
                int ValorFuturoPe = Convert.ToInt32(txtValorFuturoP.Text);
                double TasaInteresPe = Convert.ToDouble(txtTasaInteresP.Text);
                int PeriodoPe = Convert.ToInt32(txtPeriodoP.Text);
                double Presente = ValorFuturoPe / 1 + (TasaInteresPe * PeriodoPe);

                if (cmbInteresFuturoSimple.SelectedItem != null || cmbPeriodoFuturoSimple.SelectedItem !=null)
                {
                    if(cmbInteresFuturoSimple.SelectedItem.Equals("Anual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Anual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Meses"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe / 12)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Anual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe / 2)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Anual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe / 4)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Mensual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 12)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Mensual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Meses"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Mensual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 6)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Mensual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 3)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Semestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 2)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Semestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Meses"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe / 6)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Semestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 2)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Semestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe / 2)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 4)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Meses"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe / 3)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 2)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
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
        private void btnCalcularI_Click(object sender, EventArgs e)
        {
            try
            {
                int ValorFuturoIn = Convert.ToInt32(txtValorFuturoI.Text);
                int ValorPresenteIn = Convert.ToInt32(txtValorPresenteI.Text);
                int PeriodoIn = Convert.ToInt32(txtPeriodoI.Text);
                double TasaInteres = ValorFuturoIn / ValorPresenteIn - 1 / PeriodoIn;

                if (cmbTipoTasa.SelectedItem != null || cmbPeriodoInteresSimple != null) 
                {
                    if (cmbTipoTasa.SelectedItem.Equals("Anual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Meses"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / (PeriodoIn / 12.0),
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Anual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Años"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / PeriodoIn,
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Anual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Semestres"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / (PeriodoIn / 2),
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Anual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / (PeriodoIn / 4),
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Mensual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Años"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / (PeriodoIn * 12),
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Mensual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Meses"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / PeriodoIn,
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Mensual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Semestres"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / (PeriodoIn * 6),
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Mensual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / (PeriodoIn * 3),
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Semestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Años"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / (PeriodoIn * 2),
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;
                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Semestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Meses"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / (PeriodoIn / 6),
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Semestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Semestres"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / PeriodoIn,
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Semestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / (PeriodoIn / 2),
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Trimestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Años"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / (PeriodoIn * 4),
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Trimestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Meses"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / (PeriodoIn / 3),
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Trimestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Semestres"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / (PeriodoIn * 2),
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;

                    }
                    else if (cmbTipoTasa.SelectedItem.Equals("Trimestral") && cmbPeriodoInteresSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Is.Add(new InteresSimpleI
                        {
                            ValorFuturoI = Convert.ToInt32(txtValorFuturoI.Text),
                            ValorPresenteI = Convert.ToInt32(txtValorPresenteI.Text),
                            PeriodoI = Convert.ToInt32(txtPeriodoI.Text),
                            TasaInteres = ((double)ValorFuturoIn / ValorPresenteIn - 1) / PeriodoIn,
                        });
                        dgvResultadosI.DataSource = null;
                        dgvResultadosI.DataSource = Is;

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

        private void btnCalcularN_Click(object sender, EventArgs e)
        {
            try 
            {
                int ValorFuturoNe = Convert.ToInt32(txtValorFuturoN.Text);
                int ValorPresenteNe = Convert.ToInt32(txtValorPresenteN.Text);
                double TasaInteresNe = Convert.ToDouble(txtTasaInteresN.Text);
                int Periodo = (int)((ValorFuturoNe / ValorPresenteNe - 1) / (TasaInteresNe));

                Ns.Add(new InteresSimpleN
                {
                    ValorFuturoN = Convert.ToInt32(txtValorFuturoN.Text),
                    ValorPresenteN = Convert.ToInt32(txtValorPresenteN.Text),
                    TasaInteresN = Convert.ToDouble(txtTasaInteresN.Text),
                    Periodo = (ValorFuturoNe - ValorPresenteNe) / (ValorPresenteNe * (TasaInteresNe / 100)),
                });
                dgvResultadosN.DataSource = null;
                dgvResultadosN.DataSource = Ns;

            }catch(FormatException x)
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
    }
}
