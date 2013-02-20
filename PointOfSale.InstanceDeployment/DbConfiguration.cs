using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PointOfSale.InstanceDeployment
{
    public class DbConfiguration
    {
        public string Server { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        public bool UseWindowsAuth { get; set; }

        public DbConfiguration()
        {
            Server = "LOCALHOST\\SQLEXPRESS";
            UseWindowsAuth = false;
        }

        public string GetConnectionString()
        {
            StringBuilder builder = new StringBuilder();

            SqlConnectionStringBuilder.AppendKeyValuePair(builder, "Server", Server);
            SqlConnectionStringBuilder.AppendKeyValuePair(builder, "Database", Database);

            if (!UseWindowsAuth)
            {
                SqlConnectionStringBuilder.AppendKeyValuePair(builder, "User Id", Username);
                SqlConnectionStringBuilder.AppendKeyValuePair(builder, "Password", Password);
            }
            else
            {
                SqlConnectionStringBuilder.AppendKeyValuePair(builder, "Trusted_Connection", "True");
            }

            return builder.ToString();
        }
    }
}
