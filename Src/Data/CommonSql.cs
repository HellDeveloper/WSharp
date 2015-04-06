﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSharp.Generic;
using WSharp.Core;

namespace WSharp.Data
{
    /// <summary>
    /// 
    /// </summary>
    public static class CommonSql
    {
        #region Help
        /// <summary>
        /// 默认的参数名的前缀
        /// </summary>
        public const char DEFAULT_PARAMETER_NAME_PERFIX = '@';

        /// <summary>
        /// 参数名的前缀
        /// </summary>
        public static char ParameterNamePerfix
        {
            get 
            {
                return System.Configuration.ConfigurationManager.AppSettings["ParameterNamePerfix"].TryToChar() ?? CommonSql.DEFAULT_PARAMETER_NAME_PERFIX;
            }
        }
        
        /// <summary>获取字段名</summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string GetFieldName<T>(T param) where T : IDataParameter
        {
            if (String.IsNullOrWhiteSpace(param.SourceColumn) && !String.IsNullOrWhiteSpace(param.ParameterName))
                return param.ParameterName.TrimStart(EDataParameter.PARAMETER_NAME_PERFIX);
            return Assist.GetBeforeFirstWhiteSpace(param.SourceColumn);
        }

        /// <summary>格式化Sql的值</summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string FormatSqlValue<T>(this T param) where T : IDataParameter
        {
            if (param.Value == null || DBNull.Value.Equals(param.Value))
                return "NULL";
            else if (param.Value is String)
                if (param.SourceVersion == DataRowVersion.Original && param.GetComparer().EndsWith(" like", StringComparison.OrdinalIgnoreCase))
                    return String.Format("'%{0}%'", ((String)param.Value).Replace("'", "''"));
                else
                    return String.Format("'{0}'", ((String)param.Value).Replace("'", "''"));
            else if (param is DateTime)
                return String.Format("'{0}'", ((DateTime)param.Value).ToString(Assist.ISO_DATETIME_FORMAT));
            else if (param.Value is bool)
                return ((bool)param.Value) == false ? "0" : "1";
            else
                return param.ToString();
        }

        /// <summary>获取ParameterName</summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object GetParameterName<T>(T param) where T : IDataParameter
        {
            return param.ParameterName;
        }

        /// <summary></summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object GetParameterValue(IDataParameter param)
        {
            if (String.IsNullOrWhiteSpace(param.ParameterName))
                return param.Value == null ? null : param.Value.ToString();
            if (param.SourceVersion == DataRowVersion.Original && String.IsNullOrWhiteSpace(param.Value.TryToString()))
                return "NULL";
            return CommonSql.FormatSqlValue(param);
        }

        /// <summary></summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object BuildParameterValue(IDataParameter param)
        {
            if (String.IsNullOrWhiteSpace(param.ParameterName))
                return param.Value == null ? null : param.Value.ToString();
            if (param.SourceVersion == DataRowVersion.Original && String.IsNullOrWhiteSpace(param.Value.TryToString()))
                return "NULL";
            return param.ParameterName;
        }

        /// <summary></summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string GetSetSql<T>(T param) where T : IDataParameter
        {
            return String.Format("{0} = {1}", CommonSql.GetFieldName(param), CommonSql.GetParameterValue(param));
        }

        /// <param name="param"></param>
        /// <returns></returns>
        public static string BuildSetSql<T>(T param) where T : IDataParameter
        {
            return String.Format("{0} = {1}", CommonSql.GetFieldName(param), CommonSql.BuildParameterValue(param));
        }
        #endregion

