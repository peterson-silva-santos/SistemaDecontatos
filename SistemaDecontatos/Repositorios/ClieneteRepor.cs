using SistemaDecontatos.Data;
using SistemaDecontatos.Models;

namespace SistemaDecontatos.Repositorios
{
    public class ClieneteRepor : ICliente
    {
        private readonly ApplicationDbContext _database;

        public ClieneteRepor(ApplicationDbContext database)
        {
            _database = database;
        }

        public async Task<bool> Cadastra(ClienteModel clienteModel)
        {
            await _database.ClienteBd.AddAsync(clienteModel);
            await _database.SaveChangesAsync();
            return true;
           
        }
    }
}
