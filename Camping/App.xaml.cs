using Camping.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Camping
{
	//[XamlCompilation (XamlCompilationOptions.Skip)]
	public partial class App : Application
	{
		public static MasterDetailPage MasterDetailPage;
        static DataAccess database;

		public App()
		{
			InitializeComponent();

			MainPage = GetMainPage();

			MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);

		}

        public static DataAccess DataBase {
            get {
                if (database == null) {
                    database = new DataAccess();
                }
                return database;
            }

        }

		public static Page GetMainPage()
		{
			//return new MainPage();
			return new RootPage(true);
		}
	}
}
