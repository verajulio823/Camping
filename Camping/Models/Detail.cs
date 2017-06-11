using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camping.Models
{
    public class Detail
    {
        public int Id_Lo { get; set; }
        public string Title { get; set; }
        public string Color_Title { get; set; }
        public string Content { get; set; }
        public string Color_Content { get; set; }
        public string Image { get; set; }
        public List<string> ListImages { get; set; }
        public string ColorBackground { get; set; }
        public int TypeTemplate { get; set; }
        public Detail()
        {
        }
    }
}
