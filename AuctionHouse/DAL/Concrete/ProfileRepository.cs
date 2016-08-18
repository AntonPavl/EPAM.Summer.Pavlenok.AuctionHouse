using DAL.Interface.DTO;
using DAL.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class ProfileRepository : IRepository<DalProfile>
    {
        public void Create(DalProfile item)
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

        public IEnumerable<DalProfile> GetEntities()
        {
            throw new NotImplementedException();
        }

        public DalProfile GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(DalProfile item)
        {
            throw new NotImplementedException();
        }
    }
}
