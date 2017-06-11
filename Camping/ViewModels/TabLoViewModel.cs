using Camping.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Camping
{
    public class TabLoViewModel
    {
        public TabLoViewModel() : this(SampleData.Posts[0]) {
        }

        public TabLoViewModel(Post post) {
            this.Post = post;
        }

        public TabLoViewModel(int id_detail)
        {
            this.Id_detail = id_detail;
        }

        public LoPage LoPage {
            get {
                return SampleData.LoPageFront(0);
            }
        }


        public Post Post { get; private set;}
        public int Id_detail { get; private set; }

        public int Id_ItemSelected { get; set; }

        public PageSource PageSource
        {
            get
            {
                return SampleData.PageSourceFront(Id_detail);
            }

        }

        public List<Message> Comments {
			get{ 
				return SampleData.Comments;
			}
		}


        public List<LoCircle> Circles
        {
            get
            {
                return getCirclesById();
            }
        }
        public List<LoCircle> getCirclesById() {
            Id_ItemSelected = 0;
            List<LoCircle> ld = SampleData.Circles;
            List<LoCircle> nld = new List<LoCircle>();

            

            for (int i = 0; i < ld.Count; i++)
            {
                if (ld[i].Id == Id_ItemSelected)
                {
                    if (ld[i].ImageFavorite == 0)
                    {
                        ld[i].ImageFavoriteSelect = "favoritos_BN.png";
                    }
                    else {
                        ld[i].ImageFavoriteSelect = "favoritos.png";
                    }

                    nld.Add(ld[i]);
                }
            }

            return nld;
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