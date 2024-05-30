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
    public partial class FrmaAnualidadAnticipada : Form
    {
        public List<AnualidadAnticipidaP> Ap = new List<AnualidadAnticipidaP> ();
        public List<AnualidadAnticipadaF> Af = new List<AnualidadAnticipadaF> ();
        public List<AnualidadAnticipadaAP> AAp = new List<AnualidadAnticipadaAP> ();
        public List<AnualidadAnticipadaAF> AAF = new List<AnualidadAnticipadaAF> ();
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
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int AnualidadPresente = Convert.ToInt32(txtValorAnualidadPresente.Text);
                double TasaInteresPresente = Convert.ToDouble(txtInteresPresente.Text);
                int PeriodoPresente = Convert.ToInt32(txtPeriodoPresente.Text);
                double Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + TasaInteresPresente, PeriodoPresente - 1) - 1) / (TasaInteresPresente * Math.Pow(1 + TasaInteresPresente, PeriodoPresente - 1)));

                if (cmbInteresPresente.SelectedItem != null || cmbPeriodoPresente != null)
                {
                    if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), PeriodoPresente - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), PeriodoPresente - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Mensual"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente / 12) - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente / 12) - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente / 2) - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente / 2) - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente / 4) - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente / 4) - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    //Fin de anual 

                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente * 12) - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente * 12) - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), PeriodoPresente - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), PeriodoPresente - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente * 6) - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente * 6) - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente * 3) - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente * 3) - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    //Fin de interes Mensual
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente * 2) - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente * 2) - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente / 6) - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente / 6) - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), PeriodoPresente - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), PeriodoPresente - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente / 2) - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente / 2) - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    // Fin interes Semestral
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente * 4) - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente * 4) - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente / 3) - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente / 3) - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente * 2) - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), (PeriodoPresente * 2) - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {
                        Ap.Add(new AnualidadAnticipidaP
                        {
                            AnualidadP = Convert.ToInt32(txtValorAnualidadPresente.Text),
                            TasaInteresP = Convert.ToDouble(txtInteresPresente.Text),
                            PeriodoP = Convert.ToInt32(txtPeriodoPresente.Text),
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente / 100), PeriodoPresente  - 1) - 1) / ((TasaInteresPresente / 100) * Math.Pow(1 + (TasaInteresPresente / 100), PeriodoPresente - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }

                }
            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios " + x);
            }
        }

        //Fin presente

        private void btnCalcularFuturo_Click(object sender, EventArgs e)
        {
            int AnualidadFu = Convert.ToInt32(txtValorAnualidadFuturo.Text);
            double TasaInteresFu = Convert.ToDouble(txtTasaInteresFuturo.Text);
            int PeriodoFu = Convert.ToInt32(txtPeriodoFuturo.Text);
            double Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + TasaInteresFu, PeriodoFu - 1) - 1) / (TasaInteresFu * Math.Pow(1 + TasaInteresFu, PeriodoFu - 1)))) * Math.Pow(1 + TasaInteresFu, PeriodoFu);

            try
            {
                if (cmbInteresAnualidadF.SelectedItem != null && cmbPeriodoFuturo.SelectedItem != null)
                {
                    if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), PeriodoFu - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), PeriodoFu - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), PeriodoFu),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 12) - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 12) - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 12)),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres")) 
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 2) - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 2) - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 2)),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 4) - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 4) - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 4)),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 12) - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 12) - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 12)),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), PeriodoFu  - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), PeriodoFu  - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), PeriodoFu),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu*6) - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu*6) - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu*6)),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 3) - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 3) - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 3)),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 2) - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 2) - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 2)),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 6) - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 6) - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 6)),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), PeriodoFu  - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), PeriodoFu  - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), PeriodoFu ),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 2) - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 2) - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 2)),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 4) - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 4) - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 4)),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 3) - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 3) - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu / 3)),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 2) - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 2) - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), (PeriodoFu * 2)),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                    {
                        Af.Add(new AnualidadAnticipadaF
                        {
                            AnualidadF = Convert.ToInt32(txtValorAnualidadFuturo.Text),
                            TasaIntersF = Convert.ToDouble(txtTasaInteresFuturo.Text),
                            PeriodoF = Convert.ToInt32(txtPeriodoFuturo.Text),
                            Futuro = (AnualidadFu + AnualidadFu * ((Math.Pow(1 + (TasaInteresFu / 100), PeriodoFu - 1) - 1) / ((TasaInteresFu / 100) * Math.Pow(1 + (TasaInteresFu / 100), PeriodoFu - 1)))) * Math.Pow(1 + (TasaInteresFu / 100), PeriodoFu),
                        });
                        dgvResultadosFuturo.DataSource = null;
                        dgvResultadosFuturo.DataSource = Af;
                    }


                }
            }catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios"+x);
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

        private void btnCalcularAp_Click(object sender, EventArgs e)
        {
            int valorPresenteAp = Convert.ToInt32(txtValorPresenteAnualidadAnticipada.Text);
            double TasaInteresAp = Convert.ToDouble(txtInteresAnualidadAnticipada.Text);
            int PeriodoAp = Convert.ToInt32(txtPeriodoAnualidadAnticipada.Text);
            double AnualidadPresente = valorPresenteAp * (((TasaInteresAp/100) * Math.Pow(1 + (TasaInteresAp/100), PeriodoAp)) / (Math.Pow(1 + (TasaInteresAp/100), PeriodoAp) - 1));

            if (cmbInteresAp.SelectedItem != null && cmbPeriodoAp.SelectedItem !=null) 
            {
                if (cmbInteresAp.SelectedItem.Equals("Semestral") && cmbPeriodoAp.SelectedItem.Equals("Años"))
                {
                    AAp.Add(new AnualidadAnticipadaAP
                    {
                        ValorPresenteAP = Convert.ToInt32(txtValorPresenteAnualidadAnticipada.Text),
                        TasaInteresAP = Convert.ToDouble(txtInteresAnualidadAnticipada.Text),
                        PeriodoAP = Convert.ToInt32(txtPeriodoAnualidadAnticipada.Text),
                        AnualidadPresente = valorPresenteAp * (((TasaInteresAp / 100) * Math.Pow(1 + (TasaInteresAp / 100), (PeriodoAp*2))) / (Math.Pow(1 + (TasaInteresAp / 100), (PeriodoAp*2)) - 1)),
                    });
                    dgvResultadosAnualidadPresenteAnticipada.DataSource = null;
                    dgvResultadosAnualidadPresenteAnticipada.DataSource = AAp;
                }
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

        private void btnCalcularAf_Click(object sender, EventArgs e)
        {
            try
            {
                int ValorFuturoAf = Convert.ToInt32(txtValorFuturoAnualidadFuturo.Text);
                double TasaInteresAf = Convert.ToDouble(txtInteresAnualidadFuturo.Text);
                int PeriodoAf = Convert.ToInt32(txtPeriodoAnualidadFuturo.Text);
                double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));

                if (cmbInteresAf.SelectedItem !=null && cmbPeriodoAf.SelectedItem !=null) 
                {
                    if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                    {
                      AAF.Add(new AnualidadAnticipadaAF
                      { 
                            ValorFuturoAF = Convert.ToInt32(txtValorFuturoAnualidadFuturo.Text),
                            TasaInteresAF = Convert.ToDouble(txtInteresAnualidadFuturo.Text),
                            PeriodoAF = Convert.ToInt32(txtPeriodoAnualidadFuturo.Text),
                            AnualidadFuturo = ValorFuturoAf * ((TasaInteresAf/100) / (Math.Pow(1 + (TasaInteresAf/100), PeriodoAf) - 1)),
                      });
                        dgvResultadosAnualidadFuturo.DataSource = null;
                        dgvResultadosAnualidadFuturo.DataSource = AAF;
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Rellene los campos necesarios"+ex);
            }
        }
    }
}
