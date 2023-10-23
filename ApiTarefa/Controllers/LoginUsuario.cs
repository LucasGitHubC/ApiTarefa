using ApiTarefa.Model;
using ApiTarefa.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginUsuario : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepository;

        public LoginUsuario(IUsuarioRepositorio usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuarios()
        {
            List<UsuarioModel> usuario = await _usuarioRepository.BuscarTodosUsuarios();
            return Ok(usuario);
        }

        [HttpGet("id")]
        public async Task<ActionResult<UsuarioModel>> BuscarPorId(int Id) 
        {
            UsuarioModel usuario = await _usuarioRepository.BuscarporId(Id);
            return Ok(usuario);
        }
    }
}

