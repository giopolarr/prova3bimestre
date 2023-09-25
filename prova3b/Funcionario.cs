using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova3b
{
    internal class Funcionario
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private string Matricula { get; set; }
        private string DataNasc { get; set; }
        private string Sexo { get; set; }
        private double Salario { get; set; }

        public Funcionario() { }
        public Funcionario(string nome, string Cpf, string Matricula, string DataNasc, string Sexo, double Salario)
        {
            this.Nome = nome;
            this.Cpf = Cpf;
            this.Matricula = Matricula;
            this.DataNasc = DataNasc;
            this.Sexo = Sexo;
            this.Salario = Salario;
        }

       

    }
}
