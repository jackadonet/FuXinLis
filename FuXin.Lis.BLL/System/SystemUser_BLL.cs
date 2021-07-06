using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuXin.Lis.DAL;
using FuXin.Lis.Infrastructure;
using FuXin.Lis.Model;

namespace FuXin.Lis.BLL
{
    public class SystemUser_BLL
    {
        SystemUser_DAL sdal = new SystemUser_DAL();
        /// <summary>
        /// 后台登陆验证
        /// </summary>
        /// <param name="name">账户</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public S_USER UserLogin(string name, string pwd)
        {
            try
            {
                var password = Md5Helper.Md5(pwd);
                return sdal.UserLogin(name, password);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
