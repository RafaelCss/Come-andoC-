namespace Teste
{
    class Program
    {
         public static void Main(string[] args)
        {
            ContaCorrente contaJoão = new ContaCorrente();
            ContaCorrente contaCamilo = new ContaCorrente();
         
            contaCamilo.conta = 555840;
            contaCamilo.agencia = 158;
            contaCamilo.saldo.Depositar(500);

            contaJoão.conta = 158840;
            contaJoão.agencia = 938;
            contaJoão.saldo.Depositar(55100);
     

        Console.WriteLine("Nome Usuario : "+ contaJoão.titular.user);
        Console.WriteLine("Cpf Usuario : "+ contaJoão.cpf.cpf);
        Console.WriteLine("Conta Usuario : "+contaJoão.conta);
        Console.WriteLine("Agencia Usuario : "+contaJoão.agencia);
        Console.WriteLine("Saldo Usuario : "+contaJoão.saldo.Saldo);
        Console.WriteLine("----------------");
        Console.WriteLine("Nome Usuario : "+ contaCamilo.titular.user2);
        Console.WriteLine("Cpf Usuario : "+ contaCamilo.cpf.cpf2);
        Console.WriteLine("Conta Usuario : "+contaCamilo.conta);
        Console.WriteLine("Agencia Usuario : "+contaCamilo.agencia);
        Console.WriteLine("Saldo Usuario : "+contaCamilo.saldo.Saldo);


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}