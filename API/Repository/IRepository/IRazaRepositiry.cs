using API.Models;

namespace API.Repository.IRepository
{
    public interface IRazaRepositiry: IRepository<Raza>
    {
        Task<Raza> Update(Raza identity);
    }
}
