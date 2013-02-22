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
            if (args.Count() < 1) PrintHelp();
            foreach (string a in args)
            {
                string[] arg = a.Split(new char['='], 2);
                switch (arg[0].ToLower())
                {
                    case "server":
                        dbConfig.Server = arg[1];
                        break;
                    case "database":
                    case "db":
                        dbConfig.Database = arg[1];
                        break;
                    case "trustedconnection":
                        if (string.IsNullOrEmpty(dbConfig.Username) && string.IsNullOrEmpty(dbConfig.Password))
                        {
                            dbConfig.UseWindowsAuth = true;
                            break;
                        }
                        if (arg.Count() < 2) Exit(0, "You cannot use both Trusted and SQL Authentication!");
                        Exit(0);
                        break;
                    case "username":
                        if (arg.Count() < 2) Exit(0, "You must provide a username!");
                        if (!dbConfig.UseWindowsAuth)
                        {
                            dbConfig.Username = arg[1];
                            break;
                        }
                        if (arg.Count() < 2) Exit(0, "You cannot use both Trusted and SQL Authentication!");
                        break;
                    case "password":
                        if (arg.Count() < 2) Exit(0, "You must provide a password!");
                        if (!dbConfig.UseWindowsAuth)
                        {
                            dbConfig.Password = arg[1];
                            break;
                        }
                        if (arg.Count() < 2) Exit(0, "You cannot use both Trusted and SQL Authentication!");
                        break;
                    default:
                        //invalid argument
                        Console.WriteLine("The argument " + arg + " is invalid.");
                        PrintHelp();
                        Exit();
                        break;
                }
            }
            //Verify the Database Configuration
            if (string.IsNullOrWhiteSpace(dbConfig.Server) || string.IsNullOrWhiteSpace(dbConfig.Database))
                Exit(0, "You must provide a Server and Database!");
            if (!dbConfig.UseWindowsAuth)
            {
                if (string.IsNullOrWhiteSpace(dbConfig.Username))
                    Exit(0, "A Username must be provided when using SQL Server Authentication!");
                if (string.IsNullOrWhiteSpace(dbConfig.Password))
                    Exit(0, "A Password must be provided when using SQL Server Authentication!");
            }
            Exit();
        }

        public void InitialiseDb(DbConfiguration config)
        {
            Console.WriteLine("Connecting to the Database...");

            SqlConnection connection = new SqlConnection(config.GetConnectionString());
            try
            {
                connection.Open();
                Console.WriteLine("Test Connection suceeded");
            }
            catch(SqlException se)
            {
                Exit(1, "A problem occured connecting to the database: " + se.Message);
            }
            finally
            {
                connection.Close();
            }

            EfDataContext efContext = new EfDataContext(connection);
            
            //more stuff here
        }

        static void PrintHelp()
        {
            Console.WriteLine("");
            Console.WriteLine("TFB PointOfSale Instance Deployment Manager");
            Console.WriteLine("");
            Console.WriteLine("Reccomended Usage: posDeploy.exe -server=localhost -db=tfbpos -trustedConnection");
            Console.WriteLine("");
            Console.WriteLine("Deploys new PointOfSale databases on MSSQL Server");
            Console.WriteLine("");
            Console.WriteLine("Command Line Arguments:");
            Console.WriteLine("-Server=localhost\\SQLEXPRESS - The MSSQL Server to connect to.");
            Console.WriteLine("-Database=PointOfSale - The database to use on the SQL Server.");
            Console.WriteLine("-Username=sa - The SQL User to connect with (Cannot be used in a Trusted Connection.)");
            Console.WriteLine("-Password=letmein - The Password to authenticate with (Cannot be used in a Trusted Connection.)");
            Console.WriteLine("-TrustedConnection - Use Windows Credentials (Reccomended. Cannot be used with SQL authentication.)");

        }

        static void Exit(int errorCode, string error)
        {
            Console.WriteLine(error);
            Exit(0);
        }

        static void Exit()
        {
            Exit(0);
        }

        static void Exit(int errorCode)
        {
            //Development!
            Console.WriteLine("The Application has asked to exit with error code " + errorCode);
            Console.Read();
            Environment.Exit(errorCode);
        }
    }
}
