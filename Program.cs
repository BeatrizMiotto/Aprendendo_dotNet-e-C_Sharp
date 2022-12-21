using Newtonsoft.Json;

namespace Exercicio;
class Program
{
    public static void Main(string[] args)
    {
        Menu();
        /*Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory + @"\Pessoas.json");
        Console.Read();
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Pessoas.json");
        var usuario = JsonConvert.DeserializeObject<List<Usuario>>(json);
            var chamaCliente = JsonConvert.SerializeObject(usuario);
            if(usuario?.Count > 0 )
                Console.WriteLine(usuario[0].Nome);
                Console.WriteLine(usuario[0].Documento);
                Console.Read();*/
         
    }

    private static void Menu()
    {
        while(true)
    {
        Console.WriteLine("Escolha uma opção de cadastro:");
        Console.WriteLine("F- Cadastrar pessoa Fisica");
        Console.WriteLine("J- Cadastrar pessoa Juridica");
        Console.WriteLine("L- Listar pessoas");
        Console.WriteLine("S- Sair");
            
        var menu = Console.ReadLine();

        switch(menu)
        {
            case "F":
                Console.WriteLine("Pessoa fisica");
                CadastrarUsuario();
                break;
            case "J":
                Console.WriteLine("Pessoa juridica");
                break;
            case "L":
                Console.WriteLine("Listar");
                //Console.Clear();
                ListarPessoas();
                Thread.Sleep(2000);
                
                 
                break;
            case "S":
                    
                Console.WriteLine("Sair");
                return;
            default:
                Console.Clear();
                Console.WriteLine("Opção Invalida!");
                Thread.Sleep(2000);
                break;
        }
    }
    
    }
    private static void CadastrarUsuario()
    {
        //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory + @"\Pessoas.json");
        //Console.Read();
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Pessoas.json");
        //Console.WriteLine(json);
        var usuario = JsonConvert.DeserializeObject<List<Usuario>>(json);
        Usuario novoUsuario = new Usuario();
        novoUsuario.Id = 2;
        novoUsuario.Nome = "Alice";
        novoUsuario.Documento = "78965412378";
        novoUsuario.Tipo = "F";

        usuario.Add(novoUsuario);

        var fornecedor = JsonConvert.DeserializeObject<List<Fornecedor>>(json);
        var chamaUsuario = JsonConvert.SerializeObject(usuario);
        var chamaFornecedor = JsonConvert.SerializeObject(fornecedor);
        
    }

    private static void ListarPessoas()
    {
       //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory + @"\Pessoas.json");
        //Console.Read();
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Pessoas.json");
        //Console.WriteLine(json);
        var usuario = JsonConvert.DeserializeObject<List<Usuario>>(json);

        var fornecedor = JsonConvert.DeserializeObject<List<Fornecedor>>(json);
        var chamaUsuario = JsonConvert.SerializeObject(usuario);
        var chamaFornecedor = JsonConvert.SerializeObject(fornecedor);
        //Console.WriteLine(fornecedor);
        
        /*if(usuario?.Count > 0 )
            Console.WriteLine("Nome: " + usuario?[0].Nome);
            Console.WriteLine("CPF: " + usuario?[0].Documento);
            //Console.Read();
        if(fornecedor?.Count > 0)
            Console.WriteLine("Nome: " + fornecedor?[1].Nome);
            Console.WriteLine("CNPJ: " + fornecedor?[1].Documento);*/
        foreach(var usuarios in usuario)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Id: " + usuarios.Id);
            Console.WriteLine("Nome: " + usuarios.Nome);
            Console.WriteLine("Documento: " + usuarios.Documento);
            Console.WriteLine("Tipo: " + usuarios.Tipo);
            Console.WriteLine("=============================");

        }
    }
}
