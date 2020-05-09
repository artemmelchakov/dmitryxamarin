using App3.DAL;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "app3.db";
        public static ContactRepository database;
        public static ContactRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new ContactRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage() );
        }

        protected override void OnStart()
        {
            //Приложение запустилось впервые
        }

        protected override void OnSleep()
        {
            //Приложение работает в фоне
        }

        protected override void OnResume()
        {
            //Приложение работает из фона
        }
    }
}
