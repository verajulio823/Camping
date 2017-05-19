using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Camping
{
	public partial class ArticlesFeedPage : ContentPage
	{
		public ArticlesFeedPage()
		{
			InitializeComponent ();

			BindingContext = new PostsViewModel ();
		}

		private async void OnItemTapped(Object sender, EventArgs e){
			var selectedItem = ((ListView)sender).SelectedItem;
			var post = (Post) selectedItem;
			var articleView = new ArticleViewPage(new ArticleViewModel(post));

			await Navigation.PushAsync( articleView );
		}
	}
}