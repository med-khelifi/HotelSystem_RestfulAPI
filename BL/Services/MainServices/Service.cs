using DAL.Repositries.MainRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.MainServices
{
    public class Service<T> : IService<T> where T : class
    {
        
        protected readonly IRepository<T> _repo;
        public Service(IRepository<T> repository) => _repo = repository;

        public async Task<bool> AddAsync(T item) =>  await _repo.AddNew(item)>0;

        public async Task<bool> DeleteAsync(T item) => await _repo.Delete(item) > 0;

        public async Task<bool> DeleteAsync(int Id) => await _repo.Delete(Id) > 0;

        public async Task<IEnumerable<T>> GetAllAsync() => await _repo.GetAll(); 

        public async Task<T?> GetByIdAsync(int id) => await _repo.GetById(id);
       
        public async Task<bool> UpdateAsync(T item) => await _repo.Update(item) > 0;
        
    }
}
