using System.Collections.Generic;
using ToDoApi.Interfaces;
using ToDoApi.Models;

namespace ToDoApi.BLL
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _repositorio;

        public TarefaService(ITarefaRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Tarefa> Listar() => _repositorio.ObterTodas();

        public void Criar(string descricao)
        {
            var novaTarefa = new Tarefa { Descricao = descricao, Concluida = false };
            _repositorio.Adicionar(novaTarefa);
        }

        public void Concluir(int id) => _repositorio.MarcarComoConcluida(id);

        public void Excluir(int id) => _repositorio.Remover(id);
    }
}