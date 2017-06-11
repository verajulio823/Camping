using Camping.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Camping
{
    public class ArticleViewModel
    {
        public ArticleViewModel() : this(SampleData.Posts[0]) {

        }

        public ArticleViewModel(Post post) {
            this.Post = post;
        }

        public ArticleViewModel(int id_detail)
        {
            this.Id_detail = id_detail;
        }

        
        public LoPage LoPage { get {
                return SampleData.LoPageFront(Id_Lo_description);
            }
        }

        
        
        public int Id_Lo_description { get; set; }

        public Post Post { get; private set;}
        public int Id_detail { get; private set; }
        public PageSource PageSource
        {
            get
            {
                return SampleData.PageSourceFront(Id_detail);
            }

        }

        public List<Message> Comments {
			get{
                return getComments();
				//return SampleData.Comments;
			}
		}

        public List<Message> getComments() {
            List<Message> lm =SampleData.Comments;
            List<Message> lnm = new List<Message>();
            for (int i = 0; i < lm.Count; i++)
            {
                if (lm[i].Id_description == Id_Lo_description)
                {

                    lnm.Add(lm[i]);
                }
            }
            return lnm;

        }

        public List<Detail> Details
        {
            get
            {
                return getDetailforId();
            }
        }

        public List<Detail> getDetailforId()
        {
            List<Detail> ld = SampleData.Details;
            List<Detail> nld = new List<Detail>();

            for (int i = 0; i < ld.Count; i++)
            {
                if (ld[i].Id_Lo == Id_detail)
                {

                    nld.Add(ld[i]);
                }
            }

            return nld;
        }

    }
}