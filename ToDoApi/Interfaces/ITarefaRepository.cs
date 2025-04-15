using System.Collections.Generic;
using ToDoApi.Models;

namespace ToDoApi.Interfaces
{
    public interface ITarefaRepository
    {
        List<Tarefa> ObterTodas();
        Tarefa ObterPorId(int id);
        void Adicionar(Tarefa tarefa);
        void MarcarComoConcluida(int id);
        void Remover(int id);
    }
}