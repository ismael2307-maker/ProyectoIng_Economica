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
    }
}
