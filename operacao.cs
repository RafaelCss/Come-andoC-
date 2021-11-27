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
}