using System;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Camping
{
	public partial class WalkthroughGradientPage : CarouselPage
	{
		public WalkthroughGradientPage()
		{
			InitializeComponent();

			NavigationPage.SetHasNavigationBar(this, false);

			BindingContext = new WalkthroughViewModel(Close, GoToStep);
		}

		private async Task GoToStep()
		{
			var index = Children.IndexOf(CurrentPage);
			var moveToIndex = 0;
			if (index < Children.Count - 1)
			{
				moveToIndex = index + 1;

				SelectedItem = Children[moveToIndex];
			}
			else
			{
				await Close();
			}
		}

		private async Task Close()
		{
			await Navigation.PopModalAsync();
		}

		protected async override void OnCurrentPageChanged ()
		{
			base.OnCurrentPageChanged ();
			var currentStep = (WalkthroughGradientItemTemplate)CurrentPage;

			await currentStep.AnimateIn ();
		}
	}
}
