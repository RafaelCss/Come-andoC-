   namespace Teste
{

   class Client 
   {

      
   private string _user ;
   public string User 
   {
      get
      {
         return this._user;
      }

      set
      {
         if(value == null)
         {
            return;
         }
         this._user = value;
      } 
   }
   private int _cpf;

    public int Cpf 
   {
      get
      {
         return this._cpf;
      } 

      set
      {
         if(value == null)
         {
            return;
         }
         this._cpf = value;
      } 
   }


   }
}

