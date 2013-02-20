using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Logic.Data;

namespace PointOfSale.InstanceDeployment
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConfiguration dbConfig = new DbConfiguration();

            //TODO: Sane arguments (-dbuser=foo, -DataContext=nh etc). For now we will use a pre-set configuration
            foreach (string arg in args)
            {
                switch (arg)
                {
                    
                }
            }
            
        }

        public void InitialiseDb(DbConfiguration config)
        {
            Console.WriteLine("Connecting to the Database...");

            SqlConnection connection = new SqlConnection(config.GetConnectionString());

            EfDataContext efContext = new EfDataContext(connection);

            //Do stuff here...
        }
    }
}
