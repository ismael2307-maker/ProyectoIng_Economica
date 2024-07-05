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
    public partial class FrmCalendarioPago : Form
    {
        public FrmCalendarioPago()
        {
            InitializeComponent();
        }

        private void FrmCalendarioPago_Load(object sender, EventArgs e)
        {
            dgvCalendario.Columns.Add("Periodo", "Periodo");
            dgvCalendario.Columns.Add("Saldo", "Saldo");
            dgvCalendario.Columns.Add("Interes", "Interés");
            dgvCalendario.Columns.Add("Cuota", "Cuota");
            dgvCalendario.Columns.Add("Amortizacion", "Amortización");

            dgvCalendario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCalendario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnGenerarCalendario_Click(object sender, EventArgs e)
        {
            dgvCalendario.Rows.Clear();

           
            double tasaInteres = Convert.ToDouble(txtInteres.Text) / 100;
            int numPeriodos = Convert.ToInt32(txtPeriodos.Text);
            double saldoInicial = Convert.ToDouble(txtSaldo.Text);

            // Calcular la cuota fija (Anualidad)
            double cuota = saldoInicial * (tasaInteres * Math.Pow(1 + tasaInteres, numPeriodos)) / (Math.Pow(1 + tasaInteres, numPeriodos) - 1);
            cuota = Math.Round(cuota, 2);

            double TotalCuotas = 0;
            double TotalAmortizacion = 0;

            // Generar el calendario de pagos
            double saldo = saldoInicial;

            for (int i = 1; i <= numPeriodos; i++)
            {
                double interes = Math.Round(saldo * tasaInteres, 2);
                double amortizacion = Math.Round(cuota - interes, 2);

                if (i == numPeriodos)
                {
                    amortizacion = saldo;
                    cuota = interes + amortizacion;
                    saldo = 0;
                }
                else
                {
                    saldo -= amortizacion;
                }

                dgvCalendario.Rows.Add(i, FormatMoney(saldo), FormatMoney(interes), FormatMoney(cuota), FormatMoney(amortizacion));

                TotalCuotas += cuota;
                TotalAmortizacion += amortizacion;


            }
            dgvCalendario.Rows.Add("Totales", "", "", FormatMoney(TotalCuotas), FormatMoney(TotalAmortizacion));



        }

        private string FormatMoney(double valor)
        {
            return "C$" + valor.ToString("N2");
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtInteres.Clear();
            txtPeriodos.Clear();
            txtSaldo.Clear();   
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            MostrarDatosExcel();
        }

        public void MostrarDatosExcel()
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = true
            };

            excelApp.Workbooks.Add();

            Microsoft.Office.Interop.Excel.Worksheet worksheet = excelApp.ActiveSheet;
            // titulos para excel
            string[] titulosexcel = new string[5] {"Periodo","Saldo","Interes","Cuota", "Amortización" };
            var fila = 1;

            for (int columna = 0; columna < titulosexcel.Length; columna++)
            {


                worksheet.Cells[fila, columna + 1] = titulosexcel[columna];

            }


            for (int fil = 0; fil < dgvCalendario.Rows.Count; fil++)
            {
                for (int columna = 0; columna < dgvCalendario.Columns.Count; columna++)
                {
                    worksheet.Cells[fil + 2, columna + 1] = dgvCalendario.Rows[fil].Cells[columna].Value;
                }
            }

            for (int columna = 0; columna < dgvCalendario.Columns.Count; columna++)
            {
                worksheet.Columns[columna + 1].AutoFit();
            }

        }


    }
}
