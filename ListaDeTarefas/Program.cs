using System;
using System.Collections.Generic;
using System.Linq;

class GerenciadorDeTarefas
{
    class Tarefa
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool EstaCompleta { get; set; }
    }

    private List<Tarefa> tarefas = new List<Tarefa>();

    public void CriarTarefa(string titulo, string descricao, DateTime dataVencimento)
    {
        Tarefa novaTarefa = new Tarefa
        {
            Titulo = titulo,
            Descricao = descricao,
            DataVencimento = dataVencimento,
            EstaCompleta = false
        };
        tarefas.Add(novaTarefa);
        Console.WriteLine("Tarefa criada com sucesso!");
    }

    public void ListarTodasAsTarefas()
    {
        Console.WriteLine("Todas as tarefas:");
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"Título: {tarefa.Titulo} | Descrição: {tarefa.Descricao} | Vencimento: {tarefa.DataVencimento} | Completa: {tarefa.EstaCompleta}");
        }
    }

    public void MarcarTarefaComoCompleta(int indiceDaTarefa)
    {
        if (indiceDaTarefa >= 0 && indiceDaTarefa < tarefas.Count)
        {
            tarefas[indiceDaTarefa].EstaCompleta = true;
            Console.WriteLine("Tarefa marcada como completa!");
        }
        else
        {
            Console.WriteLine("Índice de tarefa inválido!");
        }
    }

 public void ListarTarefasPendentes()
    {
        var tarefasPendentes = tarefas.Where(tarefa => !tarefa.EstaCompleta);
        Console.WriteLine("Tarefas pendentes:");
        foreach (var tarefa in tarefasPendentes)
        {
            Console.WriteLine($"Título: {tarefa.Titulo} | Descrição: {tarefa.Descricao} | Vencimento: {tarefa.DataVencimento}");
        }
    }

    public void ListarTarefasConcluidas()
    {
        var tarefasConcluidas = tarefas.Where(tarefa => tarefa.EstaCompleta);
        Console.WriteLine("Tarefas concluídas:");
        foreach (var tarefa in tarefasConcluidas)
        {
            Console.WriteLine($"Título: {tarefa.Titulo} | Descrição: {tarefa.Descricao} | Vencimento: {tarefa.DataVencimento}");
        }
    }

    public void ExcluirTarefa(int indiceDaTarefa)
    {
        if (indiceDaTarefa >= 0 && indiceDaTarefa < tarefas.Count)
        {
            tarefas.RemoveAt(indiceDaTarefa);
            Console.WriteLine("Tarefa excluída com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice de tarefa inválido!");
        }
    }

    public void PesquisarTarefasPorPalavraChave(string palavraChave)
    {
        var tarefasCoincidentes = tarefas.Where(tarefa =>
            tarefa.Titulo.Contains(palavraChave, StringComparison.OrdinalIgnoreCase) ||
            tarefa.Descricao.Contains(palavraChave, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine($"Tarefas que contêm a palavra-chave '{palavraChave}':");
        foreach (var tarefa in tarefasCoincidentes)
        {
            Console.WriteLine($"Título: {tarefa.Titulo} | Descrição: {tarefa.Descricao} | Vencimento: {tarefa.DataVencimento}");
        }
    }

    public void MostrarEstatisticasBasicas()
    {
        int quantidadeTarefasConcluidas = tarefas.Count(tarefa => tarefa.EstaCompleta);
        int quantidadeTarefasPendentes = tarefas.Count(tarefa => !tarefa.EstaCompleta);

        Tarefa tarefaMaisAntiga = tarefas.OrderBy(tarefa => tarefa.DataVencimento).FirstOrDefault();
        Tarefa tarefaMaisRecente = tarefas.OrderByDescending(tarefa => tarefa.DataVencimento).FirstOrDefault();

        Console.WriteLine($"Quantidade de tarefas concluídas: {quantidadeTarefasConcluidas}");
        Console.WriteLine($"Quantidade de tarefas pendentes: {quantidadeTarefasPendentes}");
        if (tarefaMaisAntiga != null)
        {
            Console.WriteLine($"Tarefa mais antiga - Título: {tarefaMaisAntiga.Titulo} | Vencimento: {tarefaMaisAntiga.DataVencimento}");
        }
        if (tarefaMaisRecente != null)
        {
            Console.WriteLine($"Tarefa mais recente - Título: {tarefaMaisRecente.Titulo} | Vencimento: {tarefaMaisRecente.DataVencimento}");
        }
    }
}