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
                            Presente = AnualidadPresente + AnualidadPresente * ((Math.Pow(1 + (TasaInteresPresente/100), PeriodoPresente - 1) - 1) / ((TasaInteresPresente/100) * Math.Pow(1 + (TasaInteresPresente/100), PeriodoPresente - 1))),
                        });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = Ap;
                    }
                }

            }
            catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios " + x);
            }
        }
    }
}
