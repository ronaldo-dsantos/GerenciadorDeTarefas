using GerenciadorDeTarefas.Controllers;

namespace GerenciadorDeTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TarefasController.LerTarefas();

            while (true)
            {
                Menu();

                Console.ReadKey();
            }
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Gerenciador de Tarefas");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Editar Tarefa");
            Console.WriteLine("4 - Excluir Tarefa");
            Console.WriteLine("5 - Marcar como Concluída");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("-------------------------");

            EscolherOpcao();
        }

        static void EscolherOpcao()
        {
            Console.Write("Escolha uma opção: ");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    TarefasController.AdicionarTarefa();
                    Menu();
                    break;
                case "2":
                    TarefasController.ListarTarefas();
                    Menu();
                    break;
                case "3":
                    TarefasController.EditarTarefa();
                    Menu();
                    break;
                case "4":
                    TarefasController.ExcluirTarefa();
                    Menu();
                    break;
                case "5":
                    TarefasController.ConcluirTarefa();
                    Menu();
                    break;
                case "6":
                    TarefasController.GravarTarefas();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida! [Enter]");
                    break;
            }
        }
    }
}
