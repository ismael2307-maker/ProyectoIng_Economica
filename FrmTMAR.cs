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
    public partial class FrmTMAR : Form
    {
        private List<object> resultadosTMAR;

        public FrmTMAR()
        {
            InitializeComponent();
            resultadosTMAR = new List<object>();
        }

        private void FrmTMAR_Load(object sender, EventArgs e)
        {
            //Ignorar
           
        }

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(txtInversionTotal.Text) ||
                    string.IsNullOrWhiteSpace(txtDeuda.Text) ||
                    string.IsNullOrWhiteSpace(txtCostoDeuda.Text) ||
                    string.IsNullOrWhiteSpace(txtPatrimonio.Text) ||
                    string.IsNullOrWhiteSpace(txtCostoPatrimonio.Text))
                {
                    MessageBox.Show("Por favor, ingrese todos los valores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtInversionTotal.Text, out double inversionTotal) ||
                    !double.TryParse(txtDeuda.Text, out double deuda) ||
                    !double.TryParse(txtCostoDeuda.Text, out double costoDeuda) ||
                    !double.TryParse(txtPatrimonio.Text, out double patrimonio) ||
                    !double.TryParse(txtCostoPatrimonio.Text, out double costoPatrimonio))
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (inversionTotal <= 0 || deuda < 0 || costoDeuda < 0 || patrimonio < 0 || costoPatrimonio < 0)
                {
                    MessageBox.Show("Por favor, ingrese valores positivos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convertir porcentajes a decimales
                costoDeuda /= 100;
                costoPatrimonio /= 100;

                // Calcular TMAR mixta usando la fórmula
                double tmarMixta = (costoDeuda * deuda / inversionTotal) + (costoPatrimonio * patrimonio / inversionTotal);

                // Convertir TMAR mixta a porcentaje
                tmarMixta *= 100;

                // Agregar los resultados a la lista
                resultadosTMAR.Add(new
                {
                    InversionTotal = "$ " + inversionTotal,
                    MontoCapitalPropio = "$ " + deuda,
                    CostoDeuda = costoDeuda * 100, // Volver a convertir a porcentaje para mostrar
                    PatrimonioAportado = "$ " + patrimonio,
                    CostoPatrimonio = costoPatrimonio * 100, // Volver a convertir a porcentaje para mostrar
                    TMARMixta = tmarMixta
                });

                // Asignar la lista al DataGridView
                dgvResultado.DataSource = null;
                dgvResultado.DataSource = resultadosTMAR.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCostoDeuda.Clear();
            txtCostoPatrimonio.Clear();
            txtPatrimonio.Clear();
            txtDeuda.Clear();
            txtInversionTotal.Clear();
        }
    }

}