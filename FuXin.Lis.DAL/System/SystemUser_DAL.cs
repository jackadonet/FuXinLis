using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuXin.Lis.Model;

namespace FuXin.Lis.DAL
{
    public class SystemUser_DAL
    {
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
                //using (Sam_DBEntities db = new Sam_DBEntities())
                //{
                //    // var password = Md5Helper.Md5(pwd);
                //    return db.Base_UserInfo.Where(o => o.User_Account == name && o.User_Pwd == pwd).FirstOrDefault();
                //}
                S_USER suser = new S_USER();
                return suser;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
