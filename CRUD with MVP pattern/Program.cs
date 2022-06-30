using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_with_MVP_pattern.Models;
using CRUD_with_MVP_pattern.Presenters;
using CRUD_with_MVP_pattern.Views;
using CRUD_with_MVP_pattern._Repositories;
using System.Configuration;

namespace CRUD_with_MVP_pattern
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = "Data Source=(local);Initial Catalog=VeterinaryDb;Integrated Security=True";
            IMainView view = new MainView();
            new MainPresenter(view,sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
