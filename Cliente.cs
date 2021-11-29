   namespace Teste
{

   class Client 
   {
      public Client(string user, int cpf)
      {
        string User = user;
        int Cpf = cpf;
      }
      
   private string _user;
   public string User 
   {
      get
      {
         return this._user;
      } 
   }
   private int _cpf;

    public int Cpf 
   {
      get
      {
         return this._cpf;
      } 
   }


   }
}

