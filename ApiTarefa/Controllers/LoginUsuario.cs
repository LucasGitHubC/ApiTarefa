using ApiTarefa.Model;
using ApiTarefa.Repositorios.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

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
            try
            {
                var usuarios = await _usuarioRepository.BuscarTodosUsuarios();
                return Ok(usuarios);
            }
            catch (Exception)
            {
                return BadRequest($"Não há regristros no banco de dados!");
            }
        }     
    }

}
