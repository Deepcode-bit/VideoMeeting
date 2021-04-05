using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoMeeting.Models;

namespace VideoMeeting.Repositories
{
    /// <summary>
    /// 示例仓储类，需要修改
    /// </summary>
    public class UserRepository:IUserRepository
    {
        private List<User> users = new List<User>()
        {
            new User(){UserName="mary",Password="password" }
        };

        public List<User> GetStudents()
        {
            return users;
        }

        public bool Login(User user)
        {
            var newUser = users.FirstOrDefault(u => u.UserName == user.UserName);
            if (newUser == null)
            {
                user.LoginMsg = "账号不存在";
                return false;
            }
            if (!newUser.Password.Equals(user.Password))
            {
                user.LoginMsg = "密码不正确";
                return false;
            }
            user.LoginMsg = string.Empty;
            return true;
        }
    }
}
