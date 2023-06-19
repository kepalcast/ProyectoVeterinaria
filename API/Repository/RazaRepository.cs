using API.Data;
using API.Models;
using API.Repository.IRepository;

namespace API.Repository
{
    public class RazaRepository : Repository<Raza>, IRazaRepositiry
    {
        private readonly ClienteContext _db;

        public RazaRepository(ClienteContext db): base(db) 
        {
            _db = db;
        }

        public async Task<Raza> Update(Raza entity)
        {
            _db.raza.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
