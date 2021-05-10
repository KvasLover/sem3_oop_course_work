using Project.domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.EntityFramework.Services
{
    class GenericDataServices<T> : IDataService<T>
    {
        private readonly Food_deliveryDbContextFactory _contextFactory;

        public GenericDataServices(Food_deliveryDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Get (int id)
        { 
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<T> Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
