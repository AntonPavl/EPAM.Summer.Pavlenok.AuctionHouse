using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using DAL.Interface.Repository;
using System.Linq.Expressions;
using System.Data.Entity;
using ORM.Entities;
using DAL.Mappers;
namespace DAL.Concrete
{
    public class BasketRepository : IBasketRepository
    {
        private readonly DbContext context;
        public BasketRepository(DbContext context)
        {
            this.context = context;
        }
        public void AddLot(DalLot dallot, DalBasket item)
        {
            var basket = context.Set<Basket>().FirstOrDefault(x => x.Id == item.Id);
            var lot = context.Set<Lot>().FirstOrDefault(x => x.Id == dallot.Id);
            lot.IsBuyed = true;
            basket.Lots.Add(lot);
        }

        public void Create(DalBasket item)
        {
            Basket basket = new Basket() {
                Name = item.Name,
                Id = item.Id,
                User = context.Set<User>().FirstOrDefault(x => x.Id == item.UserId)
            };
            context.Set<Basket>().Add(basket);
        }

        public void Delete(int id)
        {
            var basket = context.Set<Basket>().FirstOrDefault(x => x.Id == id);
            context.Set<Basket>().Remove(basket);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IEnumerable<DalBasket> GetAll()
        {
            return context.Set<Basket>().Select(x => x.ToDalBasket());
        }

        public DalBasket GetBasketByName(string name)
        {
            var basket = context.Set<Basket>().FirstOrDefault(x => x.Name == name);
            return basket.ToDalBasket();
        }

        public DalBasket GetBasketByUser(DalUser user)
        {
            var basket = context.Set<Basket>().FirstOrDefault(x => x.User.Id == user.Id);
            return basket.ToDalBasket();
        }

        public DalBasket GetById(int id)
        {
            var basket = context.Set<Basket>().FirstOrDefault(x => x.Id == id);
            return basket.ToDalBasket();
        }

        public IEnumerable<DalBasket> GetByPredicate(Expression<Func<DalBasket, bool>> f)
        {
            Func<DalBasket, bool> func = f.Compile();
            IEnumerable<DalBasket> baskets = context.Set<Basket>().Where(x => true).AsEnumerable().
                Select(x => x.ToDalBasket()).AsEnumerable();
            return baskets.Where(x => func(x)).AsEnumerable();
        }

        public void RemoveLot(DalLot dalLot, DalBasket item)
        {
            var basket = context.Set<Basket>().FirstOrDefault(x => x.Id == item.Id);
            Lot lot = context.Set<Lot>().FirstOrDefault(x => x.Id == dalLot.Id);
            basket.Lots.Remove(lot);
        }

        public void Update(DalBasket item)
        {
            var basket = context.Set<Basket>().FirstOrDefault(x => x.Id == item.Id);
            basket.Name = item.Name;
        }
    }
}
