using CarRental.Core;
using CarRental.Core.Common;
using CarRental.Core.Data;
using CarRental.Core.Logic;
using CarRental.Core.Data.Repositories;
using CarRental.PL;
using CarRental.PL.Users;
using Microsoft.EntityFrameworkCore;

namespace CarRental
{
    internal static class Program
    {
        public static AppDbContext DbContext { get; private set; }

        public static PersonsManager PersonsManager;
        public static CategoriesManager CategoriesManager;
        public static CustomersManager CustomersManager;
        public static CarsManager CarsManager;
        public static RentalsManager RentalsManager;
        public static Person AuthorizedUser = null;

        public static bool IsAuthorized
        {
            get
            {
                return AuthorizedUser != null;
            }
        }


        [STAThread]
        static void Main()
        {
            LoadApp();

            ApplicationConfiguration.Initialize();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.Run(new FrmLogin());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = (Exception)e.ExceptionObject;
            if (ex.GetType() == typeof(CarRentalException)) {
                MessageBox.Show(ex.Message);
            }
            else
            {
                LogsManager.LogError(ex);
                MessageBox.Show("Ndodhi nje gabim i paparashikuar");
            }
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            LogsManager.LogError(e.Exception);
            MessageBox.Show(e.Exception.Message);
        }

        static void LoadApp()
        {
            PersonsManager = new PersonsManager();
            CategoriesManager = new CategoriesManager();
            CustomersManager = new CustomersManager();
            CarsManager = new CarsManager();
            RentalsManager = new RentalsManager();
        
            DbContext = new AppDbContext();
            DbContext.Database.EnsureCreated();

            TransactionWrapperService.Init(DbContext);
            PersonsRepository.Init(DbContext);
            
            Console.WriteLine("Database created or already exists");
        }
    }
}