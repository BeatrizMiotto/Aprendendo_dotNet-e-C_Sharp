// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World! My name is Beatriz!!!");

namespace Projeto_aula
{
    class Program
{
    public static void Main(string[] args)
    {
        var id= new List<int>();
        var nome = new List<string>();
        var quantidade = new List<int>();
        
        while(true)
        {
            Console.WriteLine("Escolha um das opções:");
            Console.WriteLine("1- Cadastrar Produto");
            Console.WriteLine("2- Listar Produto");
            Console.WriteLine("3- Total do estoque");
            Console.WriteLine("4- Sair");

            int menu = 0;
            int.TryParse(Console.ReadLine(), out menu);

                    switch(menu)
            {
                case 1:
                    cadastrarProdutos(id, nome, quantidade);
                    break;
                case 2:
                    listarProdutos(id, nome, quantidade);
                    break;
                case 3:
                    somarquantidade(quantidade);
                    
                    break;
                case 4:
                    Console.WriteLine("Saindo....");
                    Console.WriteLine("Obrigada!!!");
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("opção Inválida!");
                    Thread.Sleep(2000);
                    break;
            }
        }
        
        
    }
        private static void cadastrarProdutos(List<int> id, List<string> nome, List<int> quantidade)
        {
            Console.Clear();
            Console.WriteLine("Cadastrar Produto");
            Console.WriteLine("***************************");

            Console.WriteLine("Digite o id do produto: ");
            var idProduto = Convert.ToInt16(Console.ReadLine());
            id.Add(idProduto);
        

            Console.WriteLine("Digite o nome do produto: ");
            var nomes = Console.ReadLine();
            nome.Add(nomes);

            Console.WriteLine("Digite a quantidade do produto: ");
            var quantidades = Convert.ToInt16(Console.ReadLine());

            quantidade.Add(quantidades);

            Console.Clear();
            Console.WriteLine("Produto Cadastrado com Sucesso!!!");
            Thread.Sleep(2000);

        
        }

        private static void listarProdutos(List<int> id, List<string> nome, List<int> quantidade)
        {
            Console.Clear();
            if(id.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado!!!");
                Thread.Sleep(2000);
                return;
            }

            for(var i=0; i < id.Count; i++)
            {
                Console.WriteLine("****************************");
                Console.WriteLine("ID: " + id[i]);
                Console.WriteLine("Nome do produto: " + nome[i]);
                Console.WriteLine("Quantidade: " + quantidade[i]);
                Console.WriteLine("****************************");
            }
            Thread.Sleep(5000);
        }
        private static void somarquantidade(List<int> quantidade)
        {
            Console.Clear();
            Console.WriteLine("*************************");
            Console.WriteLine("Total de Produtos");
            int soma = quantidade.Sum(); 
            Console.WriteLine("A soma da quantidade de todos os produtos é " + soma);

            
            Console.WriteLine("Quantidade de produtos foram todas somadas!!!");
            Thread.Sleep(2000);
        }
        }
        

    }






/*class Program
{
    public const string Arquivo ="/Users/usuario/Desktop/Programas Miotto/.net_c#/projeto_aula/imports"; 
    static void Main(string[] args)
    {
        //var cliente = JsonSerializer.Deserialize<Cliente>(Arquivo, new JsonSerializerOptions);
    }
}*/



/*class Program
{
    static void Main(string[] args)
    {
        var a = 5;
        var b = 7;
        var c = a + b;
        Console.WriteLine("A soma é, " + c);
    }
}*/

/****************************************************************/

//Estrutura if
/*namespace projeto_aula;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Encontre o valor secreto!!!");
       Console.WriteLine("Digite um numero: ");
       int n1 =Convert.ToInt16(Console.ReadLine());
        if(n1 == 5)
        {
            Console.WriteLine($"O numero digitado foi {n1} ele  é igual ao valor secreto! ");
        }
        else
        {
            Console.WriteLine("Não foi encontrado valor igual!!!");
        }
    }
}*/

/****************************************************************/

//Usando Switch
/*namespace projeto_aula;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha um Animal...");
        var pets = Console.ReadLine();
        switch(pets)
        {
            case "gatos":
            Console.WriteLine("Temos Gatos!!!");
            break;
            case "cachorros":
            Console.WriteLine("Temos Cachorros!!!");
            break;
            case "papagaios":
            Console.WriteLine("Temos Papagaios!!!");
            break;
            case "cavalos":
            Console.WriteLine("Temos Cavalos!!!");
            break;
            default:
            Console.WriteLine("Esse não temos");
            break;
        }
    }
}*/

