using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoMeeting.Models
{
    /// <summary>
    /// 示例Model，可更改
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LoginMsg { get; set; }
    }
}
