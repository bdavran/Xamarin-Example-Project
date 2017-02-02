using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp1.Views
{
    public class MyContentPage4 : ContentPage
    {
        public MyContentPage4()
        {
            var lblPage = new Label();
            lblPage.Text = "Hello World";
            lblPage.FontSize = 30;
            lblPage.HorizontalOptions = LayoutOptions.Center;
            lblPage.VerticalOptions = LayoutOptions.Center;

            Content = lblPage;
        }

       
    }
}
