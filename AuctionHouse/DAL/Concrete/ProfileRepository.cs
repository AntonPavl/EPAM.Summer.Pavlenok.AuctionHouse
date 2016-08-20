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
    public class ProfileRepository : IRepository<DalProfile>
    {
        private readonly DbContext context;
        public ProfileRepository(DbContext context)
        {
            this.context = context;
        }

        public void Create(DalProfile item)
        {
            var profile = item.ToOrmProfile();
            context.Set<Profile>().Add(profile);
        }

        public void Delete(int id)
        {
            var profile = context.Set<Profile>().FirstOrDefault(x => x.Id == id);
            if (profile != null)
                context.Set<Profile>().Remove(profile);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DalProfile> GetAll()
        {
            var profiles = context.Set<Profile>().Select(x => x.ToDalProfile());
            return profiles;
        }

        public DalProfile GetById(int id)
        {
            return context.Set<Profile>().FirstOrDefault(x => x.Id == id).ToDalProfile();
        }

        public IEnumerable<DalProfile> GetByPredicate(Expression<Func<DalProfile, bool>> f)
        {
            Func<DalProfile, bool> func = f.Compile();
            IEnumerable<DalProfile> profiles = context.Set<Profile>().Where(x => true).AsEnumerable().
                Select(x => x.ToDalProfile()).AsEnumerable();
            return profiles.Where(x => func(x)).AsEnumerable();
        }

        public void Update(DalProfile item)
        {
            var profile = context.Set<Profile>().FirstOrDefault(x => x.Id == item.Id);
            if (profile != null)
            {
                profile.Age = item.Age;
                profile.FirstName = item.FirstName;
                profile.LastName = item.LastName;
                profile.User = context.Set<User>().FirstOrDefault(x => x.Id == item.UserId);
            }
        }
    }
}
