using FirstOnionDomain.Entity;
using FirstOnionDomain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOnionApplication.Abstracts.Interfaces
{
    public interface IGenericService<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task AddAsync(T item);
        Task UpdateAsync(T item);
        void DeleteAsync(int id);
    }
}
