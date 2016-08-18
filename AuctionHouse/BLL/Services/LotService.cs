using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.Repository;
using BLL.Interface.Services;
using BLL.Interface.Entities;
namespace BLL.Services
{
    public class LotService : IEntityService<LotEntity>
    {
        private readonly ILotRepository lotRepository;
        public LotService(ILotRepository repository )
        {
            this.lotRepository = repository;
        }
        public void Create(LotEntity entity)
        {
            //lotRepository.Create(entity);
        }

        public void Delete(LotEntity entity)
        {
            //lotRepository.Delete(entity);
        }

        public IEnumerable<LotEntity> GetAllEntites()
        {
            return null;
            //lotRepository.GetEntities().Select(x => x);
        }

        public LotEntity GetEntity(int id)
        {
            return null;
           // lotRepository.GetEntity(id);
        }
    }
}
