using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Globalization;

namespace CassaTeller
{

    class DBaccess
    {
        private static DBaccess instance = null;

        public static DBaccess Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBaccess();
                }
                return instance;
            }
        }


        readonly OleDbConnection connection;

        public DBaccess()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= CassaData.accdb");
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                throw new Exception("Cant find database");
            }
            finally
            {
                connection.Close();
            }


            
        }

        public void UpdateDayCassa(CassaItem cassaItem)
        {
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "SELECT * FROM Cassa WHERE `Date` = @date AND `InCassa` = @inCassa;";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@date", cassaItem.DateTime.Date);
            cmd.Parameters.AddWithValue("@inCassa", cassaItem.InCassa);
            OleDbDataReader dr = cmd.ExecuteReader();

            bool Found = false;

            if (dr.HasRows)
            {
                Found = true;
            }

            connection.Close();

            if (Found)
            {
                cmd = connection.CreateCommand();
                connection.Open();
                cmd.CommandText = "UPDATE `Cassa` SET `Worker` = @worker ,`Total` = @total , `Time` = @time,`Description` = @desc WHERE `Date` = @date AND `InCassa` = @inCassa;";
                cmd.Connection = connection;

                cmd.Parameters.AddWithValue("@worker", cassaItem.Worker);
                cmd.Parameters.AddWithValue("@total", cassaItem.Total.ToString().Replace(".",","));
                cmd.Parameters.AddWithValue("@time", cassaItem.DateTime.TimeOfDay);
                cmd.Parameters.AddWithValue("@desc", cassaItem.Description);
                cmd.Parameters.AddWithValue("@date", cassaItem.DateTime.Date);
                cmd.Parameters.AddWithValue("@inCassa", cassaItem.InCassa);
                cmd.ExecuteNonQuery();
                connection.Close();
            } else
            {
                AddCassaItem(cassaItem);
            }


        }


        public CassaItem[] GetCassaItemRange(DateTime day1, DateTime day2)
        {
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "SELECT * FROM Cassa WHERE (Date BETWEEN  @startDay  AND @endDay );";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@startDay", day1.Date);
            cmd.Parameters.AddWithValue("@endDay", day2.Date);
            OleDbDataReader dr = cmd.ExecuteReader();

            List<CassaItem> cassaItems = new List<CassaItem>();

            while (dr.Read())
            {
                DateTime date = Convert.ToDateTime(dr[1]);
                DateTime time = Convert.ToDateTime(dr[2]);
                DateTime dateTime = date.Date + time.TimeOfDay;
                int worker = int.Parse(dr[3].ToString());
                decimal total = decimal.Parse(dr[4].ToString());
                bool inCassa = (bool)dr[5];
                string desc = dr[6].ToString();
                CassaItem item = new CassaItem(dateTime, worker, total, inCassa, desc);
                cassaItems.Add(item);
            }

            connection.Close();

            return cassaItems.ToArray();
        }

        public void AddCassaItem(CassaItem item)
        {
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "INSERT INTO Cassa(`Date`,`Time`,`Worker`,`Total`,`InCassa`,`Description`) VALUES( @date , @time , @worker , @total , @inCassa , @desc );";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@date", item.DateTime.Date);
            cmd.Parameters.AddWithValue("@time", item.DateTime.TimeOfDay);
            cmd.Parameters.AddWithValue("@worker", item.Worker);
            cmd.Parameters.AddWithValue("@total", item.Total.ToString().Replace(".", ","));
            cmd.Parameters.AddWithValue("@inCassa", item.InCassa);
            cmd.Parameters.AddWithValue("@desc", item.Description);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public CassaItem[] GetCassaDayItems(DateTime selectedDate)
        {
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "SELECT * FROM Cassa WHERE Date = @date";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@date", selectedDate.Date);
            OleDbDataReader dr = cmd.ExecuteReader();

            List<CassaItem> cassaItems = new List<CassaItem>();

            while (dr.Read())
            {
                DateTime date = Convert.ToDateTime(dr[1]);
                DateTime time = Convert.ToDateTime(dr[2]);
                DateTime dateTime = date.Date + time.TimeOfDay;
                int worker = int.Parse(dr[3].ToString());
                decimal total = decimal.Parse(dr[4].ToString());
                bool inCassa = (bool)dr[5];
                string desc = dr[6].ToString();
                CassaItem item = new CassaItem(dateTime,worker,total,inCassa,desc);
                cassaItems.Add(item);
            }

            connection.Close();

            return cassaItems.ToArray();
        }

        public Worker[] GetWorkers()
        {
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "SELECT * FROM Workers";
            cmd.Connection = connection;
            OleDbDataReader dr = cmd.ExecuteReader();

            List<Worker> Workers = new List<Worker>();

            while (dr.Read())
            {
                Worker worker = new Worker(int.Parse(dr[0].ToString()),dr[1].ToString(), dr[2].ToString());
                Workers.Add(worker);
            }

            connection.Close();

            return Workers.ToArray();
        }


        public void addWorker(string firstName, string lastName)
        {
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "INSERT INTO Workers(`FirstName`,`LastName`) VALUES(@firstName , @lastName );";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}