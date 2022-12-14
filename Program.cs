// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Escola
{
    class Program
    {
        public static void Main(string[] args)
        {
            var alunos = new List<Aluno>();

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
                        cadastrarAluno(alunos);
                        break;
                    case 2:
                        listarAlunos(alunos);
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

        private static void listarAlunos(List<Aluno> alunos)
        {
            Console.Clear();
            if(alunos.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Nenhum aluno cadastrado!!!");
                Thread.Sleep(2000);
                return;
            }

            foreach(var aluno in alunos)
            {
                Console.WriteLine("======================");
                Console.WriteLine("Nome: " + aluno.nome);
                Console.WriteLine("Matricula: " + aluno.matricula);
                Console.WriteLine("Notas: " + string.Join(",", aluno.notas));

                double soma = 0;
                foreach(var nota in aluno.notas)
                    soma+= nota;
                
                double media = soma / aluno.notas.Count;
                
                Console.WriteLine("Média: " + media.ToString("#.##"));
                Console.WriteLine("Situação: " + (media > 6 ? "Aprovado" : "Reprovado"));
                Console.WriteLine("======================");
            }
            Thread.Sleep(5000);
        }

        private static void cadastrarAluno(List<Aluno> alunos)
        {
            var aluno = new Aluno();
            Console.Clear();
            Console.WriteLine("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Digite a matricula: ");
            aluno.matricula = Console.ReadLine();

            Console.WriteLine("Digite as notas, separando por vírgulas(,): ");
            var sNotas = Console.ReadLine();

            var sArrayNotas = sNotas.Split(',');
            var listaNotas = new List<double>();

            foreach(var sNota in sArrayNotas)
            {
                double nota = 0;
                double.TryParse(sNota, out nota);
                listaNotas.Add(nota);
            }
            aluno.notas = listaNotas;
            alunos.Add(aluno);

            Console.Clear();
            Console.WriteLine("Aluno cadastrado com sucesso!!!");
            Thread.Sleep(2000);

        }
    }
}