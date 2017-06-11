using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.IO;
using System.IO;

namespace Camping.Droid.Services
{
    class ReadDB
    {
        Context context;
        public ReadDB(Context context) {
            this.context = context;
        }



        public void copyDB()
        {

            Stream iStream = context.Assets.Open("database/cache.db");
            //string dbPath = "/data/data/camping.Droid/files/cache.db";

            string packageName = context.ApplicationContext.PackageName;
            string dbPath = "/data/data/" + packageName + "/files/cache.db";

            //path  "/data/data/camping.Droid/files/cache.db"   

            var oStream = new FileOutputStream(dbPath);

            bool exists = System.IO.File.Exists(dbPath);
            long size = 0;
            Android.Net.Uri uri = Android.Net.Uri.FromFile(new Java.IO.File(dbPath));

            using (var fd = context.ContentResolver.OpenFileDescriptor(uri, "r"))
                size = fd.StatSize;
            if (size == 0)
            {
                byte[] buffer = new byte[2048];
                int length = 2048;

                while (iStream.Read(buffer, 0, length) > 0)
                {
                    oStream.Write(buffer, 0, length);
                }
                oStream.Flush();
                oStream.Close();
                iStream.Close();


            }
        }




        public void iniDB()
        {

            /*string packageName = context.ApplicationContext.PackageName;
            string DB_PATH = "/data/data/" + packageName + "/databases/";

            File directory = new File(DB_PATH);
            if (!directory.Exists())
            {
                directory.Mkdirs();
            }

            string DB_NAME = "cache.db"; 

            System.IO.Stream myInput = context.Assets.Open("cache.db");


            string outFileName = DB_PATH + DB_NAME;


            OutputStream myOutput = new FileOutputStream(outFileName);


            byte[] buffer = new byte[1024];
            int length;
            while ((length = myInput.Read(buffer,0,buffer.Length)) > 0)
            {
                myOutput.Write(buffer, 0, length);
            }


            myOutput.Flush();
            myOutput.Close();
            myInput.Close();

       */

        }



    }
}