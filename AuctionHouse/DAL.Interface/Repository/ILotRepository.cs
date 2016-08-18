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
        DalUser GetOwner();
        DalUser GetGamer();
        void SetGamer(DalUser gamer);
        void AddTag(DalTag tag);
        void RemoveTag(DalTag tag);
        IEnumerable<DalLot> GetByCostRange(int costOne, int costTwo);
    }
}
