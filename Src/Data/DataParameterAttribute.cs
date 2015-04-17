using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSharp.Data
{
    /// <summary> 
    /// </summary>
    public class DataParameterAttribute : Attribute
    {

        /// <summary> 初始化实例
        /// </summary>
        public DataParameterAttribute()
        {
            
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

        /// <summary>  Value 值的状态
        /// </summary>
        public virtual DataRowVersion SourceVersion
        {
            get { return DataRowVersion.Original; }
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
