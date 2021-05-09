using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.domain.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get { get; set; }
        Task<T> Create(T entity);
        Task<T> Update(int id, T entity);
        Task<bool> Delete(int id);
    }
}
