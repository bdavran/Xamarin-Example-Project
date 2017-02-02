using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinApp1.TabbedPages
{
    public partial class MyTab1 : ContentPage
    {
        public MyTab1()
        {
            InitializeComponent();
            BackgroundColor = Color.Red;

            BoxView boxView = new BoxView()
            {
                Color = Color.Blue,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,

            };

            Content = boxView;

        }

    }
}
