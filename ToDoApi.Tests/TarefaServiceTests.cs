using System.Collections.Generic;
using Moq;
using ToDoApi.BLL;
using ToDoApi.Interfaces;
using ToDoApi.Models;
using Xunit;

namespace ToDoApi.Tests
{
    public class TarefaServiceTests
    {
        [Fact]
        public void Criar_DeveAdicionarTarefa()
        {
            var mockRepo = new Mock<ITarefaRepository>();
            var service = new TarefaService(mockRepo.Object);

            service.Criar("Estudar C#");

            mockRepo.Verify(r => r.Adicionar(It.Is<Tarefa>(t => t.Descricao == "Estudar C#" && !t.Concluida)), Times.Once);
        }

        [Fact]
        public void Listar_DeveRetornarListaDeTarefas()
        {
            var tarefas = new List<Tarefa>
            {
                new Tarefa { Id = 1, Descricao = "Tarefa 1", Concluida = false },
                new Tarefa { Id = 2, Descricao = "Tarefa 2", Concluida = true }
            };
            var mockRepo = new Mock<ITarefaRepository>();
            mockRepo.Setup(r => r.ObterTodas()).Returns(tarefas);
            var service = new TarefaService(mockRepo.Object);

            var resultado = service.Listar();

            Assert.Equal(2, resultado.Count);
        }
    }
}