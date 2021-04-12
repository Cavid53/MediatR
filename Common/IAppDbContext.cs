using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common
{
    public interface IAppDbContext
    {
        public DatabaseFacade GetDatabase();
        public DbSet<TEntity> GetDbSet<TEntity>() where TEntity : BaseEntity;
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = new());
    }
}
