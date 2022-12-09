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

//Estrutura if
namespace projeto_aula;
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
