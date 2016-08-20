using DAL.Interface.DTO;
using DAL.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using ORM.Entities;
using DAL.Mappers;

namespace DAL.Concrete
{
    public class UserRepository : IRepository<DalUser>
    {
        private readonly DbContext context;
        public UserRepository(DbContext context)
        {
            this.context = context;
        }

        public void Create(DalUser item)
        {
            context.Set<User>().Add(item.ToOrmUser());
        }

        public void Delete(int id)
        {
            var user = context.Set<User>().FirstOrDefault(x => x.Id == id);
            if (user != null)
                context.Set<User>().Remove(user);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DalUser> GetAll()
        {
            return context.Set<User>().Select(x => x.ToDalUser());
        }

        public DalUser GetById(int id)
        {
            return context.Set<User>().FirstOrDefault(x => x.Id == id).ToDalUser();
        }

        public IEnumerable<DalUser> GetByPredicate(Expression<Func<DalUser, bool>> f)
        {
            Func<DalUser, bool> func = f.Compile();
            IEnumerable<DalUser> Users = context.Set<User>().Where(x => true).AsEnumerable().Select(x => x.ToDalUser()).AsEnumerable();
            return Users.Where(x => func(x)).AsEnumerable();
        }

        public void Update(DalUser item)
        {
            var user = context.Set<User>().FirstOrDefault(x => x.Id == item.Id);
            if (user!= null)
            {
                user.Password = item.Password;
                user.Email = item.Email;
                user.Wallet = context.Set<Wallet>().FirstOrDefault(x => x.Id == item.WalletId);
                user.Profile = context.Set<Profile>().FirstOrDefault(x => x.Id == item.ProfileId);
                user.Basket = context.Set<Basket>().FirstOrDefault(x => x.Id == item.BasketId);
            }
        }
    }
}
