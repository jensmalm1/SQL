using System;
using System.Data;
using System.Data.SqlTypes;

namespace sql CRM
{
    class Program
    {

        public void test(string title)
        {
            var sql = @"SELECT [";


            using (SqlConnection connection = new SqlConnection(conString))
                using(Sqlcommand command=new SqlCommannd(sql,connection))


                Command.Parameters.Add(new SqlParameter("apa", title));

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
    }
}
