using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;
using MLearningDB;
using SQLite;
using System.Diagnostics;

namespace Camping.Models.Services
{
    public class DataAccess: IDisposable
    {
       private SQLiteConnection connection;
       
        

        public DataAccess() {


            try {
                var config = DependencyService.Get<IConfig>();
                connection = new SQLiteConnection(config.Plataforma, Path.Combine(config.DirectorioDB, "cache.db"));
                connection.CreateTable<circle_by_user>();
            }
            catch (Exception e) {
                Debug.WriteLine(e.Data);
            }



        }

        
    

   

        public List<circle_by_user> GetCirclesByUser(int userid) {
            //System.Linq.Expressions.Expression<Func<circle_by_user, bool>> predicate = c => c.User_id == userid ;
            //return connection.Table<circle_by_user>().Where(c => c.User_id == userid).ToList<circle_by_user>();
            return connection.Table<circle_by_user>().Where(c => c.User_id == userid).ToList();
        }

        public List<circle_by_user> GetAllCirclesByUser() {
            return connection.Table<circle_by_user>().ToList<circle_by_user>();
        }



        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
