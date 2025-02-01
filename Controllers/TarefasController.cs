using GerenciadorDeTarefas.Models;
using System.Text.Json;

namespace GerenciadorDeTarefas.Controllers
{
    internal class TarefasController
    {
        static List<Tarefa> tarefas = new List<Tarefa>();

        // Método para gravar as tarefas em um arquivo txt
        public static void GravarDados()
        {
            var json = JsonSerializer.Serialize(tarefas);
            File.WriteAllText("tarefas.txt", json);
        }

        // Método para ler as tarefas de um arquivo txt
        public static void LerDados()
        {
            if (File.Exists("tarefas.txt"))
            {
                var json = File.ReadAllText("tarefas.txt");
                tarefas = JsonSerializer.Deserialize<List<Tarefa>>(json);
            }
        }

        public static void AdicionarTarefa()
        {
            Console.Clear();

            Console.Write("Título da tarefa: ");
            var titulo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(titulo))
            {
                Console.WriteLine("Título inválido! [Enter]");
                Console.ReadKey();
                return;
            }
            Console.Write(Environment.NewLine);

            Console.Write("Descrição da tarefa: ");
            var descricao = Console.ReadLine();
            Console.Write(Environment.NewLine);

            Console.Write("Prazo de conclusão (dd/mm/aaaa): ");
            if (!DateTime.TryParse(Console.ReadLine(), out var prazoConclusao))
            {
                Console.WriteLine("Data de conclusão inválida! [Enter]");
                Console.ReadKey();
                return;
            }
            Console.Write(Environment.NewLine);

            Tarefa tarefa = new Tarefa
            {
                Id = tarefas.Count + 1,
                Titulo = titulo,
                Descricao = descricao,
                PrazoConclusao = prazoConclusao,
                Concluida = false
            };

            tarefas.Add(tarefa);

            ListarTarefa(tarefa.Id);

            Console.WriteLine("Tarefa adicionada com sucesso! [Enter]");
            Console.ReadKey();
        }

        public static void ListarTarefas()
        {
            Console.Clear();

            if (tarefas.Count() == 0)
            {
                Console.WriteLine("Não há tarefas cadastradas! [Enter]");
                Console.ReadKey();
                return;
            }

            foreach (var tarefa in tarefas)
            {
                var status = tarefa.Concluida ? "Concluída" : "Pendente";

                Console.WriteLine($"ID................: {tarefa.Id}");
                Console.WriteLine($"Título............: {tarefa.Titulo}");
                Console.WriteLine($"Descrição.........: {tarefa.Descricao}");
                Console.WriteLine($"Status............: {status}");
                Console.WriteLine($"Prazo de Conclusão: {tarefa.PrazoConclusao:dd/MM/yyyy}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("Pressione [Enter] para voltar ao menu principal...");
            Console.ReadKey();
        }

        public static void ListarTarefa(int id)
        {
            Tarefa tarefa = tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefa != null)
            {
                var status = tarefa.Concluida ? "Concluída" : "Pendente";

                Console.WriteLine($"ID................: {tarefa.Id}");
                Console.WriteLine($"Título............: {tarefa.Titulo}");
                Console.WriteLine($"Descrição.........: {tarefa.Descricao}");
                Console.WriteLine($"Status............: {status}");
                Console.WriteLine($"Prazo de Conclusão: {tarefa.PrazoConclusao:dd/MM/yyyy}");
                Console.WriteLine("-------------------------------------");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada! [Enter]");
                Console.ReadKey();
            }
        }

        public static void EditarTarefa()
        {
            Console.Clear();

            Console.Write("Digite o ID da tarefa a ser editada: ");
            if (!int.TryParse(Console.ReadLine(), out var id))
            {
                Console.WriteLine("ID inválido! [Enter]");
                Console.ReadKey();
                return;
            }
            Console.Write(Environment.NewLine);

            Tarefa tarefa = tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefa != null)
            {
                Console.Write("Título da tarefa: ");
                if (string.IsNullOrWhiteSpace(tarefa.Titulo))
                {
                    Console.WriteLine("Título inválido! [Enter]");
                    Console.ReadKey();
                    return;
                }
                tarefa.Titulo = Console.ReadLine();
                Console.Write(Environment.NewLine);

                Console.Write("Digite a descrição da tarefa: ");
                tarefa.Descricao = Console.ReadLine();
                Console.Write(Environment.NewLine);

                Console.Write("Data de Vencimento (dd/mm/yyyy): ");
                if (!DateTime.TryParse(Console.ReadLine(), out var prazoConclusao))
                {
                    Console.WriteLine("Data de conclusão inválida! [Enter]");
                    Console.ReadKey();
                    return;
                }
                tarefa.PrazoConclusao = prazoConclusao;
                Console.Write(Environment.NewLine);

                ListarTarefa(tarefa.Id);

                Console.WriteLine("Tarefa editada com sucesso! [Enter]");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada! [Enter]");
            }
            Console.ReadKey();
        }

        public static void ExcluirTarefa()
        {
            Console.Clear();

            Console.Write("Digite o ID da tarefa a ser excluída: ");
            if (int.TryParse(Console.ReadLine(), out var id))
            {
                Console.Write(Environment.NewLine);

                Tarefa tarefa = tarefas.FirstOrDefault(t => t.Id == id);
                if (tarefa != null)
                {
                    tarefas.Remove(tarefa);
                    Console.WriteLine("Tarefa excluída com sucesso! [Enter]");
                }
                else
                {
                    Console.WriteLine("Tarefa não encontrada! [Enter]");
                }
            }
            else
            {
                Console.WriteLine("ID inválido! [Enter]");
            }
            Console.ReadKey();
        }

        public static void ConcluirTarefa()
        {
            Console.Clear();
            Console.Write("Digite o ID da tarefa a ser marcada como concluída: ");
            var input = Console.ReadLine();
            Console.Write(Environment.NewLine);

            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out var id))
            {
                Console.WriteLine("ID inválido! [Enter]");
                Console.ReadKey();
                return;
            }

            Tarefa tarefa = tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefa != null)
            {
                tarefa.Concluida = true;

                ListarTarefa(tarefa.Id);

                Console.WriteLine("Tarefa concluída com sucesso! [Enter]");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada! [Enter]");
                Console.ReadKey();
            }
        }
    }
}
