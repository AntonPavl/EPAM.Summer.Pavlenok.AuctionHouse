using DAL.Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Repository
{
    public interface IWalletRepository : IRepository<DalWallet>
    {
        DalWallet GetWalletByUser(DalUser user);
    }
}
