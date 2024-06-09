using Blog.DataAccessLayer.Context;
using Blog.DataAccessLayer.Repositories.Abstractions;
using Blog.DataAccessLayer.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.UnitOfWorks
{
    public class IUnitOfWork : IUnitOfWorks
    {
        private readonly AppDbContext dbContext;
        public IUnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync();
        }

        public int Save()
        {
            return dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        IRepository<T> IUnitOfWorks.GetRepository<T>()
        {
            return new Repository<T>(dbContext);
        }
    }
}
