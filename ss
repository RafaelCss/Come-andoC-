[1mdiff --git a/Cliente.cs b/Cliente.cs[m
[1mindex aae8a4d..746336d 100644[m
[1m--- a/Cliente.cs[m
[1m+++ b/Cliente.cs[m
[36m@@ -3,13 +3,31 @@[m
 [m
    class Client [m
    {[m
[31m-   public string user = "João da Silva";  [m
[31m-   public int cpf = 555555555;[m
[31m-   public string user2 = "Camilo dos Santos";  [m
[31m-   public int cpf2 =1238942575;[m
[31m-[m
[32m+[m[32m      public Client(string user, int cpf)[m
[32m+[m[32m      {[m
[32m+[m[32m        string User = user;[m
[32m+[m[32m        int Cpf = cpf;[m
[32m+[m[32m      }[m
[32m+[m[41m      [m
[32m+[m[32m   private string _user;[m
[32m+[m[32m   public string User[m[41m [m
[32m+[m[32m   {[m
[32m+[m[32m      get[m
[32m+[m[32m      {[m
[32m+[m[32m         return this._user;[m
[32m+[m[32m      }[m[41m [m
[32m+[m[32m   }[m
[32m+[m[32m   private int _cpf;[m
 [m
[32m+[m[32m    public int Cpf[m[41m [m
[32m+[m[32m   {[m
[32m+[m[32m      get[m
[32m+[m[32m      {[m
[32m+[m[32m         return this._cpf;[m
[32m+[m[32m      }[m[41m [m
    }[m
 [m
[32m+[m
[32m+[m[32m   }[m
 }[m
 [m
[1mdiff --git a/Program.cs b/Program.cs[m
[1mindex 5d6890d..b859641 100644[m
[1m--- a/Program.cs[m
[1m+++ b/Program.cs[m
[36m@@ -15,18 +15,14 @@[m
             contaJoão.agencia = 938;[m
             contaJoão.saldo.Depositar(55100);[m
      [m
[32m+[m[41m      [m
 [m
[31m-        Console.WriteLine("Nome Usuario : "+ contaJoão.titular.user);[m
[31m-        Console.WriteLine("Cpf Usuario : "+ contaJoão.cpf.cpf);[m
[32m+[m[32m        Console.WriteLine("Nome Usuario : "+ contaJoão.Titular.User);[m
[32m+[m[32m        Console.WriteLine("Cpf Usuario : "+ contaJoão.Titular.Cpf);[m
         Console.WriteLine("Conta Usuario : "+contaJoão.conta);[m
         Console.WriteLine("Agencia Usuario : "+contaJoão.agencia);[m
         Console.WriteLine("Saldo Usuario : "+contaJoão.saldo.Saldo);[m
         Console.WriteLine("----------------");[m
[31m-        Console.WriteLine("Nome Usuario : "+ contaCamilo.titular.user2);[m
[31m-        Console.WriteLine("Cpf Usuario : "+ contaCamilo.cpf.cpf2);[m
[31m-        Console.WriteLine("Conta Usuario : "+contaCamilo.conta);[m
[31m-        Console.WriteLine("Agencia Usuario : "+contaCamilo.agencia);[m
[31m-        Console.WriteLine("Saldo Usuario : "+contaCamilo.saldo.Saldo);[m
 [m
 [m
             Console.WriteLine();[m
[1mdiff --git a/bin/Debug/net6.0/cshap.dll b/bin/Debug/net6.0/cshap.dll[m
[1mindex f5b7971..45cfc0c 100644[m
Binary files a/bin/Debug/net6.0/cshap.dll and b/bin/Debug/net6.0/cshap.dll differ
[1mdiff --git a/bin/Debug/net6.0/cshap.pdb b/bin/Debug/net6.0/cshap.pdb[m
[1mindex 6d65eec..8abc17b 100644[m
Binary files a/bin/Debug/net6.0/cshap.pdb and b/bin/Debug/net6.0/cshap.pdb differ
[1mdiff --git a/bin/Debug/net6.0/ref/cshap.dll b/bin/Debug/net6.0/ref/cshap.dll[m
[1mindex 8fc87ed..889a1e9 100644[m
Binary files a/bin/Debug/net6.0/ref/cshap.dll and b/bin/Debug/net6.0/ref/cshap.dll differ
[1mdiff --git a/class.cs b/class.cs[m
[1mindex e38e18a..c01f98b 100644[m
[1m--- a/class.cs[m
[1m+++ b/class.cs[m
[36m@@ -3,8 +3,12 @@[m [mnamespace Teste[m
  {[m
 class ContaCorrente [m
 {[m
[31m-    public Client titular = new Client();[m
[31m-    public Client cpf = new Client();[m
[32m+[m[32m    private Client _titular = new Client("Rafael",10589457);[m
[32m+[m
[32m+[m[32m    public Client Titular[m[41m [m
[32m+[m[32m    {[m
[32m+[m[32m        get{return _titular;}[m
[32m+[m[32m    }[m
     public int conta;[m
     public int agencia;[m
     public Operation saldo = new Operation();[m
[1mdiff --git a/obj/Debug/net6.0/cshap.GeneratedMSBuildEditorConfig.editorconfig b/obj/Debug/net6.0/cshap.GeneratedMSBuildEditorConfig.editorconfig[m
[1mindex 314f407..59c81ec 100644[m
[1m--- a/obj/Debug/net6.0/cshap.GeneratedMSBuildEditorConfig.editorconfig[m
[1m+++ b/obj/Debug/net6.0/cshap.GeneratedMSBuildEditorConfig.editorconfig[m
[36m@@ -7,4 +7,4 @@[m [mbuild_property.InvariantGlobalization =[m
 build_property.PlatformNeutralAssembly = [m
 build_property._SupportedPlatformList = Linux,macOS,Windows[m
 build_property.RootNamespace = cshap[m
[31m-build_property.ProjectDir = C:\Users\rf201\OneDrive\Área de Trabalho\Alura\cShap\[m
[32m+[m[32mbuild_property.ProjectDir = c:\Users\rf201\OneDrive\Área de Trabalho\Alura\cShap\[m
[1mdiff --git a/obj/Debug/net6.0/cshap.assets.cache b/obj/Debug/net6.0/cshap.assets.cache[m
[1mindex 4db9c10..d00e205 100644[m
Binary files a/obj/Debug/net6.0/cshap.assets.cache and b/obj/Debug/net6.0/cshap.assets.cache differ
[1mdiff --git a/obj/Debug/net6.0/cshap.dll b/obj/Debug/net6.0/cshap.dll[m
[1mindex f5b7971..45cfc0c 100644[m
Binary files a/obj/Debug/net6.0/cshap.dll and b/obj/Debug/net6.0/cshap.dll differ
[1mdiff --git a/obj/Debug/net6.0/cshap.pdb b/obj/Debug/net6.0/cshap.pdb[m
[1mindex 6d65eec..8abc17b 100644[m
Binary files a/obj/Debug/net6.0/cshap.pdb and b/obj/Debug/net6.0/cshap.pdb differ
[1mdiff --git a/obj/Debug/net6.0/ref/cshap.dll b/obj/Debug/net6.0/ref/cshap.dll[m
[1mindex 8fc87ed..889a1e9 100644[m
Binary files a/obj/Debug/net6.0/ref/cshap.dll and b/obj/Debug/net6.0/ref/cshap.dll differ