         /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static string ConditionSql(IDataParameter param, Func<IDataParameter, object> func)
        {
            if (String.IsNullOrWhiteSpace(param.ParameterName))
                return param.Value == null ? null : param.Value.ToString();
            if (param.SourceVersion == DataRowVersion.Original)
                if (String.IsNullOrWhiteSpace(param.Value.TryToString()))
                    return null;
            return String.Format("{0}{1}{2}", param.SourceColumn, Assist.WHITE_SPACE, func(param));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static string ConditionSql(IEnumerable<IDataParameter> args, Func<IDataParameter, object> func)
        {
            var temp = EEnumerable.ToStringBuilder(args, func, " AND ");
            return temp == null ? String.Empty : temp.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static string ConditionSql(IEnumerable<IEnumerable<IDataParameter>> args, Func<IEnumerable<IDataParameter>, object> func)
        {
            var temp = EEnumerable.ToStringBuilder(args, func, " OR ");
            return temp == null ? String.Empty : temp.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <param name="table_name"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static string InsertSql(IEnumerable<IDataParameter> args, string table_name, Func<IDataParameter, object> func)
        {
            var tuple = EEnumerable.ToStringBuilder(args, CommonSql.GetFieldName, func, ", ");
            return String.Format("INSERT INTO {0} ({1}) VALUES ({2})", table_name, tuple.Item1, tuple.Item2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <param name="where"></param>
        /// <param name="table_name"></param>
        /// <param name="func_args"></param>
        /// <param name="func_where"></param>
        /// <returns></returns>
        public static string UpdateSql(IEnumerable<IDataParameter> args, IEnumerable<IDataParameter> where, string table_name, Func<IDataParameter, object> func_args, Func<IEnumerable<IDataParameter>, string> func_where)
        {
            var sets = EEnumerable.ToStringBuilder(args, func_args);
            if (sets == null)
                return String.Empty;
            var wheres = func_where(where);
            if (String.IsNullOrWhiteSpace(wheres))
                return String.Format("UPDATE {0} SET {1} ", table_name, sets);
            return String.Format("UPDATE {0} SET {1} WHERE {2}", table_name, sets, wheres);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <param name="table_name"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static string DeleteSql(IEnumerable<IDataParameter> args, string table_name, Func<IEnumerable<IDataParameter>, string> func)
        {
            string where = func(args);
            if (String.IsNullOrWhiteSpace(where))
                return "DELETE FROM " + table_name;
            return String.Format("DELETE FROM {0} WHERE {1}", table_name, where);
        }
        
        /// <summary>
        /// 构建查询的SQL
        /// </summary>
        /// <param name="args">查询条件</param>
        /// <param name="table_name">表名</param>
        /// <param name="func">生成查询条件的方式</param>
        /// <param name="fieldname">查询的字段名(如果是String.Empty || null 就是 *)</param>
        /// <returns>SELECT语句</returns>
        public static string SelectSql(IEnumerable<IDataParameter> args, string table_name, Func<IEnumerable<IDataParameter>, string> func, string fieldname)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("SELECT ");
            if (String.IsNullOrWhiteSpace(fieldname))
                builder.Append("*");
            else
                builder.Append(fieldname);
            builder.Append(" FROM ").Append(table_name);
            string where = func(args);
            if (!String.IsNullOrWhiteSpace(where))
                builder.Append(" WHERE ").Append(where);
            return builder.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string GetConditionSql(this IDataParameter param)
        {
            return CommonSql.ConditionSql(param, CommonSql.FormatSqlValue);
        }

        /// <summary>
        /// AND
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string GetConditionSql(this IEnumerable<IDataParameter> args)
        {
            return CommonSql.ConditionSql(args, CommonSql.GetConditionSql);
        }

        /// <summary>
        /// OR
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string GetConditionSql(this IEnumerable<IEnumerable<IDataParameter>> args)
        {
            return CommonSql.ConditionSql(args, CommonSql.GetConditionSql);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string BuildConditionSql(this IDataParameter param)
        {
            return CommonSql.ConditionSql(param, CommonSql.GetParameterName);
        }

        /// <summary>
        /// AND
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string BuildConditionSql(this IEnumerable<IDataParameter> args)
        {
            return CommonSql.ConditionSql(args, CommonSql.BuildConditionSql);
        }

        /// <summary>
        /// OR
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string BuildConditionSql(this IEnumerable<IEnumerable<IDataParameter>> args)
        {
            return CommonSql.ConditionSql(args, CommonSql.BuildConditionSql);
        }

    }

}
