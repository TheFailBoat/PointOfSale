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
            DeploymentConfiguration deployConfig = new DeploymentConfiguration();

            //TODO: Sane arguments (-dbuser=foo, -DataContext=nh etc). For now we will use a pre-set configuration
            if (args.Count() < 1) Exit(0, PrintHelp());
            foreach (string a in args)
            {
                string[] arg = a.Split(new char['='], 2);
                arg[0] = arg[0].Substring(1); //remove '-'
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
                    case "createadmin":
                        deployConfig.CreateAdmin = true;
                        break;
                    case "adminpassword":
                        if (arg.Count() < 2) Exit(0, "You must provide a password!");
                        deployConfig.AdminPassword = arg[1];
                        break;
                    case "shell":
                        Exit(0, "WIP!!");
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

        public void InitialiseDb(DbConfiguration dbConfig, DeploymentConfiguration deployConfig)
        {
            Console.WriteLine("Connecting to the Database...");

            SqlConnection connection = new SqlConnection(dbConfig.GetConnectionString());
            try
            {
                EfDataContext efContext = new EfDataContext(connection);
                if (deployConfig.CreateAdmin)
                {
                    if (string.IsNullOrWhiteSpace(deployConfig.AdminPassword))
                    {
                        Console.WriteLine("An Administrator password was not specified.");
                        Console.WriteLine("Skipping admin creation because of this.");
                    }
                    else
                    {
                        //create an admin user
                    }
                }
            }
            catch(SqlException se)
            {
                Exit(1, "A problem occured whilst querying the Database:\n" + se.Message);
            }

            //more stuff here
        }

        static string PrintHelp()
        {
            string helpText = "TFB PointOfSale Instance Deployment Manager\n";
            helpText += "Reccomended Usage: posDeploy.exe -server=localhost -db=tfbpos -trustedConnection\n";
            helpText += "\n";
            helpText += "Deploys new PointOfSale databases on MSSQL Server.\n";
            helpText += "By default no action will take place after a connection is established.\n";
            helpText += "This may be desirable, as the Database structure will be created anyway\n";
            helpText += "\n";
            helpText += "Command Line Arguments for Database Connection:\n";
            helpText += "-Server=localhost\\SQLEXPRESS - The MSSQL Server to connect to.\n";
            helpText += "-Database=PointOfSale - The database to use on the SQL Server.\n";
            helpText += "-Username=sa - The SQL User to connect with (SQL Authentication)\n";
            helpText += "-Password=letmein - The Password to authenticate with (SQL Authentication)\n";
            helpText += "-TrustedConnection - Use Windows Credentials (More secure)\n";
            helpText += "\n";
            helpText += "Command Line Arguments for Deployment:\n";
            helpText += "-CreateAdmin - Creates an Admin user. -AdminPassword sets password.\n";
            helpText += "-AdminPassword=password - The password for the POS \"Admin\" User.\n";
            helpText += "\n";
            helpText += "A PointOfSale Management Shell can be opened by using the -shell argument\n";
            helpText += "The database must already be deployed and you will be asked to Login as Admin.\n";
            return helpText;
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
