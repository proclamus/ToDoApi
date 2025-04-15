using Microsoft.AspNetCore.Mvc;
using ToDoApi.Interfaces;

namespace ToDoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaService _service;

        public TarefasController(ITarefaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Listar() => Ok(_service.Listar());

        [HttpPost]
        public IActionResult Criar([FromBody] string descricao)
        {
            _service.Criar(descricao);
            return Ok("Tarefa criada com sucesso");
        }

        [HttpPut("{id}/concluir")]
        public IActionResult Concluir(int id)
        {
            _service.Concluir(id);
            return Ok("Tarefa marcada como concluída");
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _service.Excluir(id);
            return Ok("Tarefa removida");
        }
    }
}