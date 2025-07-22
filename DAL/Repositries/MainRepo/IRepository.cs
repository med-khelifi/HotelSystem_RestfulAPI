using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositries.MainRepo
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<int> AddNew(T item);
        Task<int> Update(T item);
        Task<int> Delete(T item);
        Task<int> Delete(int id);
    }

}
