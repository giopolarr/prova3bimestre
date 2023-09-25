using prova3b;

class Program
{
    static void Main(string[] args)
    {
       // List<string> funcionario = new List<string>();
        List<string> administrativo = new List<string>();
        List<string> medico = new List<string>();
        while (true)
        {
            Console.WriteLine("1- Cadastrar funcionario \n" +
                "2- Cadastrar Administrativo \n " +
                "3- Cadastrar Medico \n" +
                "4- Sair do Programa ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if(opcao == 1) 
            {
                List<string> funcionario = new List<string>();
                Console.WriteLine("Digite o nome do funcionario: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o cpf do funcionario: ");
                string cpf = Console.ReadLine();
                Console.WriteLine("Digite a matricula do funcionario: ");
                string matricula = Console.ReadLine();
                Console.WriteLine("Digite a data de nascimento do funcionario: ");
                string datanasc = Console.ReadLine();
                Console.WriteLine("Digite o sexo do funcionario: ");
                string sexo = Console.ReadLine();
                Console.WriteLine("Digite o salario do funcionario: ");
                double salario = Convert.ToDouble(Console.ReadLine());
                Funcionario a = new Funcionario(nome, cpf, matricula, datanasc, sexo, salario);
              
            }
            if(opcao == 2)
            {
               Console.WriteLine("Digite o nome do funcionario administrativo: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o cpf do funcionario administrativo: ");
                string cpf = Console.ReadLine();
                Console.WriteLine("Digite a matricula do funcionario administrativo: ");
                string matricula = Console.ReadLine();
                Console.WriteLine("Digite a data de nascimento do funcionario administrativo: ");
                DateTime datanasc = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Digite o sexo do funcionario administrativo: ");
                string sexo = Console.ReadLine();
                Console.WriteLine("Digite o salario do funcionario administrativo: ");
                double salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("qual a função do funcionario administrativo");
                string funcao = Console.ReadLine();
                Administrativo admnistrativo = new Administrativo(nome, cpf, matricula, datanasc, sexo, salario, funcao);
                
            }
            if(opcao == 3) 
            {
                Console.WriteLine("Digite o CRM do medico: ");
                string CRM = Console.ReadLine();
                Console.WriteLine("Digite o valor extra: ");
                double valorextra = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("qual a especialidade do medico: ");
                string especialidade = Console.ReadLine();
                Console.WriteLine("Digite o nome do médico: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o cpf do médico: ");
                string cpf = Console.ReadLine();
                Console.WriteLine("Digite a matricula do médico: ");
                string matricula = Console.ReadLine();
                Console.WriteLine("Digite a data de nascimento do médico: ");
                string datanasc = Console.ReadLine();
                Console.WriteLine("Digite o sexo do médico: ");
                string sexo = Console.ReadLine();
                Console.WriteLine("Digite o salario do médico: ");
                double salario = Convert.ToDouble(Console.ReadLine());
              
                
                Medico medicoo = new Medico(nome, cpf, matricula, datanasc, sexo, salario, especialidade, CRM, valorextra);
            }

           if (opcao == 4) { break; }
            
        }
    }
}