using API.Models;

namespace API.Repository.IRepository
{
    public interface IClientRepository: IRepository<Cliente>
    {
        Task<Cliente> Update(Cliente entity);
    }
}
