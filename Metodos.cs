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
        //Metodo de futuro diferido
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
        //Metodo de presente diferido
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
        //Este metodo es de AnualidadAnticipada Presente
        public void CalcularPresenteAnticipado(string interesPresente, string periodoPresente, double tasaInteresPresente,double valorAnualidadPresente, int periodo1Presente, List<object> resultadosPresente, DataGridView dgvResultadosPresente)
        {
            if (interesPresente.Equals("Trimestral") && periodoPresente.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1 / 4;
                int p1 = periodo1Presente;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1,  Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Trimestral") && periodoPresente.Equals("Años"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1 / 4;
                int p1 = periodo1Presente * 4;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo1P = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Trimestral") && periodoPresente.Equals("Meses"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1 / 4;
                int p1 = periodo1Presente / 3;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Trimestral") && periodoPresente.Equals("Semestres"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1 / 4;
                int p1 = periodo1Presente * 2;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Anual") && periodoPresente.Equals("Años"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1;
                int p1 = periodo1Presente;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Anual") && periodoPresente.Equals("Meses"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1;
                int p1 = periodo1Presente / 12;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Anual") && periodoPresente.Equals("Semestres"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1;
                int p1 = (int)(periodo1Presente*0.5);
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Anual") && periodoPresente.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1;
                int p1 = periodo1Presente / 4;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Mensual") && periodoPresente.Equals("Años"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1 / 12;
                int p1 = periodo1Presente * 12;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Mensual") && periodoPresente.Equals("Meses"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1 / 12;
                int p1 = periodo1Presente;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo= p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Mensual") && periodoPresente.Equals("Semestres"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1 / 12;
                int p1 = periodo1Presente * 6;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Mensual") && periodoPresente.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1 / 12;
                int p1 = periodo1Presente * 3;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Semestral") && periodoPresente.Equals("Años"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1 / 2;
                int p1 = periodo1Presente * 2;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Semestral") && periodoPresente.Equals("Meses"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1 / 2;
                int p1 = periodo1Presente / 6;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Semestral") && periodoPresente.Equals("Semestres"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1 / 2;
                int p1 = periodo1Presente;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
            else if (interesPresente.Equals("Semestral") && periodoPresente.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadPresente;
                double i1 = tasaInteresPresente / 100;
                double interes = i1 / 2;
                int p1 = periodo1Presente * 2;
                double AnualidadPresente = anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)));
                resultadosPresente.Add(new { Anualidad = anualidad, Interes = interes, Periodo = p1, Presente = AnualidadPresente });

                dgvResultadosPresente.DataSource = null;
                dgvResultadosPresente.DataSource = resultadosPresente.ToList();
            }
        }
        //Este metodo es de AnualidadAnticipada Futuro
        public void CalcularFuturoAnticipado(string interesFuturo,string periodoFuturo,double tasaInteresFuturo,double valorAnualidadFuturo,int periodo1Futuro, List<object>resultadosFuturo,DataGridView dgvResultadosFuturo)
        {
            if (interesFuturo.Equals("Trimestral") && periodoFuturo.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 4;
                int p1 = periodo1Futuro;
                double F  = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Trimestral") && periodoFuturo.Equals("Años"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 4;
                int p1 = periodo1Futuro * 4;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Trimestral") && periodoFuturo.Equals("Meses"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 4;
                int p1 = periodo1Futuro / 3;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Trimestral") && periodoFuturo.Equals("Semestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 4;
                int p1 = periodo1Futuro * 2;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Anual") && periodoFuturo.Equals("Años"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1;
                int p1 = periodo1Futuro;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Anual") && periodoFuturo.Equals("Meses"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1;
                int p1 = periodo1Futuro / 12;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Anual") && periodoFuturo.Equals("Semestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1;
                int p1 = (int)(periodo1Futuro * 0.5);
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Anual") && periodoFuturo.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1;
                int p1 = periodo1Futuro / 4;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Mensual") && periodoFuturo.Equals("Años"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 12;
                int p1 = periodo1Futuro * 12;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Mensual") && periodoFuturo.Equals("Meses"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 12;
                int p1 = periodo1Futuro;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Mensual") && periodoFuturo.Equals("Semestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 12;
                int p1 = periodo1Futuro * 6;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Mensual") && periodoFuturo.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 12;
                int p1 = periodo1Futuro * 3;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Semestral") && periodoFuturo.Equals("Años"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 2;
                int p1 = periodo1Futuro * 2;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Semestral") && periodoFuturo.Equals("Meses"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 2;
                int p1 = periodo1Futuro / 6;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Semestral") && periodoFuturo.Equals("Semestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 2;
                int p1 = periodo1Futuro;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
            else if (interesFuturo.Equals("Semestral") && periodoFuturo.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadFuturo;
                double i1 = tasaInteresFuturo / 100;
                double interes = i1 / 2;
                int p1 = periodo1Futuro / 2;
                double F = (anualidad + anualidad * ((Math.Pow(1 + interes, p1 - 1) - 1) / (interes * Math.Pow(1 + interes, p1 - 1)))) * Math.Pow(1 + interes, p1);
                resultadosFuturo.Add(new { Anualidad = anualidad, InteresFuturo = interes, PeriodoF = p1, Futuro = F });
                dgvResultadosFuturo.DataSource = null;
                dgvResultadosFuturo.DataSource = resultadosFuturo.ToList();
            }
        }
        public void AnualidadFuturo(string interesFuturoAnualidad,string periodoFuturoAnualidad,double tasaInteresFuturoAnualidad,
            double valorFuturo,int periodo1FuturoAnualidad, List<object> resultadosFuturoAf,DataGridView dgvResultadosFuturonualidad)
        {
            if (interesFuturoAnualidad.Equals("Mensual") && periodoFuturoAnualidad.Equals("Años"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1 / 12;
                int p1 = periodo1FuturoAnualidad * 12;
                double AF = futuro * (i1 / (Math.Pow(1 + i1, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Mensual") && periodoFuturoAnualidad.Equals("Meses"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1 / 12;
                int p1 = periodo1FuturoAnualidad;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Mensual") && periodoFuturoAnualidad.Equals("Semestres"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1 / 12;
                int p1 = periodo1FuturoAnualidad * 6;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Mensual") && periodoFuturoAnualidad.Equals("Trimestres"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1 / 12;
                int p1 = periodo1FuturoAnualidad * 3;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Trimestral") && periodoFuturoAnualidad.Equals("Años"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1 / 4;
                int p1 = periodo1FuturoAnualidad * 4;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Trimestral") && periodoFuturoAnualidad.Equals("Meses"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1 / 4;
                int p1 = periodo1FuturoAnualidad / 3;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Trimestral") && periodoFuturoAnualidad.Equals("Semestres"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1 / 4;
                int p1 = periodo1FuturoAnualidad * 2;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Trimestral") && periodoFuturoAnualidad.Equals("Trimestres"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1 / 4;
                int p1 = periodo1FuturoAnualidad;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Anual") && periodoFuturoAnualidad.Equals("Años"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1;
                int p1 = periodo1FuturoAnualidad;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Anual") && periodoFuturoAnualidad.Equals("Meses"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1;
                int p1 = periodo1FuturoAnualidad / 12;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Anual") && periodoFuturoAnualidad.Equals("Semestres"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1;
                int p1 = (int)(periodo1FuturoAnualidad * 0.5);
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Anual") && periodoFuturoAnualidad.Equals("Trimestres"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1;
                int p1 = periodo1FuturoAnualidad / 4;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Semestral") && periodoFuturoAnualidad.Equals("Años"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1 / 2;
                int p1 = periodo1FuturoAnualidad * 2;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Semestral") && periodoFuturoAnualidad.Equals("Meses"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1 / 2;
                int p1 = periodo1FuturoAnualidad / 6;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Semestral") && periodoFuturoAnualidad.Equals("Semestres"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1 / 2;
                int p1 = periodo1FuturoAnualidad;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
            else if (interesFuturoAnualidad.Equals("Semestral") && periodoFuturoAnualidad.Equals("Trimestres"))
            {
                double futuro = valorFuturo;
                double i1 = tasaInteresFuturoAnualidad / 100;
                double interes = i1 / 2;
                int p1 = periodo1FuturoAnualidad / 2;
                double AF = futuro * (interes / (Math.Pow(1 + interes, p1) - 1));
                resultadosFuturoAf.Add(new { Futuro = futuro, Interes = interes, Periodo = p1, Anualidad = AF });
                dgvResultadosFuturonualidad.DataSource = null;
                dgvResultadosFuturonualidad.DataSource = resultadosFuturoAf.ToList();
            }
        }
        public void AnualidadPresente(string interesPresenteAnualidad,string periodoPresenteAnualidad,double tasaInteresPresenteAnualidad,
            double valorPresente,int periodo1PresenteAnualidad, List<object> resultadosPresenteAp,DataGridView dgvResultadosPresentenualidad)
        {
            if(interesPresenteAnualidad.Equals("Anual") && periodoPresenteAnualidad.Equals("Años"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1;
                int p1 = periodo1PresenteAnualidad;
                double AP =  presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new{ ValorPresente = presente, Interes=interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Anual") && periodoPresenteAnualidad.Equals("Meses"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1;
                int p1 = periodo1PresenteAnualidad / 12;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();
                
            }
            else if (interesPresenteAnualidad.Equals("Anual") && periodoPresenteAnualidad.Equals("Semestres"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1;
                int p1 = periodo1PresenteAnualidad / 2;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Anual") && periodoPresenteAnualidad.Equals("Trimestres"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1;
                int p1 = periodo1PresenteAnualidad / 12;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Mensual") && periodoPresenteAnualidad.Equals("Años"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1 / 12;
                int p1 = periodo1PresenteAnualidad * 12;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Mensual") && periodoPresenteAnualidad.Equals("Meses"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1 / 12;
                int p1 = periodo1PresenteAnualidad;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Mensual") && periodoPresenteAnualidad.Equals("Semestres"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1 / 12;
                int p1 = periodo1PresenteAnualidad * 6;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Mensual") && periodoPresenteAnualidad.Equals("Años"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1 / 12;
                int p1 = periodo1PresenteAnualidad * 3;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Semestral") && periodoPresenteAnualidad.Equals("Años"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1 / 2;
                int p1 = periodo1PresenteAnualidad * 2;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Semestral") && periodoPresenteAnualidad.Equals("Meses"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1 / 2;
                int p1 = periodo1PresenteAnualidad / 6;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Semestral") && periodoPresenteAnualidad.Equals("Semestres"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1 / 2;
                int p1 = periodo1PresenteAnualidad;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Semestral") && periodoPresenteAnualidad.Equals("Trimestres"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1 / 2;
                int p1 = periodo1PresenteAnualidad * 2;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Trimestral") && periodoPresenteAnualidad.Equals("Años"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1 / 4;
                int p1 = periodo1PresenteAnualidad * 4;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Trimestral") && periodoPresenteAnualidad.Equals("Meses"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1 / 4;
                int p1 = periodo1PresenteAnualidad / 3;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Trimestral") && periodoPresenteAnualidad.Equals("Semestres"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1 / 4;
                int p1 = periodo1PresenteAnualidad * 2;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
            else if (interesPresenteAnualidad.Equals("Trimestral") && periodoPresenteAnualidad.Equals("Trimestres"))
            {
                double presente = valorPresente;
                double i1 = tasaInteresPresenteAnualidad / 100;
                double interes = i1 / 4;
                int p1 = periodo1PresenteAnualidad * 4;
                double AP = presente * ((interes * Math.Pow(1 + interes, p1)) / (Math.Pow(1 + interes, p1) - 1));
                resultadosPresenteAp.Add(new { ValorPresente = presente, Interes = interes, Periodo = p1, Anualidad = AP });

                dgvResultadosPresentenualidad.DataSource = null;
                dgvResultadosPresentenualidad.DataSource = resultadosPresenteAp.ToList();

            }
        }
        public void PresenteCreciente(string interesGA,string periodoGA,double tasaInteresGA,double valorAnualidadGA,
            int periodo1GA,List<object>resultadoGA,DataGridView dgvResultadosGA,double Gradiente)
        {
            if (interesGA.Equals("Anual") && periodoGA.Equals("Años"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA;
                double GA = Gradiente;
                double resultado = GA*(1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag});
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();

            }
            else if (interesGA.Equals("Anual") && periodoGA.Equals("Meses"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA / 12;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Anual") && periodoGA.Equals("Semestres"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA / 2;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Anual") && periodoGA.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA / 4;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Mensual") && periodoGA.Equals("Años"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA * 12;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Mensual") && periodoGA.Equals("Meses"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Mensual") && periodoGA.Equals("Semestres"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA * 6;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Mensual") && periodoGA.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA * 3;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Semestral") && periodoGA.Equals("Años"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA * 2;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Semestral") && periodoGA.Equals("Meses"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA / 6;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Semestral") && periodoGA.Equals("Semestres"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Semestral") && periodoGA.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA / 2;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Trimestral") && periodoGA.Equals("Años"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA * 4;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Trimestral") && periodoGA.Equals("Meses"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA / 3;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Trimestral") && periodoGA.Equals("Semestres"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA * 2;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }
            else if (interesGA.Equals("Trimestral") && periodoGA.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadGA;
                double i1 = tasaInteresGA / 100;
                double interes = i1;
                int periodo = periodo1GA;
                double GA = Gradiente;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad + resultado;
                resultadoGA.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA.DataSource = null;
                dgvResultadosGA.DataSource = resultadoGA.ToList();
            }

        }
        public void AnualidadDecreciente(string interesGA2, string periodoGA2, double tasaInteresGA2, double valorAnualidadGA2,
          int periodo1GA2, List<object> resultadoGA2, DataGridView dgvResultadosGA2, double Gradiente2)
        {
            if (interesGA2.Equals("Anual") && periodoGA2.Equals("Años"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Anual") && periodoGA2.Equals("Meses"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 / 12;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Anual") && periodoGA2.Equals("Semestres"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 / 12;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Anual") && periodoGA2.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 / 4;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Mensual") && periodoGA2.Equals("Años"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 * 12;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Mensual") && periodoGA2.Equals("Meses"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Mensual") && periodoGA2.Equals("Semestres"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 * 6;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Mensual") && periodoGA2.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 * 3;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Semestral") && periodoGA2.Equals("Años"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 * 2;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Semestral") && periodoGA2.Equals("Meses"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 / 6;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Semestral") && periodoGA2.Equals("Semestres"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Semestral") && periodoGA2.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 / 2;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Trimestral") && periodoGA2.Equals("Años"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 * 4;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Trimestral") && periodoGA2.Equals("Meses"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 / 3;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Trimestral") && periodoGA2.Equals("Semestres"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 * 2;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
            else if (interesGA2.Equals("Trimestral") && periodoGA2.Equals("Trimestres"))
            {
                double anualidad = valorAnualidadGA2;
                double i1 = tasaInteresGA2 / 100;
                double interes = i1;
                int periodo = periodo1GA2 * 4;
                double GA = Gradiente2;
                double resultado = GA * (1 / interes - periodo / (Math.Pow(1 + interes, periodo) - 1));
                double Ag = anualidad - resultado;
                resultadoGA2.Add(new { Anualidad = anualidad, Interes = interes, Periodo = periodo, Gradiente = GA, AnualidadGradiente = Ag });
                dgvResultadosGA2.DataSource = null;
                dgvResultadosGA2.DataSource = resultadoGA2.ToList();
            }
        }
        public void preseCreciente(string interesPG,string periodoPG,double tasaInteresPG,double valorAnualidadPG,int PeriodoPG
            ,List<object> resultadoPG,DataGridView dgvresultadosPG,double gradiente)
        {

            if(interesPG.Equals("Anual") && periodoPG.Equals("Años"))
            {
                double Anualidad = valorAnualidadPG;
                double i1 = tasaInteresPG / 100;
                double Interes = i1;
                int Periodo = PeriodoPG;
                double Gr = gradiente;
                double Gradiente = Gr / Interes;
                double PresenteVencida = ((Math.Pow(1 + Interes, Periodo) - 1) / (Interes * Math.Pow(1 + Interes, Periodo)));
                double Numerador = Math.Pow(1+Interes,Periodo) -1;
                double Denominador = Interes * Math.Pow(1 + Interes, Periodo);
                double result1 = Numerador / Denominador;
                double result2 = (double)Periodo / Math.Pow(1+Interes, Periodo);
                double resultado = result1 - result2;
                double Pg = Anualidad * (PresenteVencida) + Gradiente * (resultado);
                resultadoPG.Add(new { Anualidad = Anualidad, Interes = Interes, Periodo = Periodo, Gradiente = Gr, Presente = Pg });
                dgvresultadosPG.DataSource = null;
                dgvresultadosPG.DataSource = resultadoPG.ToList();
            }
        }
        public void preseDecrece(string interesPG, string periodoPG, double tasaInteresPG, double valorAnualidadPG, int PeriodoPG
            , List<object> resultadoPG, DataGridView dgvresultadosPG, double gradiente)
        {

            if (interesPG.Equals("Anual") && periodoPG.Equals("Años"))
            {
                double Anualidad = valorAnualidadPG;
                double i1 = tasaInteresPG / 100;
                double Interes = i1;
                int Periodo = PeriodoPG;
                double Gr = gradiente;
                double Gradiente = Gr / Interes;
                double PresenteVencida = ((Math.Pow(1 + Interes, Periodo) - 1) / (Interes * Math.Pow(1 + Interes, Periodo)));
                double Numerador = Math.Pow(1 + Interes, Periodo) - 1;
                double Denominador = Interes * Math.Pow(1 + Interes, Periodo);
                double result1 = Numerador / Denominador;
                double result2 = (double)Periodo / Math.Pow(1 + Interes, Periodo);
                double resultado = result1 - result2;
                double Pg = Anualidad * (PresenteVencida) - Gradiente * (resultado);
                resultadoPG.Add(new { Anualidad = Anualidad, Interes = Interes, Periodo = Periodo, Gradiente = Gr, Presente = Pg });
                dgvresultadosPG.DataSource = null;
                dgvresultadosPG.DataSource = resultadoPG.ToList();
            }
        }
    }
   
}
