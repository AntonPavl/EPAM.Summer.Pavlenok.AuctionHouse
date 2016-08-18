using DAL.Interface.DTO;
using DAL.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class UserRepository : IRepository<DalUser>
    {
        public void Create(DalUser item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DalUser> GetEntities()
        {
            throw new NotImplementedException();
        }

        public DalUser GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(DalUser item)
        {
            throw new NotImplementedException();
        }
    }
}
