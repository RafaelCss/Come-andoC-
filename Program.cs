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
     
      

        Console.WriteLine("Nome Usuario : "+ contaJoão.Titular.User);
        Console.WriteLine("Cpf Usuario : "+ contaJoão.Titular.Cpf);
        Console.WriteLine("Conta Usuario : "+contaJoão.conta);
        Console.WriteLine("Agencia Usuario : "+contaJoão.agencia);
        Console.WriteLine("Saldo Usuario : "+contaJoão.saldo.Saldo);
        Console.WriteLine("----------------");


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}