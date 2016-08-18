using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interface.DTO;
using DAL.Interface.Repository;
using ORM.Entities;
namespace DAL.Concrete
{
    public class LotRepository : IRepository<DalLot>
    {
        public void Create(DalLot item)
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

        public IEnumerable<DalLot> GetEntities()
        {
            throw new NotImplementedException();
        }

        public DalLot GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(DalLot item)
        {
            throw new NotImplementedException();
        }
    }
}
