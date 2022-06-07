
using MySql.Data.MySqlClient;

namespace Common
{
    public class DBUtilitycs
    {
        private static MySqlConnection sCn;
        public static string Database = "";
        public static string Server = "";
        public static string pass = "";
        public static string user = "";
        public static string s_connect = "";


        public static bool get_connetion_ifo()
        {
            Server = ConfigUtility.GetDBSettingConfig("DATA_SOURCE");
            Database = ConfigUtility.GetDBSettingConfig("DATABASE");
            user = ConfigUtility.GetDBSettingConfig("USER_ID");
            pass = ConfigUtility.GetDBSettingConfig("PASSWORD");

            sCn = new MySqlConnection("Server=" + Server + "; Database=" + Database + "; User Id=" + user + "; password=" + pass + ";");


            return true;
        }
    }
}
