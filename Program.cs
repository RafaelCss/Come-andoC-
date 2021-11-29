namespace Teste
{
    class Program
    {
         public static void Main(string[] args)
        {
            ContaCorrente contaJoao = new ContaCorrente();
            ContaCorrente contaCamilo = new ContaCorrente();

            contaCamilo.Titular.User= "Camilo";
            contaCamilo.Titular.Cpf= 15565455;           
            contaCamilo.conta = 555840;
            contaCamilo.agencia = 158;
            contaCamilo.saldo.Depositar(500);


            contaJoao.Titular.User= "João";
            contaJoao.Titular.Cpf= 11111100; 
            contaJoao.conta = 158840;
            contaJoao.agencia = 938;
            contaJoao.saldo.Depositar(100);

            
            contaCamilo.saldo.Transferir(100, contaJoao);

      

        Console.WriteLine("Nome Usuario : "+ contaJoao.Titular.User);
        Console.WriteLine("Cpf Usuario : "+ contaJoao.Titular.Cpf);
        Console.WriteLine("Conta Usuario : "+contaJoao.conta);
        Console.WriteLine("Agencia Usuario : "+contaJoao.agencia);
        Console.WriteLine("Saldo Usuario : "+contaJoao.saldo.Saldo);
        Console.WriteLine("----------------");
        Console.WriteLine("Nome Usuario : "+ contaCamilo.Titular.User);
        Console.WriteLine("Cpf Usuario : "+ contaCamilo.Titular.Cpf);
        Console.WriteLine("Conta Usuario : "+contaCamilo.conta);
        Console.WriteLine("Agencia Usuario : "+contaCamilo.agencia);
        Console.WriteLine("Saldo Usuario : "+contaCamilo.saldo.Saldo);
        Console.WriteLine("----------------");


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}