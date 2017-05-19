using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;


namespace Camping.Models.Services
{
    class DataAccess: IDisposable
    {
        private SQLiteConnection connection;

        public DataAccess() {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Plataforma, Path.Combine(config.DirectorioDB, "cache.db"));
        }

        

        

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
