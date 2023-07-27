using ApiTarefa.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefa.Interfaces
{
    public interface ILoginService
    {
        Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuarios();
    }
}
