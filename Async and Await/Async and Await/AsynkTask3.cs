using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
    class AsynkTask3
    {
        public delegate DataTable mymethod(string s);
        public static DataTable dt;
        public static mymethod inv;
        static void Main(string[] args)
        {
            inv = new mymethod(Print);
            inv.BeginInvoke("ahmar", new AsyncCallback(Callback), null);
            Console.ReadLine();
        }
        public static DataTable Print(string q)
        {
            Thread.Sleep(1000);
            Console.WriteLine(q);
            DataTable dt = new DataTable();
            dt.Columns.Add("Age");
            dt.Rows.Add(11);
            dt.Rows.Add(12);
            dt.Rows.Add(13);
            return dt;
        }
        public static void Callback(IAsyncResult t)
        {
            dt = inv.EndInvoke(t);
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["age"].ToString());
            }
        }
    }
}
