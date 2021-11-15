using System;
using System.Data.SqlClient;

namespace QuanLyNganHang.Common
{
    public class DBConnection 
    {
        private string host;
        private string username;
        private string password;
        private string DBname;

        private void Init()
        {
            
        }
        public static SqlConnection CreatMainConnection()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source="++";Initial Catalog=Demodb;User ID=sa;Password=demol23";
            cnn = new SqlConnection(connetionString);
            return cnn;
        }
    }

}