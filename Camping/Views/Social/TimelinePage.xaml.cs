using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Camping
{
	public partial class TimelinePage : ContentPage
	{
		public TimelinePage()
		{
			InitializeComponent();

			this.BindingContext = new TimelineViewModel();
		}
	}
}

