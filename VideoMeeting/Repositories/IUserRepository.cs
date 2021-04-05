using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoMeeting.Models;

namespace VideoMeeting.Repositories
{
    /// <summary>
    /// 示例仓储，可修改
    /// </summary>
    public interface IUserRepository
    {
        public bool Login(User user);
        public List<User> GetStudents();
    }
}
