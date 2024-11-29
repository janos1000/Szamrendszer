using MySql.Data.MySqlClient;


namespace SoccerTeam
{
    public class connect
    {
        public MySqlConnection Connection;
        public string Host;
        public string Database;
        public string User;
        public string Password;
        public string ConnectionString;

        public connect()
        {
            Host = "localhost";
            Database = "Football";
            User = "root";
            Password = "";

            ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" +
                User + ";PASSWORD=" + Password + ";SslMode=None";

            Connection = new MySqlConnection(ConnectionString);
        }
    }
}