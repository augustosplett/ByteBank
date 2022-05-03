namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaCorrente(new Cliente("Gabriela", "123.456.789-00", "bancária"),
                863, 123456);

            conta.Saldo = 100;
          
            Console.Write(conta.Titular.Nome);
            Console.Write(conta.Titular.Cpf);
        }
    }
}