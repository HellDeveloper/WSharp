using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using WSharp.Core;
using WSharp.Generic;

namespace UnitTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] array = { '>', '<', '=', 'l' };
            foreach (var item in array)
            {
                Console.WriteLine("{0}:{1}", item, (int)item);
                
            }

            Data data = new Data();
            data.ExecuteSelectSql();
            

            Console.ReadKey(true);
        }


    }
}