using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Camping
{
	public partial class SamplesListFromCategoryPage : ContentPage
	{
		private bool _processingSelection = false;

		public SamplesListFromCategoryPage ( SampleCategory sampleCategory )
		{
			InitializeComponent ();

			BindingContext = sampleCategory;
			Title = sampleCategory.Name;
		}

		private async void OnItemTapped(Object sender, ItemTappedEventArgs e)
		{
			if (_processingSelection) 
			{
				return;
			}

			_processingSelection = true;

			try{
				var listView = (ListView)sender;
				var selectedItem = listView.SelectedItem;
				var sample = (Sample) selectedItem;

				if (selectedItem != null) {
					SampleCoordinator.SelectedSample = sample;

					await sample.NavigateToSample (Navigation);
					listView.SelectedItem = null;
				}
			}finally{
				_processingSelection = false;
			}
		}

		public static async Task NavigateToCategory(SampleCategory sampleCategory, INavigation navigation){
			await navigation.PushAsync( new SamplesListFromCategoryPage( sampleCategory ) );
		}

		public async void NavigateToGrialSettingsPage(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new GrialDemoSettings());
		}
	}
}