namespace Teste
{
     class Operation 
{
    public double saldo = 0;
     public bool Sacar(double valor){

        if(valor > this.saldo)
        {
            Console.WriteLine("Saldo Menor"); 
            return false;
        }
        else
        {
           this.saldo = saldo - valor; 
            return true;
        }
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

     public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this.saldo < valor)
        {
            return false;
        }

        this.saldo -= valor;
        Depositar(valor);
        return true;

    }
}

}