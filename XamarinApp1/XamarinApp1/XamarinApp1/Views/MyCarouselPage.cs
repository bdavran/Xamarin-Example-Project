using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp1.TabbedPages;

namespace XamarinApp1.Views
{
    public class MyCarouselPage : CarouselPage
    {

        public MyCarouselPage()
        {
            Children.Add(new MyTab1());
            Children.Add(new MyTab2());
        }
    }
}
