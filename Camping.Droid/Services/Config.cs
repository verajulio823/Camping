using System;
using System.IO;
using SQLite.Net.Interop;
using Xamarin.Forms;
using Camping.Models.Services;
using Android.App;


[assembly: Dependency(typeof(Camping.Droid.Services.Config))]
namespace Camping.Droid.Services
{

    class Config: IConfig
    {
        private string directorioDB;
        private ISQLitePlatform plataforma;

        public string DirectorioDB
        {
            get
            {
                if (string.IsNullOrEmpty(directorioDB))
                {
                    directorioDB = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    string dbpath = Path.Combine(directorioDB, "cache.db");
                 
                    Copydb(dbpath);
                    
                }
                return directorioDB;
            }
        }

        private static void Copydb(string dbPath) {
            if (!File.Exists(dbPath)) {
                using (var br = new BinaryReader(Android.App.Application.Context.Assets.Open("database/cache.db"))) {
                    using (var bw = new BinaryWriter(new FileStream(dbPath, FileMode.Create))) {
                        byte[] buffer = new byte[2048];
                        int length = 0;
                        while ((length = br.Read(buffer, 0, buffer.Length)) > 0) {
                            bw.Write(buffer, 0, length);
                        }
                    }
                }

            }
        }

        public ISQLitePlatform Plataforma
        {

            get
            {
                if (plataforma == null)
                {
                    plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();

                }
                return plataforma;
            }
        }
    }
}