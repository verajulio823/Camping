using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camping.Models
{
    public class LoCircle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ImageFavorite { get; set; }
        public string ImageFavoriteSelect { get; set; }

        public LoCircle() {
        }
    }
}
