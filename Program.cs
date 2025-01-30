using GerenciadorDeTarefas.Controllers;

namespace GerenciadorDeTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gerenciador de Tarefas");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Listar Tarefas");
                Console.WriteLine("3. Marcar como Concluída");
                Console.WriteLine("4. Excluir Tarefa");
                Console.WriteLine("5. Sair");
                Console.WriteLine("Escolha uma opção: ");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        TarefaController.AdicionarTarefa();
                        break;
                    case "2":
                        TarefaController.ListarTarefas();
                        break;
                    case "3":
                        TarefaController.MarcarComoConcluida();
                        break;
                    case "4":
                        TarefaController.ExcluirTarefa();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
