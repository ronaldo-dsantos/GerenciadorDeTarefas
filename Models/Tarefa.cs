namespace GerenciadorDeTarefas.Models
{
    internal class Tarefa
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataConclusao { get; set; }
        public bool Concluida { get; set; }
    }
}
