using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoMeeting.Repositories.IRepository;
using VideoMeeting.Service.IService;
using VideoMeeting.Model;

namespace VideoMeeting.Service.ServiceImp
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;

        public UserService(IRepositoryWrapper wrapper)
        {
            repository = wrapper.UserRepository;
        }

        public async Task<string> Login(User user)
        {
            try
            {
                if (user.Name == null || user.Password==null) return "用户名或密码不能为空";
                User newUser = await repository.QueryAsync(u => u.Name == user.Name);
                if (newUser == null) return "用户不存在";
                if (newUser.Password == user.Password) return "登录成功";
                return "密码错误";
            }
            catch 
            {
                return "连接失败";
            }
        }
    }
}
