namespace Teste
{
    class Program
    {
         public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.saldo.saldo = 200;
            conta.conta = 555840;
            conta.agencia = 158;
            conta.saldo.Depositar(500);
            
        Console.WriteLine("Nome Usuario : "+ conta.titular.user);
        Console.WriteLine("Cpf Usuario : "+ conta.cpf.cpf);
        Console.WriteLine("Conta Usuario : "+conta.conta);
        Console.WriteLine("Agencia Usuario : "+conta.agencia);
        Console.WriteLine("Saldo Usuario : "+conta.saldo.saldo);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}