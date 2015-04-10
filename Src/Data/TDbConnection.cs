using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSharp.Data
{
    /// <summary> 关系型数据库连接对象
    /// </summary>
    public class TDbConnection : IDbConnection
    {
        /// <summary> 关系型数据库连接对象
        /// </summary>
        private IDbConnection _db_connection;

        /// <summary> 构造函数
        /// </summary>
        /// <param name="conn">关系型数据库连接对象</param>
        public TDbConnection(IDbConnection conn)
        {
            this._db_connection = conn;
        }

        /// <summary> 开始数据库事务
        /// </summary>
        /// <param name="il">连接的事务锁定行为</param>
        /// <returns>新事务的对象</returns>
        public virtual IDbTransaction BeginTransaction(IsolationLevel il)
        {
            return this.BeginTransaction(il);
        }

        /// <summary> 开始数据库事务
        /// </summary>
        /// <returns>新事务的对象</returns>
        public virtual IDbTransaction BeginTransaction()
        {
            return this.BeginTransaction();
        }

        /// <summary> 更改当前数据库
        /// </summary>
        /// <param name="databaseName">要代替当前数据库进行使用的数据库的名称</param>
        public virtual void ChangeDatabase(string databaseName)
        {
            this._db_connection.ChangeDatabase(databaseName);
        }

        /// <summary> 关闭数据库的连接
        /// </summary>
        public virtual void Close()
        {
            this._db_connection.Close();
        }

        /// <summary> 获取或设置用于打开数据库的字符串
        /// </summary>
        public virtual string ConnectionString
        {
            get
            {
                return this._db_connection.ConnectionString;
            }
            set
            {
                this._db_connection.ConnectionString = value;
            }
        }

        /// <summary> 获取在尝试建立连接时终止尝试并生成错误之前所等待的时间
        /// </summary>
        public virtual int ConnectionTimeout
        {
            get { return this._db_connection.ConnectionTimeout; }
        }

        /// <summary> 创建并返回一个与该连接相关联的 Command 对象
        /// </summary>
        /// <returns>一个与该连接相关联的 Command 对象</returns>
        public virtual IDbCommand CreateCommand()
        {
            return this._db_connection.CreateCommand();
        }

        /// <summary> 获取当前数据库或连接打开后要使用的数据库的名称
        /// </summary>
        public virtual string Database
        {
            get { return this._db_connection.Database; }
        }

        /// <summary> 打开一个数据库连接，由 ConnectionString 属性指定
        /// </summary>
        public virtual void Open()
        {
            this._db_connection.Open();
        }

        /// <summary> 获取连接的当前状态
        /// </summary>
        public virtual ConnectionState State
        {
            get { return this._db_connection.State; }
        }

        /// <summary> 执行与释放或重置非托管资源相关的应用程序定义的任务
        /// </summary>
        public virtual void Dispose()
        {
            this._db_connection.Dispose();
        }

        /// <summary> 参数名称的前缀
        /// </summary>
        public virtual char ParameterNamePrefix
        {
            get { return '@'; }
        }

    }

    /// <summary> 关系型数据库连接对象
    /// </summary>
    public class TDbConnection<T> : TDbConnection where T : IDbConnection, new()
    {
        /// <summary> 构造函数
        /// </summary>
        public TDbConnection() : base(new T())
        {

        }

    }

}
