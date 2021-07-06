using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuXin.Lis.Model.Entities
{
    /// <summary>
    /// 描述:LIS 数据库 基类
    /// </summary>
    [Serializable]
    public class BaseEntity
    {
        /// <summary>
        /// 操作人ID
        /// </summary>
        public string ProID { get; set; }
        /// <summary>
        /// 操作人名称
        /// </summary>
        public string ProName { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? ProTime { get; set; }
        /// <summary>
        /// 修改人ID
        /// </summary>
        public string ModID { get; set; }
        /// <summary>
        /// 修改人名称
        /// </summary>
        public string ModName { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModTime { get; set; }

        /// <summary>
        /// 是否删除 1 是 0否
        /// </summary>
        public int IsDelete { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public int IsEnable { get; set; }
    }
}
