using ApiTarefa.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefa.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarporId(int id);
        Task<UsuarioModel> Adicionar (UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar (int id);
    }
}
