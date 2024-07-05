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
    public partial class FrmGeometrico : Form
    {
        public FrmGeometrico()
        {
            InitializeComponent();
        }

        private void txtAnuualidadPGeom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIntPGeom_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIntNomPGeom_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            
            }
        }

        private void txtPeriodoPGeom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private List<object> ResultadoGeométrico = new List<object>();
        private void btnLimpiarGeom_Click(object sender, EventArgs e)
        {
            double interes, interesNominal;
            if(double.TryParse(txtIntPGeom.Text, out interes)&& double.TryParse(txtIntNomPGeom.Text ,out interesNominal))
            {
                if (interes <= interesNominal)
                {
                    int Valor_Anualidad, Periodo, p1, p2, p3;
                    double tasaInteres, tasaNominal, resultados, Presente, i, i2, n, i3, n2, i4;

                   
                        Valor_Anualidad = Convert.ToInt32(txtAnuualidadPGeom.Text);
                        Periodo = Convert.ToInt32(txtPeriodoPGeom.Text);
                        p1 = Convert.ToInt32(txtPeriodoPGeom.Text);
                        p2 = Convert.ToInt32(txtPeriodoPGeom.Text);
                        p3 = Convert.ToInt32(txtPeriodoPGeom.Text);
                        tasaInteres = Convert.ToDouble(txtIntPGeom.Text);
                        tasaNominal = Convert.ToDouble(txtIntNomPGeom.Text);
                        i = Convert.ToDouble(txtIntNomPGeom.Text);
                        i2 = Convert.ToDouble(txtIntNomPGeom.Text);
                        n = Convert.ToDouble(txtIntNomPGeom.Text);
                        i3 = Convert.ToDouble(txtIntNomPGeom.Text);
                        n2 = Convert.ToDouble(txtIntNomPGeom.Text);
                        i4 = Convert.ToDouble(txtIntNomPGeom.Text);


                        if (cmbPeriodo.SelectedItem != null && cmbTasaInt.SelectedItem != null && cmbTasaNom.SelectedItem != null)
                        {
                            if (cmbPeriodo.SelectedItem.Equals("Anual") || cmbTasaInt.SelectedItem.Equals("Anual") || cmbTasaNom.SelectedItem.Equals("Anual"))
                            {

                                resultados = Valor_Anualidad * (((Math.Pow(1 + tasaNominal, Periodo) / Math.Pow(1 + tasaInteres, Periodo)) - 1) / (tasaNominal - tasaInteres));
                            string formattedVAnuaida = Valor_Anualidad.ToString("N0");
                                ResultadoGeométrico.Add(new
                                {
                                    Valor_Anualidad = "$ " + formattedVAnuaida,
                                    Tasa_Interés = tasaInteres,
                                    Tasa_Nominal = tasaNominal,
                                    Periodo = Periodo,
                                    Presente_Geométrico = "$ " + resultados
                                });
                                dgvCalculoPGeometrico.DataSource = null;
                                dgvCalculoPGeometrico.DataSource = ResultadoGeométrico.ToList();
                            }
                            if (cmbPeriodo.SelectedItem.Equals("Semestral") || cmbTasaInt.SelectedItem.Equals("Semestral") || cmbTasaNom.SelectedItem.Equals("Semestral"))
                            {

                                i = tasaNominal;
                                i2 = tasaInteres;
                                p1 = Periodo;
                                resultados = Valor_Anualidad * (((Math.Pow(1 + i, p1) / Math.Pow(1 + i2, p1)) - 1) / (i - i2));
                            string formattedVAnuaida2 = Valor_Anualidad.ToString("N0");
                            ResultadoGeométrico.Add(new
                                {
                                    Valor_Anualidad = "$ " + formattedVAnuaida2,
                                    Tasa_Interés = tasaInteres,
                                    Tasa_Nominal = tasaNominal,
                                    Periodo = Periodo,
                                    Presente_Geométrico = "$ " + resultados
                                });
                                dgvCalculoPGeometrico.DataSource = null;
                                dgvCalculoPGeometrico.DataSource = ResultadoGeométrico.ToList();
                            }
                            if (cmbPeriodo.SelectedItem.Equals("Trimestral") || cmbTasaInt.SelectedItem.Equals("Trimestral") || cmbTasaNom.SelectedItem.Equals("Trimestral"))
                            {

                                n = tasaNominal / 4;
                                i3 = tasaInteres / 4;
                                p2 = Periodo / 4;
                                resultados = Valor_Anualidad * (((Math.Pow(1 + n, p2) / Math.Pow(1 + i3, p2)) - 1) / (n - i3));
                            string formattedVAnuaida3 = Valor_Anualidad.ToString("N0");
                            ResultadoGeométrico.Add(new
                                {
                                    Valor_Anualidad = "$ " + formattedVAnuaida3,
                                    Tasa_Interés = tasaInteres,
                                    Tasa_Nominal = tasaNominal,
                                    Periodo = Periodo,
                                    Presente_Geométrico = "$ " + resultados
                                });
                                dgvCalculoPGeometrico.DataSource = null;
                                dgvCalculoPGeometrico.DataSource = ResultadoGeométrico.ToList();
                            }
                            if (cmbPeriodo.SelectedItem.Equals("Mensual") || cmbTasaInt.SelectedItem.Equals("Mensual") || cmbTasaNom.SelectedItem.Equals("Mensual"))
                            {

                                n2 = tasaNominal / 12;
                                i4 = tasaInteres / 12;
                                p3 = Periodo / 12;
                                resultados = Valor_Anualidad * (((Math.Pow(1 + n2, p3) / Math.Pow(1 + i4, p1)) - 1) / (n2 - i4));
                            string formattedVAnuaida4 = Valor_Anualidad.ToString("N0");
                            ResultadoGeométrico.Add(new
                                {
                                   Valor_Anualidad = "$ " + formattedVAnuaida4,
                                    Tasa_Interés = tasaInteres,
                                    Tasa_Nominal = tasaNominal,
                                    Periodo = Periodo,
                                    Presente_Geométrico = "$ " + resultados
                                });
                                dgvCalculoPGeometrico.DataSource = null;
                                dgvCalculoPGeometrico.DataSource = ResultadoGeométrico.ToList();
                            }
                        }
                    
                    

                 else
                    {
                        MessageBox.Show("La Tasa de Intérés no puede ser mayor que la Tasa Nominal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese Valores Validos para ambos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
        }
               




            

        private void btnLimpGeom_Click(object sender, EventArgs e)
        {
            txtAnuualidadPGeom.Text = " ";
            txtIntNomPGeom.Text = "";
            txtIntPGeom.Text = "";
            txtPeriodoPGeom.Text = "";
            dgvCalculoPGeometrico.DataSource = null;
            dgvCalculoPGeometrico.Rows.Clear();
            cmbPeriodo.SelectedIndex = -1;
            cmbPeriodo.Items.Clear();
            cmbTasaInt.SelectedIndex = -1;
            cmbTasaInt.Items.Clear();
            cmbTasaNom.SelectedIndex = -1;
            cmbTasaNom.Items.Clear();
        }
        private List<Resultado> ResultadosGeométricoFuturo = new List<Resultado>();
        private void btnCalcularFuturo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que todos los campos de texto estén rellenos
                if (string.IsNullOrEmpty(txtAnualidadFuturo.Text) ||
                    string.IsNullOrEmpty(txtPeriodoF.Text) ||
                    string.IsNullOrEmpty(txtInteresFuturo.Text) ||
                    string.IsNullOrEmpty(txtInteresJ.Text))
                {
                    MessageBox.Show("Rellene todos los campos necesarios.");
                    return;
                }

                // Validar que se haya seleccionado una opción en los ComboBox
                if (cmbInteresF.SelectedItem == null ||
                    cmbPeriodoF.SelectedItem == null ||
                    cmbTasaNomF.SelectedItem == null)
                {
                    MessageBox.Show("Verifique que tiene ya Seleccionada su opción.");
                    return;
                }

                // Obtener los datos de la interfaz
                double Valor_Anualidad = Convert.ToDouble(txtAnualidadFuturo.Text);
                double Periodo = Convert.ToDouble(txtPeriodoF.Text);
                double tasaInteres = Convert.ToDouble(txtInteresFuturo.Text) / 100;
                double tasaNominal = Convert.ToDouble(txtInteresJ.Text) / 100;

                // Obtener la periodicidad de la tasa y del periodo
                string periodicidadInteres = cmbInteresF.SelectedItem.ToString();
                string unidadPeriodo = cmbPeriodoF.SelectedItem.ToString();
                string periodicidadNominal = cmbTasaNomF.SelectedItem.ToString();

                int periodicidadInteresNum = ObtenerPeriodicidad(periodicidadInteres);
                int periodicidadNominalNum = ObtenerPeriodicidad(periodicidadNominal);
                double PeriodoConvertido = ConvertirPeriodoAnios(Periodo, unidadPeriodo);

                // Ajustar las tasas de interés y nominales a su periodicidad
                double i = ConvertirTasaNominalAEfectivaAnual(tasaNominal, periodicidadNominalNum);
                double g = tasaInteres / periodicidadInteresNum;
                i = Math.Round(i, 4, MidpointRounding.AwayFromZero);

                // Calcular el valor futuro
                double resultados = CalcularValorFuturo(Valor_Anualidad, g, PeriodoConvertido, i);
                resultados = Math.Round(resultados, 2);

                // Agregar el resultado a la lista
                ResultadosGeométricoFuturo.Add(new Resultado
                {
                    ValorAnualidad = Valor_Anualidad,
                    TasaInteres = tasaInteres * 100,
                    TasaNominal = tasaNominal * 100,
                    Periodo = Periodo,
                    ValorFuturo = resultados
                });

                // Actualizar el DataGridView
                dgvFuturoGeometrico.DataSource = null;
                dgvFuturoGeometrico.DataSource = ResultadosGeométricoFuturo.ToList();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato inválido: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

        }
        private int ObtenerPeriodicidad(string periodicidad)
        {
            switch (periodicidad)
            {
                case "Anual":
                    return 1; // Capitalización anual
                case "Semestral":
                    return 2; // Capitalización semestral
                case "Trimestral":
                    return 4; // Capitalización trimestral
                case "Mensual":
                    return 12; // Capitalización mensual
                default:
                    return 1; // Por defecto, capitalización anual
            }
        }

        private double ConvertirPeriodoAnios(double n, string unidadPeriodo)
        {
            switch (unidadPeriodo)
            {
                case "Años":
                    return n; // No se necesita conversión
                case "Meses":
                    return n / 12; // Convertir meses a años
                case "Trimestres":
                    return n / 4; // Convertir trimestres a años
                case "Semestres":
                    return n / 2; // Convertir semestres a años
                default:
                    return n; // Por defecto, asumir que está en años
            }
        }
        private double ConvertirTasaNominalAEfectivaAnual(double tasaNominal, int periodicidad)
        {
            return Math.Pow(1 + tasaNominal / periodicidad, periodicidad) - 1;
        }

        private double CalcularValorFuturo(double A1, double g, double n, double i)
        {
            // Fórmula para calcular el valor futuro de un gradiente geométrico
            return A1 * (Math.Pow(1 + g, n) - Math.Pow(1 + i, n)) / (g - i);
        }

        private List<Resultado> ResultadosGeométricoAnualidad = new List<Resultado>();
        private void btnCalcularAnualidad_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos de texto estén rellenos
            if (string.IsNullOrEmpty(txtAnualidadA.Text) ||
                string.IsNullOrEmpty(txtPeriodoAnualidad.Text) ||
                string.IsNullOrEmpty(txtInteresAnualidad.Text) ||
                string.IsNullOrEmpty(txtINominalAnualidad.Text))
            {
                MessageBox.Show("Rellene todos los campos necesarios.");
                return;
            }

            // Validar que se haya seleccionado una opción en los ComboBox
            if (cmbInteresA.SelectedItem == null ||
                cmbPeriodoA.SelectedItem == null ||
                cmbINominalA.SelectedItem == null)
            {
                MessageBox.Show("Verifique que tiene ya Seleccionada su opción.");
                return;
            }

            // Obtener los datos de la interfaz
            double Valor_AnualidadA = Convert.ToDouble(txtAnualidadA.Text);
            double PeriodoA = Convert.ToDouble(txtPeriodoAnualidad.Text);
            double tasaInteresA = Convert.ToDouble(txtInteresAnualidad.Text) / 100;
            double tasaNominalA = Convert.ToDouble(txtINominalAnualidad.Text) / 100;

            // Obtener la periodicidad de la tasa y del periodo
            string periodicidadInteresA = cmbInteresA.SelectedItem.ToString();
            string unidadPeriodoA = cmbPeriodoA.SelectedItem.ToString();
            string periodicidadNominalA = cmbINominalA.SelectedItem.ToString();
            //-------------------------------------------------------------------------//ARREGLANDO
            int PeriodicidadInteresNum = obtenerPeriodicidad(periodicidadInteresA);
            int PeriodicidadNominalNum = obtenerPeriodicidad(periodicidadNominalA);
            double periodoConvertido = ConvertirPeriodoAños(PeriodoA, unidadPeriodoA);

            // Ajustar las tasas de interés y nominales a su periodicidad
            double I = convertirTasaNominalAEfectivaAnual(tasaNominalA, PeriodicidadNominalNum);
            double J = tasaInteresA / PeriodicidadInteresNum;
            I = Math.Round(I, 4, MidpointRounding.AwayFromZero);

            // Calcular la Anualidad
            double Resultados = calcularAnualidad(Valor_AnualidadA, J, periodoConvertido, I);
            Resultados = Math.Round(Resultados, 2);

            // Agregar el resultado a la lista
            ResultadosGeométricoAnualidad.Add(new Resultado
            {
                ValorAnualidad = Valor_AnualidadA,
                TasaInteres = tasaInteresA * 100,
                TasaNominal = tasaNominalA * 100,
                Periodo = PeriodoA,
                ValorFuturo = Resultados
            });

            // Actualizar el DataGridView
            dgvAnualidadGeometrico.DataSource = null;
            dgvAnualidadGeometrico.DataSource = ResultadosGeométricoAnualidad.ToList();



        }

        private double calcularAnualidad(double Anualidad, double J, double N, double I)
        {
            // Fórmula para calcular la Anualidad de un gradiente geométrico
            return Anualidad * ((Math.Pow(1 + J, N) - Math.Pow(1 + I, N)) / (J - I)) * I/Math.Pow(1+I, N)-1;
        }

        private double convertirTasaNominalAEfectivaAnual(double tasaNominalA, int periodicidadN)
        {
            return Math.Pow(1 + tasaNominalA / periodicidadN, periodicidadN) - 1;
        }

        private double ConvertirPeriodoAños(double N, string unidadPeriodoA)
        {
            switch (unidadPeriodoA)
            {
                case "Años.":
                    return N; // No se necesita conversión
                case "Meses.":
                    return N / 12; // Convertir meses a años
                case "Trimestres.":
                    return N / 4; // Convertir trimestres a años
                case "Semestres.":
                    return N / 2; // Convertir semestres a años
                default:
                    return N; // Por defecto, asumir que está en años
            }
        }

        private int obtenerPeriodicidad(string Periodicidad)
        {
            switch (Periodicidad)
            {
                case "Anual.":
                    return 1; // Capitalización anual
                case "Semestral.":
                    return 2; // Capitalización semestral
                case "Trimestral.":
                    return 4; // Capitalización trimestral
                case "Mensual.":
                    return 12; // Capitalización mensual
                default:
                    return 1; // Por defecto, capitalización anual
            }
        }
    }
}
