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

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Adicionar([FromBody] UsuarioModel usuarioModel) 
        {
            UsuarioModel usuario = await _usuarioRepository.Adicionar(usuarioModel);
            return Ok (usuario);
        }

        [HttpPut]
        public async Task<ActionResult<UsuarioModel>> Atualizar([FromBody] UsuarioModel usuarioModel, int id)
        {
            usuarioModel.Id = id;
            UsuarioModel usuario = await _usuarioRepository.Atualizar(usuarioModel, id);
            return Ok(usuario);
        }

        [HttpDelete]
        public async Task<ActionResult<UsuarioModel>> Apagar(int id) 
        {
            bool apagado = await _usuarioRepository.Apagar(id);
            return Ok(apagado);
        }
    }
}

