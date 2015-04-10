using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSharp.Core
{
	/// <summary>
    /// 
    /// </summary>
	public static class ByteConverter
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

}