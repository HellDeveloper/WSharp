using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSharp.Core
{
	#region bytes
	/// <summary>
    /// 
    /// </summary>
	public static partial class EConvertType
	{
				
		/// <summary>
        /// 转换为字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>字节数组</returns>
		public static byte[] GetBytes(this short value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <summary>
        /// 由字节数组中指定的位置转换
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="startIndex">开始的位置</param>
        /// <returns></returns>
		public static short ToShort(this byte[] bytes, int startIndex = 0)
		{
			return BitConverter.ToInt16(bytes, startIndex);
		}

		
		/// <summary>
        /// 转换为字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>字节数组</returns>
		public static byte[] GetBytes(this int value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <summary>
        /// 由字节数组中指定的位置转换
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="startIndex">开始的位置</param>
        /// <returns></returns>
		public static int ToInt(this byte[] bytes, int startIndex = 0)
		{
			return BitConverter.ToInt32(bytes, startIndex);
		}

		
		/// <summary>
        /// 转换为字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>字节数组</returns>
		public static byte[] GetBytes(this long value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <summary>
        /// 由字节数组中指定的位置转换
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="startIndex">开始的位置</param>
        /// <returns></returns>
		public static long ToLong(this byte[] bytes, int startIndex = 0)
		{
			return BitConverter.ToInt64(bytes, startIndex);
		}

		
		/// <summary>
        /// 转换为字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>字节数组</returns>
		public static byte[] GetBytes(this ushort value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <summary>
        /// 由字节数组中指定的位置转换
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="startIndex">开始的位置</param>
        /// <returns></returns>
		public static ushort ToUShort(this byte[] bytes, int startIndex = 0)
		{
			return BitConverter.ToUInt16(bytes, startIndex);
		}

		
		/// <summary>
        /// 转换为字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>字节数组</returns>
		public static byte[] GetBytes(this uint value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <summary>
        /// 由字节数组中指定的位置转换
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="startIndex">开始的位置</param>
        /// <returns></returns>
		public static uint ToUInt(this byte[] bytes, int startIndex = 0)
		{
			return BitConverter.ToUInt32(bytes, startIndex);
		}

		
		/// <summary>
        /// 转换为字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>字节数组</returns>
		public static byte[] GetBytes(this ulong value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <summary>
        /// 由字节数组中指定的位置转换
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="startIndex">开始的位置</param>
        /// <returns></returns>
		public static ulong ToULong(this byte[] bytes, int startIndex = 0)
		{
			return BitConverter.ToUInt64(bytes, startIndex);
		}

		
		/// <summary>
        /// 转换为字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>字节数组</returns>
		public static byte[] GetBytes(this float value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <summary>
        /// 由字节数组中指定的位置转换
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="startIndex">开始的位置</param>
        /// <returns></returns>
		public static float ToFloat(this byte[] bytes, int startIndex = 0)
		{
			return BitConverter.ToSingle(bytes, startIndex);
		}

		
		/// <summary>
        /// 转换为字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>字节数组</returns>
		public static byte[] GetBytes(this double value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <summary>
        /// 由字节数组中指定的位置转换
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="startIndex">开始的位置</param>
        /// <returns></returns>
		public static double ToDouble(this byte[] bytes, int startIndex = 0)
		{
			return BitConverter.ToDouble(bytes, startIndex);
		}

		
		/// <summary>
        /// 转换为字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>字节数组</returns>
		public static byte[] GetBytes(this char value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <summary>
        /// 由字节数组中指定的位置转换
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="startIndex">开始的位置</param>
        /// <returns></returns>
		public static char ToChar(this byte[] bytes, int startIndex = 0)
		{
			return BitConverter.ToChar(bytes, startIndex);
		}

		
		/// <summary>
        /// 转换为字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>字节数组</returns>
		public static byte[] GetBytes(this bool value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <summary>
        /// 由字节数组中指定的位置转换
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="startIndex">开始的位置</param>
        /// <returns></returns>
		public static bool ToBool(this byte[] bytes, int startIndex = 0)
		{
			return BitConverter.ToBoolean(bytes, startIndex);
		}

		
		/// <summary>
        /// 转换为字节数组
        /// </summary>
        /// <param name="value"></param>
		/// <param name="encoding">编码方式（如果为null，使用System.Text.Encoding.Default）</param>
        /// <returns>字节数组</returns>
		public static byte[] GetBytes(this string value, System.Text.Encoding encoding = null)
		{
			if (encoding == null)
				encoding = System.Text.Encoding.Default;
			return encoding.GetBytes(value);
		}

		/// <summary>
        /// 由字节数组中指定的位置转换
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="encoding">编码方式（如果为null，使用System.Text.Encoding.Default）</param>
        /// <returns></returns>
		public static string ToString(this byte[] bytes, System.Text.Encoding encoding = null)
		{
			if (encoding == null)
				encoding = System.Text.Encoding.Default;
			return encoding.GetString(bytes);
		}
	}
	#endregion

	#region TryTo
	/// <summary>
    /// 类型转换工具类
    /// </summary>
	public static partial class EConvertType
    {
	
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>转换失败返回null</returns>
		public static short? TryToShort(object obj)
		{
			if (obj == null)
				return null;
			else if (obj is short)
				return (short)obj;
			short result;
			if(short.TryParse(obj.ToString(), out result))
				return result;
			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="str"></param>
		/// <returns>转换失败返回null</returns>
		public static short? TryToShort(this string str)
		{
			short result;
			if(short.TryParse(str, out result))
				return result;
			return null;
		}
		
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>转换失败返回null</returns>
		public static int? TryToInt(object obj)
		{
			if (obj == null)
				return null;
			else if (obj is int)
				return (int)obj;
			int result;
			if(int.TryParse(obj.ToString(), out result))
				return result;
			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="str"></param>
		/// <returns>转换失败返回null</returns>
		public static int? TryToInt(this string str)
		{
			int result;
			if(int.TryParse(str, out result))
				return result;
			return null;
		}
		
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>转换失败返回null</returns>
		public static long? TryToLong(object obj)
		{
			if (obj == null)
				return null;
			else if (obj is long)
				return (long)obj;
			long result;
			if(long.TryParse(obj.ToString(), out result))
				return result;
			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="str"></param>
		/// <returns>转换失败返回null</returns>
		public static long? TryToLong(this string str)
		{
			long result;
			if(long.TryParse(str, out result))
				return result;
			return null;
		}
		
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>转换失败返回null</returns>
		public static ushort? TryToUShort(object obj)
		{
			if (obj == null)
				return null;
			else if (obj is ushort)
				return (ushort)obj;
			ushort result;
			if(ushort.TryParse(obj.ToString(), out result))
				return result;
			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="str"></param>
		/// <returns>转换失败返回null</returns>
		public static ushort? TryToUShort(this string str)
		{
			ushort result;
			if(ushort.TryParse(str, out result))
				return result;
			return null;
		}
		
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>转换失败返回null</returns>
		public static uint? TryToUInt(object obj)
		{
			if (obj == null)
				return null;
			else if (obj is uint)
				return (uint)obj;
			uint result;
			if(uint.TryParse(obj.ToString(), out result))
				return result;
			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="str"></param>
		/// <returns>转换失败返回null</returns>
		public static uint? TryToUInt(this string str)
		{
			uint result;
			if(uint.TryParse(str, out result))
				return result;
			return null;
		}
		
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>转换失败返回null</returns>
		public static ulong? TryToULong(object obj)
		{
			if (obj == null)
				return null;
			else if (obj is ulong)
				return (ulong)obj;
			ulong result;
			if(ulong.TryParse(obj.ToString(), out result))
				return result;
			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="str"></param>
		/// <returns>转换失败返回null</returns>
		public static ulong? TryToULong(this string str)
		{
			ulong result;
			if(ulong.TryParse(str, out result))
				return result;
			return null;
		}
		
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>转换失败返回null</returns>
		public static float? TryToFloat(object obj)
		{
			if (obj == null)
				return null;
			else if (obj is float)
				return (float)obj;
			float result;
			if(float.TryParse(obj.ToString(), out result))
				return result;
			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="str"></param>
		/// <returns>转换失败返回null</returns>
		public static float? TryToFloat(this string str)
		{
			float result;
			if(float.TryParse(str, out result))
				return result;
			return null;
		}
		
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>转换失败返回null</returns>
		public static double? TryToDouble(object obj)
		{
			if (obj == null)
				return null;
			else if (obj is double)
				return (double)obj;
			double result;
			if(double.TryParse(obj.ToString(), out result))
				return result;
			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="str"></param>
		/// <returns>转换失败返回null</returns>
		public static double? TryToDouble(this string str)
		{
			double result;
			if(double.TryParse(str, out result))
				return result;
			return null;
		}
		
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>转换失败返回null</returns>
		public static decimal? TryToDecimal(object obj)
		{
			if (obj == null)
				return null;
			else if (obj is decimal)
				return (decimal)obj;
			decimal result;
			if(decimal.TryParse(obj.ToString(), out result))
				return result;
			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="str"></param>
		/// <returns>转换失败返回null</returns>
		public static decimal? TryToDecimal(this string str)
		{
			decimal result;
			if(decimal.TryParse(str, out result))
				return result;
			return null;
		}
		
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>转换失败返回null</returns>
		public static char? TryToChar(object obj)
		{
			if (obj == null)
				return null;
			else if (obj is char)
				return (char)obj;
			char result;
			if(char.TryParse(obj.ToString(), out result))
				return result;
			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="str"></param>
		/// <returns>转换失败返回null</returns>
		public static char? TryToChar(this string str)
		{
			char result;
			if(char.TryParse(str, out result))
				return result;
			return null;
		}
		
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>转换失败返回null</returns>
		public static bool? TryToBool(object obj)
		{
			if (obj == null)
				return null;
			else if (obj is bool)
				return (bool)obj;
			bool result;
			if(bool.TryParse(obj.ToString(), out result))
				return result;
			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="str"></param>
		/// <returns>转换失败返回null</returns>
		public static bool? TryToBool(this string str)
		{
			bool result;
			if(bool.TryParse(str, out result))
				return result;
			return null;
		}
		
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>转换失败返回null</returns>
		public static System.DateTime? TryToDateTime(object obj)
		{
			if (obj == null)
				return null;
			else if (obj is System.DateTime)
				return (System.DateTime)obj;
			System.DateTime result;
			if(System.DateTime.TryParse(obj.ToString(), out result))
				return result;
			return null;
		}

		/// <summary>
		/// </summary>
		/// <param name="str"></param>
		/// <returns>转换失败返回null</returns>
		public static System.DateTime? TryToDateTime(this string str)
		{
			System.DateTime result;
			if(System.DateTime.TryParse(str, out result))
				return result;
			return null;
		}
		
		/// <summary>
		/// retrun t == null ?  String.Empty : t.ToString();
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="t"></param>
		/// <returns></returns>
		public static string TryToString<T>(this T t) 
		{
			return t == null ? null : t.ToString();
		}
		
	}
	#endregion

}