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
    public class TagRepository : ITagRepository
    {
        private readonly DbContext context;
        public TagRepository(DbContext context)
        {
            this.context = context;
        }

        public void Create(DalTag item)
        {
            context.Set<Tag>().Add(item.ToOrmTag());
        }

        public void Delete(int id)
        {
            var tag = context.Set<Tag>().FirstOrDefault(x => x.Id == id);
            if (tag != null)
                context.Set<Tag>().Remove(tag);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DalTag> GetAll()
        {
            return context.Set<Tag>().Select(x => x.ToDalTag());
        }

        public DalTag GetById(int id)
        {
            return context.Set<Tag>().FirstOrDefault(x => x.Id == id).ToDalTag();
        }

        public IEnumerable<DalTag> GetByPredicate(Expression<Func<DalTag, bool>> f)
        {
            Func<DalTag, bool> func = f.Compile();
            IEnumerable<DalTag> Tags = context.Set<Tag>().Where(x => true).AsEnumerable().Select(x => x.ToDalTag()).AsEnumerable();
            return Tags.Where(x => func(x)).AsEnumerable();
        }

        public DalTag GetTagByName(string name)
        {
            return context.Set<Tag>().FirstOrDefault(x => x.Name == name).ToDalTag();
        }

        public void Update(DalTag item)
        {
            var tag = context.Set<Tag>().FirstOrDefault(x => x.Id == item.Id);
            if (tag!= null)
            {
                tag.Name = item.Name;
            }
        }
    }
}
