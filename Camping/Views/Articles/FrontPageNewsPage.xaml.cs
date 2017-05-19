using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Camping
{
	public partial class FrontPageNewsPage : ContentPage
	{
		public FrontPageNewsPage()
		{
			InitializeComponent();

			BindingContext = new FrontPageNewsViewModel();

		}
	}
}

