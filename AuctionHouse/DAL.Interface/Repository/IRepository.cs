using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> GetByPredicate(Expression<Func<T, bool>> f);
        void Create(T item); 
        void Update(T item); 
        void Delete(int id); 
    }
}
