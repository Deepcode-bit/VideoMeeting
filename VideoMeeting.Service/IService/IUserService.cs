using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoMeeting.Service.ServiceImp;
using VideoMeeting.Model;

namespace VideoMeeting.Service.IService
{
    public interface IUserService 
    {
        public Task<string> Login(User user);//登录
    }
}
