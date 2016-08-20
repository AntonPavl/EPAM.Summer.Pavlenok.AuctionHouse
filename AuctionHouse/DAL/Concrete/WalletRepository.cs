using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using DAL.Interface.Repository;
using System.Data.Entity;
using ORM.Entities;
using DAL.Mappers;

namespace DAL.Concrete
{
    public class WalletRepository : IWalletRepository
    {
        private readonly DbContext context;
        public WalletRepository(DbContext context)
        {
            this.context = context;
        }

        public void Create(DalWallet item)
        {
            context.Set<Wallet>().Add(item.ToOrmWallet());
        }

        public void Delete(int id)
        {
            var wallet = context.Set<Wallet>().FirstOrDefault(x => x.Id == id);
            if (wallet != null)
                context.Set<Wallet>().Remove(wallet);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DalWallet> GetAll()
        {
            return context.Set<Wallet>().Select(x => x.ToDalWallet());
        }

        public DalWallet GetById(int id)
        {
            return context.Set<Wallet>().FirstOrDefault(x => x.Id == id).ToDalWallet();
        }

        public IEnumerable<DalWallet> GetByPredicate(Expression<Func<DalWallet, bool>> f)
        {
            Func<DalWallet, bool> func = f.Compile();
            IEnumerable<DalWallet> Wallets = context.Set<Wallet>().Where(x => true).AsEnumerable().Select(x => x.ToDalWallet()).AsEnumerable();
            return Wallets.Where(x => func(x)).AsEnumerable();
        }

        public DalWallet GetWalletByUser(DalUser user)
        {
            return context.Set<Wallet>().FirstOrDefault(x => x.User.Id == user.Id).ToDalWallet();
        }

        public void Update(DalWallet item)
        {
            var wallet = context.Set<Wallet>().FirstOrDefault(x => x.Id == item.Id);
            if (wallet!= null)
            {
                wallet.Money = item.Money;
                wallet.User = context.Set<User>().FirstOrDefault(x => x.Id == item.UserId);
            }
        }
    }
}
