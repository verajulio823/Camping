using System.Collections.Generic;

namespace Camping
{
	public class PostsViewModel
	{
		public List<Post> PostsList 
		{ 
			get 
			{
				return SampleData.Posts;
			}
		}
	}
}

