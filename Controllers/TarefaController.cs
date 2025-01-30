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
            Console.Clear();
            Console.WriteLine("Listando Tarefas");

            foreach (var tarefa in tarefas)
            {
                var status = tarefa.Concluida ? "Concluída" : "Pendente";
                Console.WriteLine($"Id: {tarefa.Id} - Título: {tarefa.Titulo} - Status: {status} - Data de Conclusão: {tarefa.DataConclusao:dd/MM/yyyy}");
            }
        }
        public static void MarcarComoConcluida()
        {
            Console.Clear();
            Console.WriteLine("Digite o ID da tarefa a ser marcada como concluída: ");
            var id = int.Parse(Console.ReadLine());

            Tarefa tarefa = tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefa != null)
            {
                tarefa.Concluida = true;
                Console.WriteLine("Tarefa marcada como concluída com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada!");
            }
        }
        public static void ExcluirTarefa()
        {
            Console.Clear();
            Console.WriteLine("Digite o ID da tarefa a ser excluída: ");
            var id = int.Parse(Console.ReadLine());

            Tarefa tarefa = tarefas.FirstOrDefault(t => t.Id == id);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa excluída com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada!");
            }
        }
    }
}
