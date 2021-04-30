using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VideoMeeting.Repositories.IRepository
{
    public interface IRepository<Model> where Model:class,new()
    {
        Task<bool> Insert(Model model);//增
        Task<bool> Update(Model model);//删
        Task<bool> Delete(Model model);//改
        //获取全部
        Task<IEnumerable<Model>> GetListAsync();
        //条件查询
        Task<IEnumerable<Model>> QueryListAsync(Expression<Func<Model, bool>> expression);
        Task<Model> QueryAsync(Expression<Func<Model, bool>> expression);
        //通过Id查询
        Task<Model> GetByIdAsync(int id);
        //是否存在
        Task<bool> IsExistAsync(int id);
        //获取数量
        Task<int> GetCountAsync(Model model);
    }
}
