using FP_Group_27.ERMS.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Group_27.ERMS.Data
{
    class DepotManager : DbCommon<Depot>
    {

        private MySqlConnection _con;

        public DepotManager()
        {
            _con = DBcon.Singleton.GetConRes();
        }

        public override Depot Get(int tid)
        {
            throw new NotImplementedException();
        }

        public override DataTable GetAll()
        {
            DataTable dt = new DataTable();

            using (_con)
            {
                _con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("SelectAllDepots", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            return dt;
        }

        public void Insert(int id, string name, string size, int occupancy, string address)
        {
            Insert(new Depot(id, name, size, occupancy, address));
        }

        public override void Insert(Depot t)
        {
            using (_con)
            {
                _con.Open();
                MySqlCommand cmd = new MySqlCommand("DepotInsertOrUpdate", _con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_DepotId", t.Id);
                cmd.Parameters.AddWithValue("_DepotName", t.Name);
                cmd.Parameters.AddWithValue("_Size", t.Size);
                cmd.Parameters.AddWithValue("_Occupancy", t.Occupancy);
                cmd.Parameters.AddWithValue("_Address", t.Address);
                cmd.ExecuteNonQuery();
            }
        }

        public override void Delete(int tid)
        {
            using (_con)
            {
                _con.Open();
                MySqlCommand cmd = new MySqlCommand("DepotDeleteById", _con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_DepotId", tid);
                cmd.ExecuteNonQuery();
            }
        }

        public override DataTable Search(string searchText)
        {
            DataTable dt = new DataTable();
            using (_con)
            {
                _con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("DepotFilterByName", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_SearchValue", searchText);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
