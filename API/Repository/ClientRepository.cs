using API.Data;
using API.Models;
using API.Repository.IRepository;

namespace API.Repository
{
    public class ClientRepository : Repository<Cliente>, IClientRepository
    {
        private readonly ClienteContext _db;
        public ClientRepository(ClienteContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Cliente> Update(Cliente entity)
        {
            _db.clientes.Update(entity);
            await _db.SaveChangesAsync();
            return entity;  
        }
    }
}
