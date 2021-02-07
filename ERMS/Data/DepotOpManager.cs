using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Group_27.ERMS.Data
{
    class DepotOpManager
    {

        private MySqlConnection _con = DBcon.Singleton.GetConRes();

        public DataTable GetAllDepotNames()
        {
            DataTable dt = new DataTable();

            using (_con)
            {
                _con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SelectAllDepotNames", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);    
            }
            return dt;
        }

        public DataTable GetAllItemNames()
        {
            DataTable dt = new DataTable();

            using (_con)
            {
                _con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SelectAllItemNames", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetAllStocks()
        {
            DataTable dt = new DataTable();

            using (_con)
            {
                _con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SelectAllStocks", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetStocksByDepotId(int did)
        {
            DataTable dt = new DataTable();

            using (_con)
            {
                _con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SelectStocksByDepotId", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_DepotId", did);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetStocksByItemId(int iid)
        {
            DataTable dt = new DataTable();

            using (_con)
            {
                _con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SelectStocksByItemId", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_ItemId", iid);
                da.Fill(dt);
            }
            return dt;
        }

        public void InsertOrUpdateStock(int did, int iid, int quantity)
        {
            using (_con)
            {
                _con.Open();
                MySqlCommand cmd = new MySqlCommand("StockInsertOrUpdate", _con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_DepotId", did);
                cmd.Parameters.AddWithValue("_ItemId", iid);
                cmd.Parameters.AddWithValue("_Quantity", quantity);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllDepotLogs()
        {
            DataTable dt = new DataTable();

            using (_con)
            {
                _con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SelectAllDepotLogs", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetDepotLogsByDepotId(int did)
        {
            DataTable dt = new DataTable();

            using (_con)
            {
                _con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SelectDepotLogsByDepotId", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_DepotId", did);
                da.Fill(dt);
            }
            return dt;
        }

        public void InsertDepotLog(int did, int iid, string type, int quantity)
        {
            using (_con)
            {
                _con.Open();
                MySqlCommand cmd = new MySqlCommand("DepotLogInsert", _con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_DepotId", did);
                cmd.Parameters.AddWithValue("_ItemId", iid);
                cmd.Parameters.AddWithValue("_LogType", type);
                cmd.Parameters.AddWithValue("_Quantity", quantity);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDepotLog(int lid , string desc)
        {
            using (_con)
            {
                _con.Open();
                MySqlCommand cmd = new MySqlCommand("DepotLogUpdate", _con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_LogId", lid);
                cmd.Parameters.AddWithValue("_LogDesc", desc);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
