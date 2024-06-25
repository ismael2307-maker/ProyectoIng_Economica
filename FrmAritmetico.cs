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
    public partial class FrmAritmetico : Form
    {
        public FrmAritmetico()
        {
            InitializeComponent();
        }

        private void txtAnualidadGA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInteresGA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoGA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtGradienteGA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarPresenteGA_Click(object sender, EventArgs e)
        {
            txtAnualidadGA.Text = "";
            txtInteresGA.Text = "";
            txtPeriodoGA.Text = "";
            txtGradienteGA.Text = "";
        }
        List<object> resultadosGA = new List<object>();
        private void btnCalcularAnualidadGA_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbPresenteIncrementa.Checked == true)
                {
                    var GA = new Metodos();
                    string interesA = cmbInteresGA.SelectedItem.ToString();
                    string periodoA = cmbPeriodoGA.SelectedItem.ToString();
                    double Anualidad =  Convert.ToDouble(txtAnualidadGA.Text);
                    double interes = Convert.ToDouble(txtInteresGA.Text);
                    int periodo1 = Convert.ToInt32(txtPeriodoGA.Text);
                    double gradiente = Convert.ToDouble(txtGradienteGA.Text);

                    GA.PresenteCreciente(interesA,periodoA,interes,Anualidad,periodo1,resultadosGA, dgvresultadosGA,gradiente);
                }
                else if(rdbPresenteDecrece.Checked == true)
                {
                    var GA = new Metodos();
                    string interesA = cmbInteresGA.SelectedItem.ToString();
                    string periodoA = cmbPeriodoGA.SelectedItem.ToString();
                    double Anualidad = Convert.ToDouble(txtAnualidadGA.Text);
                    double interes = Convert.ToDouble(txtInteresGA.Text);
                    int periodo1 = Convert.ToInt32(txtPeriodoGA.Text);
                    double gradiente = Convert.ToDouble(txtGradienteGA.Text);
                    GA.AnualidadDecreciente(interesA, periodoA, interes, Anualidad, periodo1, resultadosGA, dgvresultadosGA, gradiente);
                }
            }catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios" + x);
            }
        }
        List<object> resultadosPG = new List<object>();
        private void btnCalcularPG_Click(object sender, EventArgs e)
        {
            if (rdbIncrementaPG.Checked == true)
            {
                var PG = new Metodos();
                string interesP = cmbInteresPG.SelectedItem.ToString();
                string periodoP =cmbPeriodoPG.SelectedItem.ToString();
                double Anualidad = Convert.ToDouble(txtAnualidadPG.Text);
                double interes = Convert.ToDouble(txtInteresPG.Text);
                int Periodo1 = Convert.ToInt32(txtPeriodoPG.Text);
                double gradiente = Convert.ToDouble(txtGradientePG.Text);
                PG.preseCreciente(interesP,periodoP,interes,Anualidad,Periodo1,resultadosPG, dgvResultadosPG, gradiente);
            }
            else if(rdbDecrecePG.Checked == true)
            {
                var PG = new Metodos();
                string interesP = cmbInteresPG.SelectedItem.ToString();
                string periodoP = cmbPeriodoPG.SelectedItem.ToString();
                double Anualidad = Convert.ToDouble(txtAnualidadPG.Text);
                double interes = Convert.ToDouble(txtInteresPG.Text);
                int Periodo1 = Convert.ToInt32(txtPeriodoPG.Text);
                double gradiente = Convert.ToDouble(txtGradientePG.Text);
                PG.preseDecrece(interesP, periodoP, interes, Anualidad, Periodo1, resultadosPG, dgvResultadosPG, gradiente);
            }
            
        }

        private void txtGradientePG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAnualidadPG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInteresPG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoPG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        List<object> resultadosFG = new List<object>();
        private void btnCalcularFG_Click(object sender, EventArgs e)
        {
            if (rdbIncrementaFG.Checked == true)
            {
                var FG = new Metodos();
                string interesF = cmbInteresFG.SelectedItem.ToString();
                string periodoF = cmbPeriodoFG.SelectedItem.ToString();
                double Anualidad = Convert.ToDouble(txtAnualidadFG.Text);
                double interes = Convert.ToDouble(txtInteresFG.Text);
                int periodo1 = Convert.ToInt32(txtPeriodoFG.Text);
                double gradiente = Convert.ToDouble(txtGradienteFG.Text);
                FG.FuturoCrece(interesF, periodoF, interes, Anualidad, periodo1,resultadosFG, dgvResultadosFG,gradiente);
            }
            else if (rdbDecreceFG.Checked == true)
            {
                var FG = new Metodos();
                string interesF = cmbInteresFG.SelectedItem.ToString();
                string periodoF = cmbPeriodoFG.SelectedItem.ToString();
                double Anualidad = Convert.ToDouble(txtAnualidadFG.Text);
                double interes = Convert.ToDouble(txtInteresFG.Text);
                int periodo1 = Convert.ToInt32(txtPeriodoFG.Text);
                double gradiente = Convert.ToDouble(txtGradienteFG.Text);
                FG.FuturoDecrece(interesF, periodoF, interes, Anualidad, periodo1, resultadosFG, dgvResultadosFG, gradiente);
            }
        }
    }
}
