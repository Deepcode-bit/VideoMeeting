using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VideoMeeting.Model;
using VideoMeeting.Repositories.IRepository;

namespace VideoMeeting.Repositories.RepositoryImp
{
    public abstract class BaseRepository<Model> :IRepository<Model> where Model:class,new()
    {
        protected readonly OracleDBContext dbContext;

        public BaseRepository(OracleDBContext dbContext) => this.dbContext = dbContext;

        public async Task<bool> Delete(Model model)
        {
            if (model == null) return false;
            dbContext.Set<Model>().Remove(model);
            return await dbContext.SaveChangesAsync() > 0;
        }

        public async Task<Model> GetByIdAsync(int id)
        {
            return await dbContext.Set<Model>().FindAsync(id);
        }

        public async Task<int> GetCountAsync(Model model)
        {
            return await dbContext.Set<Model>().CountAsync();
        }

        public Task<IEnumerable<Model>> GetListAsync()
        {
            return Task.FromResult(dbContext.Set<Model>().AsEnumerable());
        }

        public async Task<bool> Insert(Model model)
        {
            dbContext.Set<Model>().Add(model);
            return await dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> IsExistAsync(int id)
        {
            return await dbContext.Set<Model>().FindAsync(id) != null;
        }

        public Task<IEnumerable<Model>> QueryListAsync(Expression<Func<Model, bool>> expression)
        {
            return Task.FromResult(dbContext.Set<Model>().Where(expression).AsEnumerable());
        }

        public async Task<bool> Update(Model model)
        {
            dbContext.Set<Model>().Update(model);
            return await dbContext.SaveChangesAsync() > 0;
        }

        public Task<Model> QueryAsync(Expression<Func<Model, bool>> expression)
        { 
            return dbContext.Set<Model>().FirstOrDefaultAsync(expression);
        }
    }
}
