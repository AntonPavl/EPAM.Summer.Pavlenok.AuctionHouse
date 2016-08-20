using DAL.Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Repository
{
    public interface ILotRepository : IRepository<DalLot>
    {
        DalUser GetOwner(DalLot lot);
        DalUser GetGamer(DalLot lot);
        void SetGamer(DalUser gamer,DalLot lot);
        void AddTag(DalTag tag,DalLot lot);
        void RemoveTag(DalTag tag,DalLot lot);
        IEnumerable<DalLot> GetByCostRange(int costOne, int costTwo);
    }
}
