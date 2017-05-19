using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Camping
{
	public partial class SocialVariantPage : ContentPage
	{
		public SocialVariantPage ()
		{
			InitializeComponent ();

			BindingContext = new SocialViewModel ();
		}
	}
}