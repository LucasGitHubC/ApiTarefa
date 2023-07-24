using ApiTarefa.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefa.Controllers
{
    public class classTestController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class UsuarioController : ControllerBase
        {
            [HttpPost]
            public ActionResult<List<TarefaModel>> AdicionarTodosUsuarios()
            {
                return Ok();
            }
        }
    }
}
