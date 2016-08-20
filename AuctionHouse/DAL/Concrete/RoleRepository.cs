using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using DAL.Interface.Repository;
using System.Data.Entity;
using System.Linq.Expressions;
using ORM.Entities;
using DAL.Mappers;

namespace DAL.Concrete
{
    public class RoleRepository : IRepository<DalRole>
    {
        private readonly DbContext context;
        public RoleRepository(DbContext context)
        {
            this.context = context;
        }

        public void Create(DalRole item)
        {
            context.Set<Role>().Add(item.ToOrmRole());
        }

        public void Delete(int id)
        {
            var role = context.Set<Role>().FirstOrDefault(x => x.Id == id);
            if (role != null)
                context.Set<Role>().Remove(role);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DalRole> GetAll()
        {
            return context.Set<Role>().Select(x => x.ToDalRole());
        }

        public DalRole GetById(int id)
        {
            return context.Set<Role>().FirstOrDefault(x => x.Id == id).ToDalRole();
        }

        public IEnumerable<DalRole> GetByPredicate(Expression<Func<DalRole, bool>> f)
        {
            Func<DalRole, bool> func = f.Compile();
            IEnumerable<DalRole> Roles = context.Set<Role>().Where(x => true).AsEnumerable().Select(x => x.ToDalRole()).AsEnumerable();
            return Roles.Where(x => func(x)).AsEnumerable();
        }

        public void Update(DalRole item)
        {
            var role = context.Set<Role>().FirstOrDefault(x => x.Id == item.Id);
            if (role!= null)
            {
                role.Name = item.Name;
            }
        }
    }
}
