using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Group_27.ERMS.Data
{
    class LoginManager
    {
        private MySqlConnection _con = DBcon.Singleton.GetConLogin();

        public LoginResult LoginRequest(string userName, string userPass)
        {
            LoginResult _lr = LoginResult.Unauthorized;
            DataTable dt = new DataTable();
            String type = "";

            using (_con)
            {
                _con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("UserLogin", _con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_UserName", userName);
                da.SelectCommand.Parameters.AddWithValue("_UserPass", userPass);
                da.Fill(dt);
            }

            if (dt.Rows.Count > 0)
            {
                type = (dt.Rows[0][0]).ToString();
                _lr = convertResult(type);
            }

            return _lr;
        }

        public enum LoginResult { Factory, Depot, Unauthorized }

        public static LoginResult convertResult(string res)
        {
            switch (res)
            {
                case "Factory":
                    return LoginResult.Factory;
                case "Depot":
                    return LoginResult.Depot;
                default:
                    return LoginResult.Unauthorized;
            }
        }

    }
}
