using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using FP_Group_27.ERMS.Model;

namespace FP_Group_27.ERMS.Data
{
    class ItemManager: DbCommon<Item>
    {

        private MySqlConnection _con;

        public ItemManager()
        {
            _con = DBcon.Singleton.GetConRes();
        }

        public override Item Get(int itemId)
        {
            throw new NotImplementedException();
        }

        public override DataTable GetAll()
        {
            DataTable dt = new DataTable();

            using (_con)
            {
                _con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SelectAllItems", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            return dt;
        }

        public override void InsertAll(IEnumerable<Item> ts)
        {
            using (_con)
            {
                _con.Open();
                foreach (Item item in ts)
                {
                    MySqlCommand cmd = new MySqlCommand("ItemInsert", _con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_ItemId", item.Id);
                    cmd.Parameters.AddWithValue("_ItemName", item.Name);
                    cmd.Parameters.AddWithValue("_Catagory", item.Catagory);
                    cmd.ExecuteNonQuery();

                    foreach (string key in item.Attributes.Keys)
                    {
                        cmd = new MySqlCommand("InsertItemAttribute", _con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_ItemId", item.Id);
                        cmd.Parameters.AddWithValue("_Attribute", key);
                        cmd.Parameters.AddWithValue("_AttValue", item.Attributes[key]);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public override void Insert(Item item)
        {
            using (_con)
            {
                _con.Open();
                MySqlCommand cmd = new MySqlCommand("ItemInsertOrUpdate", _con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_ItemId", item.Id);
                cmd.Parameters.AddWithValue("_ItemName", item.Name);
                cmd.Parameters.AddWithValue("_Catagory", item.Catagory);
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("ItemAttributesDeleteByItemId", _con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_ItemId", item.Id);
                cmd.ExecuteNonQuery();

                foreach (string key in item.Attributes.Keys)
                {
                    cmd = new MySqlCommand("InsertItemAttribute", _con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_ItemId", item.Id);
                    cmd.Parameters.AddWithValue("_Attribute", key);
                    cmd.Parameters.AddWithValue("_AttValue", item.Attributes[key]);
                    cmd.ExecuteNonQuery();
                }   
            }
        }

        public void Insert(int itemId, string itemName, string itemCatagory, Dictionary<string, string> atts)
        {
            Insert((Item)Activator.CreateInstance(typeof(Item), itemId, itemName, itemCatagory, atts));
        }

        public override DataTable Search(string searchText)
        {
            DataTable dt = new DataTable();

            using (_con)
            {
                _con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("ItemFilterByNameOrCatagory", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_SearchValue", searchText);
                da.Fill(dt);
            }
            return dt;
        }

        public override void Delete(int itemId)
        {
            using (_con)
            {
                _con.Open();
                MySqlCommand cmd = new MySqlCommand("ItemDeleteByID", _con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_ItemId", itemId);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetItemAttributes(int iid)
        {
            DataTable dt = new DataTable();

            using (_con)
            {
                _con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SelectItemAttributesByItemId", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_ItemId", iid);
                da.Fill(dt);
            }
            return dt;
        }

    }
}
