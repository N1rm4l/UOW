using EF.Data.Contexts;
using EF.GenericRepository.ISvcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.GenericRepository.Svcs
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApiContext _dbContext;
        public UnitOfWork(ApiContext dbContext)
        {

            _dbContext = dbContext;
        }
        public void Commit()
            => _dbContext.SaveChanges();

        public async Task CommitAsync()
            => await _dbContext.SaveChangesAsync();

        public void Rollback()
            => _dbContext.Dispose();

        public async Task RollbackAsync()
            => await _dbContext.DisposeAsync();
    }
}
