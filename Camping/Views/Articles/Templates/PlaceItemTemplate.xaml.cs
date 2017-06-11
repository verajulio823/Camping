using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace Camping
{
	public partial class PlaceItemTemplate : ContentView
	{
		public PlaceItemTemplate ()
		{
			InitializeComponent ();
		}

        private void click_Like(object sender, EventArgs e)
        {
            var img_like = ((Image)sender);

            Debug.WriteLine(img_like.Source.ToString());
            
            /*if (img_like.Source)
            {
                img_like.Source = ImageSource.FromFile("favoritos.png");
            }
            else {
                img_like.Source = ImageSource.FromFile("favoritos_BN.png");
            }*/

        }

    }
}

