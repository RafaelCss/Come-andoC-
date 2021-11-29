namespace Teste

 {
class ContaCorrente
{
    private Client _titular = new Client();
    public Client Titular 
    {
        get{return _titular;}

        set
        {
            if(value == null)
            {
                return;
            }
            this._titular = value;
        }
    }
    
    public int conta;
    public int agencia;
    public Operation saldo = new Operation();

}


}

