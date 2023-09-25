using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prova3b
{
    internal class Medico : Funcionario
    {
        private string CRM { get; set; }
        private double ValorExtra { get; set; }
        private string Especialidade { get; set; }

        public Medico() { }
        public Medico (string cRM, double valorExtra, string especialidade, string Nome, 
            string Cpf, string Matricula, string DataNasc, string Sexo, double Salario, string CRM, double ValorExtra, string Especialidade)
           : base(Nome, Cpf, Matricula, DataNasc, Sexo, Salario)
        {
            CRM = cRM;
            ValorExtra = valorExtra;
            Especialidade = especialidade;

            
        }
        public void Calculo(double salario, double beneficio)
        {
            Console.WriteLine("Informe o salario: ");
            salario = Convert.ToDouble(Console.ReadLine());
            beneficio = (salario * 0.20) + salario;
            Console.WriteLine("O salario é: " + beneficio);
        }
    }
}
