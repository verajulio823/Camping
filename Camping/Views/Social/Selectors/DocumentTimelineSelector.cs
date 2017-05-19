using System;
using Xamarin.Forms;
namespace Camping

{
	public class DocumentTimelineSelector : DataTemplateSelector 
	{
		public DataTemplate DocumentTimelineLeftItemTemplate { get; set; }
		public DataTemplate DocumentTimelineRightItemTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var documentItem = item as DocumentTimelineEvent;

			if (documentItem != null && documentItem.IsInbound)
			{
				return DocumentTimelineRightItemTemplate;
			}

			return DocumentTimelineLeftItemTemplate;
		}
	}
}
