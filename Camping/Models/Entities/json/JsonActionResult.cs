using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLearning.Core.Entities.json
{
    public class JsonActionResult
    {
        public String[] errors {get; set;}
        public String url { get; set;}

        public int resultId { get; set; }
        public Object resultData { get; set; }
    }
}
