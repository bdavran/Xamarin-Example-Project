using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp1.MasterSayfalar;

namespace XamarinApp1.Views
{
    public class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {
            Master = new MyMenu();
            Detail = new MyContent();
            
        }
    }
}
