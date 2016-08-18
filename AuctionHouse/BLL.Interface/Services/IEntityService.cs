using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Services
{
    public interface IEntityService<Entity>
    {
        Entity GetEntity(int id);
        IEnumerable<Entity> GetAllEntites();
        void Delete(Entity entity);
        void Create(Entity entity);
    }
}
