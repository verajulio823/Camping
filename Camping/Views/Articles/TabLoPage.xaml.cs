using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using System.Diagnostics;

namespace Camping.Views.Articles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabLoPage : ContentPage
    {
        public TabLoPage() : this(new TabLoViewModel())
		{

        }

        
        public TabLoPage(TabLoViewModel viewModel)
        {
           
            InitializeComponent();
            BindingContext = viewModel;
            
            
            
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {

            //var imageSender = (Image)sender;
            Debug.WriteLine("ELEGIII OPCION 1");


        }

        private void Click_Item_Like(object sender, EventArgs e)
        {
            Debug.WriteLine("ELEGIII OPCION LIKE");

            layout_costa.BackgroundColor = Color.FromHex("#00ffffff");
            layout_sierra.BackgroundColor = Color.FromHex("#00ffffff");
            layout_selva.BackgroundColor = Color.FromHex("#00ffffff");
            layout_like.BackgroundColor = Color.FromHex("#50000000");
            img.Source = ImageSource.FromFile("mismejcamp.jpg");
          /*  var sss = App.DataBase.GetAllCirclesByUser();
            for (int i = 0; i <sss.Count; i++)
            {
                Debug.WriteLine(sss[i].name);
            }
            */

        }

        private void Click_Item_Costa(object sender, EventArgs e)
        {
            Debug.WriteLine("ELEGIII OPCION COSTA");
            layout_like.BackgroundColor = Color.FromHex("#00ffffff");
            layout_sierra.BackgroundColor = Color.FromHex("#00ffffff");
            layout_selva.BackgroundColor = Color.FromHex("#00ffffff");
            layout_costa.BackgroundColor = Color.FromHex("#50000000");
            img.Source = ImageSource.FromFile("costa.jpg");
        }

        private void Click_Item_Sierra(object sender, EventArgs e)
        {
            Debug.WriteLine("ELEGIII OPCION SIERRA");
            layout_costa.BackgroundColor = Color.FromHex("#00ffffff");
            layout_like.BackgroundColor = Color.FromHex("#00ffffff");
            layout_selva.BackgroundColor = Color.FromHex("#00ffffff");
            layout_sierra.BackgroundColor = Color.FromHex("#50000000");
            img.Source = ImageSource.FromFile("sierra.jpg");
        }

        private void Click_Item_Selva(object sender, EventArgs e)
        {
            Debug.WriteLine("ELEGIII OPCION SELVA");
            layout_costa.BackgroundColor = Color.FromHex("#00ffffff");
            layout_sierra.BackgroundColor = Color.FromHex("#00ffffff");
            layout_like.BackgroundColor = Color.FromHex("#00ffffff");
            layout_selva.BackgroundColor = Color.FromHex("#50000000");
            img.Source = ImageSource.FromFile("selva.jpg");
        }

        private async void OnItemTapped(Object sender, EventArgs e)
        {
            Debug.WriteLine("LLegue y elegiiii este......");
            /*
            var selectedItem = ((ListView)sender).SelectedItem;
            var message = (Message)selectedItem;

            
            
            var articleDetail = new ArticleDetailViewPage(new ArticleViewModel(message.Id));

            
            await Navigation.PushAsync(articleDetail);*/
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

        /*private async void OnItemTapped(Object sender, EventArgs e)
        {
            Debug.WriteLine("LLegue y elegiiii este......");
            var selectedItem = ((ListView)sender).SelectedItem;
            var message = (Message)selectedItem;


            //var articleDetail = new ArticleDetailViewPage(new ArticleViewModel());

            var articleDetail = new ArticleDetailViewPage(new ArticleViewModel(message.Id));


            //var articleView = new ArticleViewPage(new ArticleViewModel(post));

            await Navigation.PushAsync(articleDetail);
        }
        */



        /*
        public void OnPrimaryActionButtonClicked(object sender, EventArgs e)
        {

        }
        */
    }
}
