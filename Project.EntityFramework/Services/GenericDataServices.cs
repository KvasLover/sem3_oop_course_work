using Project.domain.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Project.EntityFramework.Services
{
    class GenericDataServices<T> : IDataService<T> where T : class
    {
        private readonly Food_deliveryDbContextFactory _contextFactory;

        public GenericDataServices(Food_deliveryDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using (Food_deliveryDbContext context = _contextFactory.CreateDbContext())
            {
                var createEntity = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                return createEntity.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            /*using (Food_deliveryDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync(entity);
                await context.SaveChangesAsync();
                return createEntity.Entity;
            }*/
            return false;
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
