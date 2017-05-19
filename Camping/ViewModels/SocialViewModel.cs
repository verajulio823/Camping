using System;
using System.Collections.Generic;
using System.Linq;

namespace Camping
{
	public class SocialViewModel
	{
		public SocialViewModel() {
		}
			
		public List<string> Images {
			get{ 
				return SampleData.SocialImageGalleryItems;
			}
		}

		public List<User> Friends 
		{ 
			get
			{
				return SampleData.Friends;
			}
		}
	}
}