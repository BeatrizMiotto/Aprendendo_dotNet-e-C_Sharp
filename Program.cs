// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World! My name is Beatriz!!!");

/*namespace projeto_aula;

class Program
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
namespace projeto_aula;

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
class Program
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
}

//Exercicio 1
/*Seu roberto é um comerciante e precisa de um sistema 
para armazenar os produtos do seu armazem

Crie um programa que tenha um menu

mostrando as opções de cadastro.

1 - Cadastrar produto
2 - Listar produtos cadastrados
3 - Quantidade total de itens no estoque
4 - Sair

no produto terá os atributos
- id
- nome
- quantidade
*/ 
/*class Program
{
    static void Main(string[] args)
    {
        var lista = [];
    }
}*/
