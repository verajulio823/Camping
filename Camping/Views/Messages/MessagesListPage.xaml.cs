using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;

namespace Camping
{
	public partial class MessagesListPage : ContentPage
	{
		public MessagesListPage ()
		{
			InitializeComponent ();
			listViewMessages.ItemsSource = SampleData.Messages;
		}

		public async void OnMore (object sender, EventArgs e) {
			var mi = ((MenuItem)sender);
			await DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
		}

		public async void OnDelete (object sender, EventArgs e) {
			var mi = ((MenuItem)sender);
			await DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
		}

		public async void OnItemTapped (object sender, EventArgs e) {
			var selectedItem = ((ListView)sender).SelectedItem;
			var userName = ((Message)selectedItem).From.Name;

			await DisplayAlert("Message Tapped", "You tapped on " + userName + "'s message.", "OK");
		}

		public void OnRefreshing (object sender, EventArgs e) {
			var listView = (sender as ListView);
			listView.EndRefresh();
		}

		public void animateIn( View uiElement ){
			animateItem (uiElement, 10500);
		}

		private void animateItem( View uiElement, uint duration ){
			uiElement.RotateYTo(99, duration, Easing.SinInOut);
		}
	}
}

