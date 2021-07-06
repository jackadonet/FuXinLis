using Dapper;
using FuXin.Lis.DataAccess.Dapper;
using FuXin.Lis.Model.Entities.S;
using System.Text;
using System.Threading.Tasks;

namespace FuXin.Lis.DAL.Common
{
    public class YiChangServiceDAL
    {
        public async Task<S_User> GetString()
        {
            using (var conn = OrclDapperHelper.GetConnection(false))
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(@" SELECT * FROM S_USER");
                return await conn.QueryFirstOrDefaultAsync<S_User>(strSql.ToString(), null);
            }
        }
    }
}
