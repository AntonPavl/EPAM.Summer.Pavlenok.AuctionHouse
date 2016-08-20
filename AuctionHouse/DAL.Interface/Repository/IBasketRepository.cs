using DAL.Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Repository
{
    public interface IBasketRepository: IRepository<DalBasket>
    {
        DalBasket GetBasketByUser(DalUser user);
        DalBasket GetBasketByName(string name);
        void AddLot(DalLot lot,DalBasket item);
        void RemoveLot(DalLot lot, DalBasket item);
    }
}
