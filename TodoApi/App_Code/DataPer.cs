using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using TodoApi.Models;

namespace TodoApi.App_Code
{
    public class DataPer
    {
        MySqlConnection conn;

        public DataPer()
        {
            string myConnsetring;
            myConnsetring = "server=127.0.0.1;uid=root;pwd=average1;database=employeedb;";

            try
            {
                conn = new MySqlConnection(myConnsetring);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public long saveData(Data dataSave)
        {
            string sql = "INSERT INTO tblpersonnel (FirstName, LastName, PayRate, StartDate, EndDate) values ('" + dataSave.FirstName + "','" + dataSave.LastName + "','" + dataSave.PayRate + "','" + dataSave.StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dataSave.EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "');";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            long id = cmd.LastInsertedId;
            return id;
        }
    }
}
