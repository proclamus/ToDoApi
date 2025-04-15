using System.Collections.Generic;
using ToDoApi.Models;

namespace ToDoApi.Interfaces
{
    public interface ITarefaService
    {
        List<Tarefa> Listar();
        void Criar(string descricao);
        void Concluir(int id);
        void Excluir(int id);
    }
}