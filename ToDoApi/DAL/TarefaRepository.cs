using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using ToDoApi.Interfaces;
using ToDoApi.Models;

namespace ToDoApi.DAL
{
    public class TarefaRepository : ITarefaRepository
    {
        private static List<Tarefa> tarefas = new List<Tarefa>();
        private static int idAtual = 1;



        public List<Tarefa> ObterTodas() => tarefas;

        public Tarefa ObterPorId(int id) => tarefas.FirstOrDefault(t => t.Id == id);

        public void Adicionar(Tarefa tarefa)
        {
            tarefa.Id = idAtual++;
            tarefas.Add(tarefa);
        }

        public void MarcarComoConcluida(int id)
        {
            var tarefa = ObterPorId(id);
            if (tarefa != null)
                tarefa.Concluida = true;
        }

        public void Remover(int id)
        {
            var tarefa = ObterPorId(id);
            if (tarefa != null)
                tarefas.Remove(tarefa);
        }
    }
}