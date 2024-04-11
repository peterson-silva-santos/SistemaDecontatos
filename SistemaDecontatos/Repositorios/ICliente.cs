using SistemaDecontatos.Models;

namespace SistemaDecontatos.Repositorios
{
    public interface ICliente
    {
        Task<bool> Cadastra(ClienteModel clienteModel);
    }
}
