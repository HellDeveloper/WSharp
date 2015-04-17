using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSharp.Data
{
    /// <summary> 数据模型
    /// </summary>
    public interface IDataModel
    {
        /// <summary> 创建参数
        /// </summary>
        /// <returns></returns>
        IDataParameter CreateParameter();

        /// <summary> 参数名称的前缀
        /// </summary>
        char ParameterNamePrefix { get; }

    }
}