/****************************************************************/

//Loops While DoWhile For Foreach 


/*class Program 
{
    static void Main(string[] args)
    {
        var n = 1;
        while(n<=10)
        {
            Console.WriteLine(n);
            n++;
        }
    }
}*/
/*class Program
{
    static void Main(string[] args)
    {
        var n = 1;
        do
        {
            Console.WriteLine(n);
            n++;
        }
        while(n<=10);
    }
}*/
/*class Program
{
    static void Main(string[] args)
    {
        for(int n = 1; n<=10; n++)
        {
            Console.WriteLine(n);
        }
    }
}*/
/*class Program
{
    static void Main(string[] args)
    {
        string [] lista = {"Amora", "Uva", "Morango", "Manga"};
        foreach(string l in lista)
        {
            Console.WriteLine(l);
        }
    }
}*/
//Funcão Recursiva
/*class Program
{
    static void Main(string[] args)
    {
       looping(1); 
    }
    public static void looping(int n)
    {
        Console.WriteLine(n);
        if(n < 10)
        {
            looping(n + 1);
        }
    }
}*/

/*****************************************************************************/

//Array e Collection

/*class Program 
{
    static void Main(string[] args)
    {
        string  [] nome = new string[3];
        nome[0] = "Bia";
        nome[1] = "Dudu";
        nome[2] = "Mimi";

        foreach(string nomes in nome)
        {
            Console.WriteLine(nomes);
        } 
    }
}*/
/*class Program
{
    static void Main(string[] args)
    {
        List< string > nome = new List< string>();
        
        nome.Add("Beatriz");
        nome.Add("Eduardo");
        nome.Add("Jasmine");

        foreach(string nomes in nome)
        {
            Console.WriteLine(nomes);
        }
    }
}*/

/*************************************************************************/

/*class Program
{
    public static void menu()
    {
        Console.WriteLine("Escolha um das opções:");
        Console.WriteLine("1- Cadastrar Produto");
        Console.WriteLine("2- Listar Produto");
        Console.WriteLine("3- Total do estoque");
        Console.WriteLine("4- Sair");
        var menu = Convert.ToInt16(Console.ReadLine());
        
    }
    static void Main(string [] args)
    {
        Console.WriteLine("********************************");
        menu();
        Console.WriteLine("********************************");
        var id = new List<int>();
        var nome = new List<string>();
        var quantidade = new List<int>();
        
        Console.WriteLine("Cadastre o Produto: ");
        for(int p = 0; p < id.Length ; p++)
        {
            Console.WriteLine("Id: ");
            id[p] = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Nome: ");
            nome[p] = Console.ReadLine();

            Console.WriteLine("quantidade: ");
            quantidade[p] = Convert.ToInt16(Console.ReadLine()); 
        }
        Console.WriteLine("********************************");
        menu();
        Console.WriteLine("********************************");
        for(int p = 0; p < id.Length ; p++)
        {
            Console.WriteLine("Id: " + id[p] +" | "+ "Nome: " + nome[p] + " | "+"Quantidade: " + quantidade[p]); 
        }
        Console.WriteLine("********************************");
        menu();
        Console.WriteLine("********************************");
        int soma = quantidade.Sum(); 
        Console.WriteLine("A quantidade total de Produtos é: " + soma);
        Console.WriteLine("********************************");
        menu();
        Console.WriteLine("********************************");
        Console.WriteLine("Obrigada!!!");
        Console.WriteLine("Fim!!!");
    }
}*/

/*******************************************************************************************/

/*class Program 
{
    public class Produto{
        public int Id{get; set;}
        public int Nome {get; set;}
        public int Quantidade{get; set;}
    }

    static void Main(string[] args)
    { 
        List<Produto> listaProdutos = new List<Produto>();
        Produto produto1 = new Produto();
        produto1.Id = 1;
        produto1.Nome = 2;
        produto1.Quantidade = 3;
        listaProdutos.Add(produto1);
        foreach(Produto produto in listaProdutos){
            Console.WriteLine(produto.Id);
            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Quantidade);
        }
    }
}*/