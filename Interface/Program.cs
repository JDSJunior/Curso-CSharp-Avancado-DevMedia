using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnect con = new SQLConnect() { ConnectionString = "Oracle" };
            con.Open();
            con.Close();

            Console.ReadKey();
        }
    }
}
