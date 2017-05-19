using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Camping
{
	public partial class DocumentTimelinePage : ContentPage
	{
		public DocumentTimelinePage()
		{
			InitializeComponent ();
			BindingContext = new DocumentTimelineViewModel();
		}
	}
}

