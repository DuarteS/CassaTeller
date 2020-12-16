using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CassaTeller
{

    class DBaccess
    {
        OleDbConnection con;

        public DBaccess()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= CassaData.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            //cmd.CommandText = "INSERT INTO Cassa(`Date`,`Time`,`Worker`,`Total`,`InCassa`,`Description`) VALUES('17/12/2020','12:12','1','3465,12',False,'Test');";
            //cmd.Connection = con;
            //cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}