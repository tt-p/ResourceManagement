using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Group_27.ERMS.Data
{
    class DBcon
    {
        private static string resManConStr = 
            ConfigurationManager.ConnectionStrings["FP_Group_27.Properties.Settings.ResManConStr"].ConnectionString;

        private static string loginConStr =
            ConfigurationManager.ConnectionStrings["FP_Group_27.Properties.Settings.LoginConStr"].ConnectionString;

        private static DBcon singleton;
        private static MySqlConnection conRes;
        private static MySqlConnection conLogin;

        private DBcon() { }

        public static DBcon Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = new DBcon();

                conRes = new MySqlConnection(resManConStr);
                conLogin = new MySqlConnection(loginConStr);

                return singleton;
            }
        }

        public MySqlConnection GetConLogin()
        {
            try
            {
                conLogin.Open();
            }
            catch (Exception)
            {
            }
            finally
            {
                conLogin.Close();
            }
            return conLogin;
        }

        public MySqlConnection GetConRes()
        {
            try
            {
                conRes.Open();
            }
            catch (Exception)
            {
            }
            finally
            {
                conRes.Close();
            }
            return conRes;
        } 
    }
}
