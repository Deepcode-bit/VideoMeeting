using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoMeeting.Repositories.IRepository;
using VideoMeeting.Model;

namespace VideoMeeting.Repositories.RepositoryImp
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        
        public UserRepository(OracleDBContext dbContext) : base(dbContext)
        {

        }
    }
}
