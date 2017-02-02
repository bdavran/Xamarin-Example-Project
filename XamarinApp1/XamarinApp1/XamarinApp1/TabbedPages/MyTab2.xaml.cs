using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinApp1.TabbedPages
{
    public partial class MyTab2 : ContentPage
    {
        public MyTab2()
        {
            InitializeComponent();
            Title = "My Page 2";
            BackgroundColor = Color.Blue;


            BoxView boxView = new BoxView()
            {
                Color = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,

            };

            Content = boxView;
        }


    }
}
