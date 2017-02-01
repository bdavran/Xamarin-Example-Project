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

            BoxView boxView = new BoxView();
            boxView.BackgroundColor = Color.White;
            boxView.VerticalOptions = LayoutOptions.Center;
            boxView.HorizontalOptions = LayoutOptions.Center;
            Content = boxView;
            
        }
    }
}
