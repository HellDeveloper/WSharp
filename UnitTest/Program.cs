using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using WSharp.Core;
using WSharp.Generic;

namespace UnitTest
{
    public class Model
    {
        public object Value { get; set; }
    }

    public static class Ex
    {
        [Obsolete("", true)]
        public static void A(this object o)
        { Console.WriteLine("object"); }

        public static void A<T>(this T t) where T : struct
        { Console.WriteLine("T"); }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int i = 100;
            //byte[] bytes = new byte[0]; 
            //NameValueCollection nvc = new NameValueCollection();
            //nvc.Add("Value", "");
            //IDataParameter param = new SqlParameter();
            //param.GetType().IsInstanceOfType
            //encodings();
            int? j = null;
            string s = null;

            Console.WriteLine(i + j);
            Console.WriteLine(i.ToString() + s);
            //Console.WriteLine(s.ToString());

            Console.ReadKey(true);
        }

        private static void encodings()
        {
            string str = "123456";
            Console.WriteLine(Encoding.ASCII.EncodingName);
            encoding(str, Encoding.ASCII);
            Print(str.GetBytes(Encoding.ASCII));

            Console.WriteLine(Encoding.Default.EncodingName);
            encoding(str, Encoding.Default);
            Print(str.GetBytes(Encoding.Default));

            Console.WriteLine(Encoding.Unicode.EncodingName);
            encoding(str, Encoding.Unicode);
            Print(str.GetBytes(Encoding.Unicode));

            Console.WriteLine(Encoding.UTF32.EncodingName);
            encoding(str, Encoding.UTF32);
            Print(str.GetBytes(Encoding.UTF32));

            Console.WriteLine(Encoding.UTF7.EncodingName);
            encoding(str, Encoding.UTF7);
            Print(str.GetBytes(Encoding.UTF7));

            Console.WriteLine(Encoding.UTF8.EncodingName);
            encoding(str, Encoding.UTF8);
            Print(str.GetBytes(Encoding.UTF8));

            Print(BitConverter.GetBytes('我'), false);
            Print(BitConverter.GetBytes('爱'), false);
            Print(BitConverter.GetBytes('中'), false);
            Print(BitConverter.GetBytes('国'), true);


        }

        public static void encoding(string source, Encoding e)
        {
            using (MD5CryptoServiceProvider t = new MD5CryptoServiceProvider())
            {
                byte[] data = t.ComputeHash(source.GetBytes(e));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                    builder.Append(data[i].ToString("x2"));
                Console.WriteLine(builder);
            }
        }

        public static void Print(byte[] bytes, bool writeLine = true)
        {
            foreach (var item in bytes)
            {
                Console.Write(item.ToString() + " ");
            }
            if (writeLine)
            {
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}