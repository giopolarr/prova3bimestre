using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova3b
{
    internal class Administrativo : Funcionario
    {
        private string Funcao { get; set; }
        
        public Administrativo() { }

        public Administrativo(string Nome, string Cpf, string Matricula, string DataNasc, string Sexo, double Salario, string Funcao)
           : base( Nome, Cpf, Matricula, DataNasc, Sexo, Salario)
        {
            this.Funcao = Funcao;
        }

        private void Salario(double salario, double valeAlimentacao)
        {
            salario = salario + 150;

            Console.WriteLine("Digite o salario: ");
            valeAlimentacao = Convert.ToDouble(Console.ReadLine());

            valeAlimentacao = (valeAlimentacao * 0.15) + valeAlimentacao;

            double resultado = salario + valeAlimentacao;


        }
    }
}
