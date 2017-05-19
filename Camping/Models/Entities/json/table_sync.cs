using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace MLearning.Core.Entities.json
{
    public class table_sync
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public string table_name { get; set; }

        public DateTime synced_at { get; set; }
    }
}
