using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Globalization;
using System.IO;

namespace KassaTeller
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
            string localAppData =
            Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData);
            string userFilePath
              = Path.Combine(localAppData, "KassaTeller");

            if (!Directory.Exists(userFilePath))
                Directory.CreateDirectory(userFilePath);

            //if it's not already there, 
            //copy the file from the deployment location to the folder
            string sourceFilePath = Path.Combine(
              System.Windows.Forms.Application.StartupPath, "KassaData.accdb");
            string destFilePath = Path.Combine(userFilePath, "KassaData.accdb");
            if (!File.Exists(destFilePath))
                File.Copy(sourceFilePath, destFilePath);


            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= "+destFilePath);
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

       
        public void UpdateDayKassa(KassaItem cassaItem)
        {
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "SELECT * FROM Kassa WHERE `Date` = @date AND `InKassa` = @inKassa;";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@date", cassaItem.DateTime.Date);
            cmd.Parameters.AddWithValue("@inKassa", cassaItem.InKassa);
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
                cmd.CommandText = "UPDATE `Kassa` SET `Worker` = @worker ,`Total` = @total , `Time` = @time,`Description` = @desc WHERE `Date` = @date AND `InKassa` = @inKassa;";
                cmd.Connection = connection;

                cmd.Parameters.AddWithValue("@worker", cassaItem.Worker);
                cmd.Parameters.AddWithValue("@total", cassaItem.Total.ToString().Replace(".",","));
                cmd.Parameters.AddWithValue("@time", cassaItem.DateTime.TimeOfDay);
                cmd.Parameters.AddWithValue("@desc", cassaItem.Description);
                cmd.Parameters.AddWithValue("@date", cassaItem.DateTime.Date);
                cmd.Parameters.AddWithValue("@inKassa", cassaItem.InKassa);
                cmd.ExecuteNonQuery();
                connection.Close();
            } else
            {
                AddKassaItem(cassaItem);
            }


        }


        public KassaItem[] GetKassaItemRange(DateTime day1, DateTime day2)
        {
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "SELECT * FROM Kassa WHERE (Date BETWEEN  @startDay  AND @endDay );";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@startDay", day1.Date);
            cmd.Parameters.AddWithValue("@endDay", day2.Date);
            OleDbDataReader dr = cmd.ExecuteReader();

            List<KassaItem> cassaItems = new List<KassaItem>();

            while (dr.Read())
            {
                DateTime date = Convert.ToDateTime(dr[1]);
                DateTime time = Convert.ToDateTime(dr[2]);
                DateTime dateTime = date.Date + time.TimeOfDay;
                int worker = int.Parse(dr[3].ToString());
                decimal total = decimal.Parse(dr[4].ToString());
                bool inKassa = (bool)dr[5];
                string desc = dr[6].ToString();
                KassaItem item = new KassaItem(dateTime, worker, total, inKassa, desc);
                cassaItems.Add(item);
            }

            connection.Close();

            return cassaItems.ToArray();
        }

        public void AddKassaItem(KassaItem item)
        {
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "INSERT INTO Kassa(`Date`,`Time`,`Worker`,`Total`,`InKassa`,`Description`) VALUES( @date , @time , @worker , @total , @inKassa , @desc );";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@date", item.DateTime.Date);
            cmd.Parameters.AddWithValue("@time", item.DateTime.TimeOfDay);
            cmd.Parameters.AddWithValue("@worker", item.Worker);
            cmd.Parameters.AddWithValue("@total", item.Total.ToString().Replace(".", ","));
            cmd.Parameters.AddWithValue("@inKassa", item.InKassa);
            cmd.Parameters.AddWithValue("@desc", item.Description);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public KassaItem[] GetKassaDayItems(DateTime selectedDate)
        {
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "SELECT * FROM Kassa WHERE Date = @date";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@date", selectedDate.Date);
            OleDbDataReader dr = cmd.ExecuteReader();

            List<KassaItem> cassaItems = new List<KassaItem>();

            while (dr.Read())
            {
                DateTime date = Convert.ToDateTime(dr[1]);
                DateTime time = Convert.ToDateTime(dr[2]);
                DateTime dateTime = date.Date + time.TimeOfDay;
                int worker = int.Parse(dr[3].ToString());
                decimal total = decimal.Parse(dr[4].ToString());
                bool inKassa = (bool)dr[5];
                string desc = dr[6].ToString();
                KassaItem item = new KassaItem(dateTime,worker,total,inKassa,desc);
                cassaItems.Add(item);
            }

            connection.Close();

            return cassaItems.ToArray();
        }

        public KassaItem[] GetAllItems()
        {
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "SELECT * FROM Kassa;";
            cmd.Connection = connection;
            OleDbDataReader dr = cmd.ExecuteReader();

            List<KassaItem> cassaItems = new List<KassaItem>();

            while (dr.Read())
            {
                DateTime date = Convert.ToDateTime(dr[1]);
                DateTime time = Convert.ToDateTime(dr[2]);
                DateTime dateTime = date.Date + time.TimeOfDay;
                int worker = int.Parse(dr[3].ToString());
                decimal total = decimal.Parse(dr[4].ToString());
                bool inKassa = (bool)dr[5];
                string desc = dr[6].ToString();
                KassaItem item = new KassaItem(dateTime, worker, total, inKassa, desc);
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

        public Worker GetWorkerByID(int ID)
        {

            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "SELECT * FROM Workers WHERE ID = @id";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@id", ID);
            OleDbDataReader dr = cmd.ExecuteReader();

            Worker Worker = null;

            while (dr.Read())
            {
                Worker = new Worker(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString());
            }

            connection.Close();

            return Worker;
        }

        public void UpdateWorkerInfo(int id, string firstName, string lastName)
        {
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "UPDATE `Workers` SET `FirstName` = @fName ,`LastName` = @lName WHERE `ID` = @id;";
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@fName", firstName);
            cmd.Parameters.AddWithValue("@lName", lastName);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}