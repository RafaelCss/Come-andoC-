namespace Teste

 {
class ContaCorrente 
{
    private Client _titular = new Client("Rafael",10589457);

    public Client Titular 
    {
        get{return _titular;}
    }
    public int conta;
    public int agencia;
    public Operation saldo = new Operation();

}


}

