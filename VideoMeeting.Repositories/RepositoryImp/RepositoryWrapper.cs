using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoMeeting.Repositories.IRepository;

namespace VideoMeeting.Repositories.RepositoryImp
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly OracleDBContext _dbContext;
        public RepositoryWrapper(OracleDBContext dbContext) => _dbContext = dbContext;

        public IUserRepository UserRepository => new UserRepository(_dbContext);
    }
}
