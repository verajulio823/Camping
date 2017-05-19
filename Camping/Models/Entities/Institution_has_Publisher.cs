using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLearningDB
{
    public class Institution_has_User
    {
        public int id { get; set; }
        public int institution_id { get; set; }

        public int user_id { get; set; }

        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
