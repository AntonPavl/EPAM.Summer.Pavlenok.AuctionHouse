using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interface.DTO;
using DAL.Interface.Repository;
using ORM.Entities;
using DAL.Mappers;
using System.Linq.Expressions;

namespace DAL.Concrete
{
    public class LotRepository : IRepository<DalLot>
    {
        private readonly DbContext context;
        public LotRepository(DbContext context)
        {
            this.context = context;
        }

        public void Create(DalLot item)
        {
            context.Set<Lot>().Add(item.ToOrmLot());
        }

        public void Delete(int id)
        {
            var lot = context.Set<Lot>().FirstOrDefault(x => x.Id == id);
            if (lot != null)
                context.Set<Lot>().Remove(lot);
        }

        public void Dispose()
        {

        }

        public IEnumerable<DalLot> GetAll()
        {
            var lots = context.Set<Lot>().Select(x => x.ToDalLot());
            return lots;
        }

        public DalLot GetById(int id)
        {
            return context.Set<Lot>().FirstOrDefault(x => x.Id == id).ToDalLot();
        }

        public IEnumerable<DalLot> GetByPredicate(Expression<Func<DalLot, bool>> f)
        {
            Func<DalLot, bool> func = f.Compile();
            IEnumerable<DalLot> lots = context.Set<Lot>().Where(x => true).AsEnumerable().Select(x => x.ToDalLot()).AsEnumerable();
            return lots.Where(x => func(x)).AsEnumerable();
        }

        public void Update(DalLot item)
        {
            var lot = context.Set<Lot>().FirstOrDefault(x => x.Id == item.Id);
            if (lot!= null)
            {
                lot.Cost = item.Cost;
                lot.IsBuyed = item.IsBuyed;
                lot.Name = item.Name;
                lot.RedemptionCost = item.RedemptionCost;
                lot.Owner = context.Set<User>().FirstOrDefault(x => x.Id == item.OwnerId);
                lot.Gamer = context.Set<User>().FirstOrDefault(x => x.Id == item.GamerId);
            }
        }
    }
}
