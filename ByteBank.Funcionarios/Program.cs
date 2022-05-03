using ByteBank.Funcionarios.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Augusto";
            funcionario.Salario = 1000.00;
            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.GetBonificacao());
        }
    }
}

