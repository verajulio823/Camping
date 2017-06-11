using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using System.Diagnostics;

namespace Camping.Views.Articles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticleLoViewPage : ContentPage
    {
        public ArticleLoViewPage() : this(new ArticleViewModel())
		{
            
        }

        public ArticleLoViewPage(ArticleViewModel viewModel)
        {
           
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            viewModel.Id_Lo_description = 0;
            BindingContext = viewModel;
            
        }
        

        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
        }

        private async void OnItemTapped(Object sender, EventArgs e)
        {
            Debug.WriteLine("LLegue y elegiiii este......");
            var selectedItem = ((ListView)sender).SelectedItem;
            var message = (Message)selectedItem;


            //var articleDetail = new ArticleDetailViewPage(new ArticleViewModel());

            var articleDetail = new ArticleDetailViewPage(new ArticleViewModel(message.Id));


            //var articleView = new ArticleViewPage(new ArticleViewModel(post));

            await Navigation.PushAsync(articleDetail);
        }



        public void OnPrimaryActionButtonClicked(object sender, EventArgs e)
        {

        }

    }
}
