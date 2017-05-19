using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Camping
{
	public partial class PasswordRecoveryPage : ContentPage
	{
		public PasswordRecoveryPage ()
		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar(this, false);
		}

		private async void OnCloseButtonClicked(object sender, EventArgs args)
		{
			await Navigation.PopModalAsync();
		}
	}
}