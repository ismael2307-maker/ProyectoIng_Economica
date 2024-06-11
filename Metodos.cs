using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIng_Economica
{
    public class Metodos
    {
        public void CalcularFuturo(string interesFuturo, string periodoFuturo, double tasaInteresFuturo, double valorAnualidadFuturo, int periodo1Futuro, int periodo2Futuro,
            List<object> resultadosFuturo, DataGridView dgvResultadosFuturo)
        {
            if (interesFuturo.Equals("Trimestral") && periodoFuturo.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 4;
                int p1 = periodo1Futuro;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Trimestral") && periodoFuturo.Equals("Años"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 4;
                int p1 = periodo1Futuro * 4;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Trimestral") && periodoFuturo.Equals("Meses"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 4;
                int p1 = periodo1Futuro / 3;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Trimestral") && periodoFuturo.Equals("Semestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 4;
                int p1 = periodo1Futuro * 2;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Anual") && periodoFuturo.Equals("Años"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1;
                int p1 = periodo1Futuro;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Anual") && periodoFuturo.Equals("Meses"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1;
                int p1 = periodo1Futuro / 12;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Anual") && periodoFuturo.Equals("Semestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1;
                int p1 = (int)(periodo1Futuro * 0.5);
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Anual") && periodoFuturo.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1;
                int p1 = periodo1Futuro / 4;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Mensual") && periodoFuturo.Equals("Años"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 12;
                int p1 = periodo1Futuro * 12;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Mensual") && periodoFuturo.Equals("Meses"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 12;
                int p1 = periodo1Futuro;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Mensual") && periodoFuturo.Equals("Semestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 12;
                int p1 = periodo1Futuro * 6;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Mensual") && periodoFuturo.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 12;
                int p1 = periodo1Futuro * 3;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Semestral") && periodoFuturo.Equals("Años"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 2;
                int p1 = periodo1Futuro * 2;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Semestral") && periodoFuturo.Equals("Meses"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 2;
                int p1 = periodo1Futuro / 6;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Semestral") && periodoFuturo.Equals("Semestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 2;
                int p1 = periodo1Futuro;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Semestral") && periodoFuturo.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 2;
                int p1 = periodo1Futuro / 2;
                int p2 = periodo2Futuro;
                double F = (anualidad * (Math.Pow((1 + interes), (p1 - p2)) - 1) / interes);
                resultadosFuturo.Add(new { Anualidad = anualidad, Interes = interes, Periodo1F = p1, Periodo2F = p2, Futuro = F });

                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
        }

        public void CalcularPresente(string InteresPresente, string PeriodoPresente,double TasaInteresPresente,double ValorAnualidadPresente
            ,int Periodo1Presente,int Periodo2Presente,List<object> resultadosPresente,DataGridView dgvResultadosPresente)
        {
            if (InteresPresente.Equals("Anual") && PeriodoPresente.Equals("Años"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1;
                int p1 = Periodo1Presente;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Anual") && PeriodoPresente.Equals("Meses"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1;
                int p1 = Periodo1Presente / 12;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Anual") && PeriodoPresente.Equals("Semestres"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1;
                int p1 = (int)(Periodo1Presente * 0.5);
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Anual") && PeriodoPresente.Equals("Trimestres"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1;
                int p1 = Periodo1Presente / 4;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Mensual") && PeriodoPresente.Equals("Años"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1 / 12;
                int p1 = Periodo1Presente *12;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Mensual") && PeriodoPresente.Equals("Meses"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1;
                int p1 = Periodo1Presente;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Mensual") && PeriodoPresente.Equals("Semestres"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1 / 12;
                int p1 = Periodo1Presente * 6;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Mensual") && PeriodoPresente.Equals("Trimestres"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1 / 12;
                int p1 = Periodo1Presente * 3;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Semestral") && PeriodoPresente.Equals("Años"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1 / 2;
                int p1 = Periodo1Presente * 2;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Semestral") && PeriodoPresente.Equals("Meses"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1 / 2;
                int p1 = Periodo1Presente / 6;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Semestral") && PeriodoPresente.Equals("Semestres"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1 / 2;
                int p1 = Periodo1Presente / 6;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Semestral") && PeriodoPresente.Equals("Trimestral"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1 / 2;
                int p1 = Periodo1Presente / 2;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Trimestral") && PeriodoPresente.Equals("Años"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1 / 4;
                int p1 = Periodo1Presente * 4;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Trimestral") && PeriodoPresente.Equals("Meses"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1 / 4;
                int p1 = Periodo1Presente / 3;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Trimestral") && PeriodoPresente.Equals("Semestres"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1 / 4;
                int p1 = Periodo1Presente * 2;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (InteresPresente.Equals("Trimestral") && PeriodoPresente.Equals("Trimestres"))
            {
                double Anualidad = ValorAnualidadPresente;
                double i1 = TasaInteresPresente / 100;
                double Interes = i1 / 4;
                int p1 = Periodo1Presente;
                int p2 = Periodo2Presente;
                double P = (Anualidad * (Math.Pow((1 + Interes), (p1 - p2)) - 1) / (Interes * Math.Pow((1 + Interes), (p1 - p2)))) * Math.Pow((1 + Interes), -p2);
                resultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = p1, Periodo2P = p2, Presente = P });
                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
        }
    }
}
