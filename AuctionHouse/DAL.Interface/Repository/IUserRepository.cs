using DAL.Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Repository
{
    public interface IUserRepository : IRepository<DalUser>
    {
        DalUser GetByLogin(string login);
        bool IfExist(string login);
        IEnumerable<DalUser> GetByRole(DalRole role);
        void SetRole(DalUser user, DalRole role);
    }
}
