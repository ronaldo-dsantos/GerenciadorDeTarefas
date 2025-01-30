using GerenciadorDeTarefas.Models;

namespace GerenciadorDeTarefas.Controllers
{
    internal class TarefaController
    {
        static List<Tarefa> tarefas = new List<Tarefa>();
        public static void AdicionarTarefa()
        {
            Console.Clear();            
            Console.WriteLine("Adicionar Nova Tarefa");
            Console.WriteLine("Digite o título da tarefa: ");
            var titulo = Console.ReadLine();
            Console.WriteLine("Digite a descrição da tarefa: ");
            var descricao = Console.ReadLine();
            Console.WriteLine("Data de Vencimento (dd/mm/yyyy): ");
            var DataConclusao = DateTime.Parse(Console.ReadLine());

            Tarefa tarefa = new Tarefa
            {
                Id = tarefas.Count + 1,
                Titulo = titulo,
                Descricao = descricao,
                DataConclusao = DataConclusao,
                Concluida = false
            };

            tarefas.Add(tarefa);
            Console.WriteLine("Tarefa Adicionada com Sucesso!");
        }

        public static void ListarTarefas()
        {
            Console.WriteLine("Listando Tarefas");
        }
        public static void MarcarComoConcluida()
        {
            Console.WriteLine("Marcando Tarefa como Concluída");
        }
        public static void ExcluirTarefa()
        {
            Console.WriteLine("Excluindo Tarefa");
        }
    }
}
