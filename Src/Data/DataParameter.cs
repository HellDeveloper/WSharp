using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSharp.Data
{
    /// <summary> 参数
    /// </summary>
    [Serializable]
    public class DataParameter : IDataParameter
    {
        /// <summary> 初始化实例
        /// </summary>
        public DataParameter()
        {
            
        }

        /// <summary> 初始化实例
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <param name="sourceColumn"></param>
        public DataParameter(string parameterName, object value, string sourceColumn)
        {
            this.ParameterName = parameterName;
            this.Value = value;
            this.SourceColumn = sourceColumn;
        }

        /// <summary> 获取或设置参数的 System.Data.DbType
        /// </summary>
        public virtual DbType DbType
        {
            get;
            set;
        }

        /// <summary> 获取或设置一个值，该值指示参数是只可输入、只可输出、双向还是存储过程返回值参数
        /// </summary>
        public virtual ParameterDirection Direction
        {
            get;
            set;
        }

        /// <summary> 获取一个值，该值指示参数是否接受 null 值
        /// </summary>
        public virtual bool IsNullable
        {
            get { return true; }
        }

        /// <summary> 获取或设置 System.Data.IDataParameter 的名称
        /// </summary>
        public virtual string ParameterName
        {
            get;
            set;
        }

        /// <summary>  
        /// </summary>
        public virtual DataRowVersion SourceVersion
        {
            get;
            set;
        }

        /// <summary> 获取或设置该参数的值
        /// </summary>
        public virtual object Value
        {
            get;
            set;
        }

        /// <summary> 获取或设置源列的名称 + 比较运算符
        /// </summary>
        public virtual string SourceColumn
        {
            get;
            set;
        }

    }
}
