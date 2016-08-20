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
    public class LotRepository : ILotRepository
    {
        private readonly DbContext context;
        public LotRepository(DbContext context)
        {
            this.context = context;
        }

        public void AddTag(DalTag tag)
        {
            throw new NotImplementedException();
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

        public IEnumerable<DalLot> GetByCostRange(int costOne, int costTwo)
        {
            throw new NotImplementedException();
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

        public DalUser GetGamer(DalLot item)
        {
            return context.Set<User>().FirstOrDefault(x => x.Id == item.GamerId).ToDalUser();
        }

        public DalUser GetOwner(DalLot item)
        {
            return context.Set<User>().FirstOrDefault(x => x.Id == item.OwnerId).ToDalUser();
        }

        public void RemoveTag(DalTag daltag,DalLot item)
        {
            var tag = context.Set<Tag>().FirstOrDefault(x => x.Id == daltag.Id);
            var lot = context.Set<Lot>().FirstOrDefault(x => x.Id == item.Id);
            if (tag!= null && lot!=null)
              lot.Tags.Remove(tag);
        }

        public void SetGamer(DalUser gamer,DalLot item)
        {
            var user = context.Set<User>().FirstOrDefault(x => x.Id == gamer.Id);
            context.Set<Lot>().FirstOrDefault(x => x.Id == item.Id).Gamer = user;
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
