using ApiTarefa.Data;
using ApiTarefa.Model;
using ApiTarefa.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiTarefa.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefaDbContext _dbContext;
        public UsuarioRepositorio(SistemaTarefaDbContext sistemaTarefaDbContext)
        {
             _dbContext = sistemaTarefaDbContext;
        }
        public async Task<UsuarioModel> BuscarporId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            _dbContext.Add(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario; 
        }      

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarporId(id);

            if(usuarioPorId == null) 
            {
                throw new Exception($"Usuario Por Id: {id} não encontrado no Banco de dados.");
            }

            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Email = usuario.Email;

            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;        
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarporId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario Por Id: {id} não encontrado no Banco de dados.");
            }

            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
