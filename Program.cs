using Supermarket_mvp1._Repositories;
using Supermarket_mvp1.Models;
using Supermarket_mvp1.Views;
using Supermarket_mvp1.Properties;
using Supermarket_mvp1.Presenters;

namespace Supermarket_mvp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IPayModeView view = new PayModelView();
            IPayModeRepository reposity = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, reposity);
            Application.Run((Form) view);
        }
    }
}