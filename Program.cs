// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Escola
{
    class Program
    {
        public static void Main(string[] args)
        {
            var nomes = new List<string>();
            var matriculas = new List<string>();
            var notas = new List<double[]>();

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Digite uma opcão:");
                Console.WriteLine("1- cadastrar aluno");
                Console.WriteLine("2- Listar alunos");
                Console.WriteLine("3- Sair");

                int opcao = 0;
                int.TryParse(Console.ReadLine(), out opcao);

                switch(opcao)
                {
                    case 1:
                        cadastrarAluno(nomes, matriculas, notas);
                        break;
                    case 2:
                        listarAlunos(nomes, matriculas, notas);
                        break;
                    case 3:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("opção Inválida!");
                        Thread.Sleep(2000);
                        break;
                }
            }
        }

        private static void listarAlunos(List<string> nomes, List<string> matriculas, List<double[]> notas)
        {
            Console.Clear();
            if(nomes.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Nenhum aluno cadastrado!!!");
                Thread.Sleep(2000);
                return;
            }

            for(var i=0; i < nomes.Count; i++)
            {
                Console.WriteLine("======================");
                Console.WriteLine("Nome: " + nomes[i]);
                Console.WriteLine("Matricula: " + matriculas[i]);
                Console.WriteLine("Notas: " + string.Join(",", notas[i]));

                double soma = 0;
                foreach(var nota in notas[i])
                    soma+= nota;
                
                double media = soma / notas[i].Length;
                
                Console.WriteLine("Média: " + media.ToString("#.##"));
                Console.WriteLine("Situação: " + (media > 6 ? "Aprovado" : "Reprovado"));
                Console.WriteLine("======================");
            }
            Thread.Sleep(5000);
        }

        private static void cadastrarAluno(List<string> nomes, List<string> matriculas, List<double[]> notas)
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do aluno: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a matricula: ");
            var matricula = Console.ReadLine();

            Console.WriteLine("Digite as notas, separando por vírgulas(,): ");
            var sNotas = Console.ReadLine();

            var sArrayNotas = sNotas.Split(',');
            var notasDouble = new double[sArrayNotas.Length];

            for(var i=0; i<sArrayNotas.Length; i++)
            {
                double nota = 0;
                double.TryParse(sArrayNotas[i], out nota);
                notasDouble[i] = nota;
            }
            nomes.Add(nome);
            matriculas.Add(matricula);
            notas.Add(notasDouble);

            Console.Clear();
            Console.WriteLine("Aluno cadastrado com sucesso!!!");
            Thread.Sleep(2000);

        }
    }
}