using FuXin.Lis.DAL.Common;
using FuXin.Lis.Model.Entities.S;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuXin.Lis.BLL.Common.Impl
{
    /// <summary>
    /// 接口实现层
    /// </summary>
    public class YiChangService : IYiChangService
    {
        private readonly YiChangServiceDAL _yiChangServiceDAL;

        public YiChangService()
        {
            _yiChangServiceDAL = new YiChangServiceDAL();
        }

        public async Task<S_User> GetList()
        {
            //这里写具体的业务逻辑代码
            var rt = await _yiChangServiceDAL.GetString();
            return rt;
        }
    }
}
