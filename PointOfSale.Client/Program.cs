using System;
using System.Web.Mvc;
using System.Windows.Forms;
using Autofac;
using Autofac.Integration.Mvc;
using PointOfSale.Logic.Data;

namespace PointOfSale.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            BuildContainer(builder);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainEntryForm());
        }

        private static void BuildContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<DataModule>();
        }
    }
}
