using Camping.Models;
using Camping.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace Camping
{
	public partial class ArticleDetailViewPage : ContentPage
	{
        private ArticleViewModel vm;

		public ArticleDetailViewPage() : this(new ArticleViewModel())
		{

		}

		public ArticleDetailViewPage(ArticleViewModel viewModel)
		{
			InitializeComponent ();
			BindingContext = viewModel;
            vm = viewModel;
            
            Init();
            
		}

        public void Init()
        {

            List<Detail> ld = vm.Details;

            foreach (var item in ld)
            {

                if (item.TypeTemplate == 0)
                {
                    var v = CreateTemplate0(item);
                    contentLayout.Children.Add(v);
                }
                if (item.TypeTemplate == 1)
                {
                    var v = CreateTemplate1(item);
                    contentLayout.Children.Add(v);
                }
                if (item.TypeTemplate == 2)
                {
                    var v = CreateTemplate2(item);
                    contentLayout.Children.Add(v);
                }
                if (item.TypeTemplate == 3)
                {
                    var v = CreateTemplate3();
                    contentLayout.Children.Add(v);
                }

            }

            Debug.WriteLine(ld[0].Content);

        }

        public StackLayout CreateTemplate0(Detail item)
        {
            StackLayout layout = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    new Label{
                        TextColor = Color.Fuchsia, //Color.FromHex(""),
                        Text = item.Title,
                        FontSize = 23

                    },
                    new HtmlFormattedLabel{
                        TextColor = Color.Gray, //FromHex(""),
                        Text = item.Content,
                        Margin = new Thickness (10, 10, 10, 10),
                        FontSize = 20

                    },
                    new Image{
                        Aspect = Aspect.AspectFit,
                        Source = ImageSource.FromUri(new Uri(item.Image))
                    }
                }
            };
            return layout;
        }

        public StackLayout CreateTemplate1(Detail item)
        {
            StackLayout layout = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    new Label{
                        TextColor = InitColor(item.Color_Title),
                        Text = item.Title,
                        FontSize = 23

                    },
                    new Image{
                        Aspect = Aspect.AspectFit,
                        Source = ImageSource.FromUri(new Uri(item.Image))
                    },

                    new HtmlFormattedLabel{
                        TextColor = Color.Gray, //FromHex(""),
                        Text = item.Content,
                        Margin = new Thickness (10, 10, 10, 10),
                        FontSize = 20

                    },

                }
            };
            return layout;
        }

        public StackLayout CreateTemplate2(Detail item)
        {
            StackLayout layout = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = InitColorBackground(item.ColorBackground),
                Children = {
                    new Label{
                        TextColor = InitColor(item.Color_Title),
                        Text = item.Title,
                        FontSize = 23

                    },
                    new HtmlFormattedLabel{
                        TextColor = InitColorContent(item.Color_Content),
                        Text = item.Content,
                        Margin = new Thickness (10, 10, 10, 10),
                        FontSize = 20

                    },

                }
            };
            return layout;


        }

        public View CreateTemplate3()
        {

            return null;
        }

        public Color InitColor(string c)
        {
            if (c.Equals(""))
            {
                return Color.Gray;
            }
            else
            {
                return Color.FromHex(c.Substring(1));
            }
        }

        public Color InitColorBackground(string c)
        {
            if (c.Equals(""))
            {
                return Color.FromHex("ffffff");
            }
            else
            {
                return Color.FromHex(c.Substring(1));
            }

        }

        public Color InitColorContent(string c)
        {
            if (c == null)
            {
                return Color.Gray;
            }
            if (c.Equals(""))
            {
                return Color.Gray;
            }
            else
            {
                return Color.FromHex(c.Substring(1));
            }

        }


        protected override void OnAppearing (){
			base.OnAppearing ();

			outerScrollView.Scrolled += OnScroll;
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
			outerScrollView.Scrolled -= OnScroll;
		}

		public void OnScroll (object sender, ScrolledEventArgs e) {
			var imageHeight = img.Height * 2;
			var scrollRegion = layeringGrid.Height - outerScrollView.Height;
			var parallexRegion = imageHeight - outerScrollView.Height;
			var factor = outerScrollView.ScrollY - parallexRegion * (outerScrollView.ScrollY / scrollRegion);
			if (factor < 0)
			{
				factor = 0;
			}
			else 
			{
				if (img.TranslationY > img.Height)
				{
					factor = img.Height;
				}
				else if( img.TranslationY > outerScrollView.ScrollY ){ 
					img.TranslationY = outerScrollView.ScrollY;
				}
			}
			img.TranslationY = factor;
			img.Opacity = 1 - ( factor / imageHeight ) ;
			headers.Scale = 1 - ( (factor ) / (imageHeight * 2) ) ;
		}

		public void OnMore (object sender, EventArgs e) {
			var mi = ((MenuItem)sender);
			DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
		}

		public void OnDelete (object sender, EventArgs e) {
			var mi = ((MenuItem)sender);
			DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
		}

		public void OnItemTapped (object sender, EventArgs e) {
			var message = (Message)((ListView)sender).SelectedItem;
			DisplayAlert("Message Tapped", "You tapped on " + message.From.Name + "'s message.", "OK");
		}

		public void OnPrimaryActionButtonClicked (object sender, EventArgs e){

		}
	}
}

