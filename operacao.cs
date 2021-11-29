namespace Teste
{
    class Operation 
    {
        private double _saldo;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
            }
        }

         public bool Sacar(double valor)
         {
              if(valor > this._saldo)
               {
                  Console.WriteLine("Saldo Menor"); 
                  return false;
              }
             else
              {
                 this._saldo = _saldo - valor; 
                 return true;
              }
         }
         public void Depositar(double valor)
         {
                 this._saldo += valor;
         }
         
         public bool Transferir(double valor, ContaCorrente contaDestino)
          {
               if(this._saldo < valor)
                 {
               return false;
                  }
                this._saldo -= valor;
              contaDestino.saldo.Depositar(valor);
                return true;
         }
    }

}