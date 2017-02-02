using Xamarin.Forms;
using XamarinApp1.MasterSayfalar;

namespace XamarinApp1.Views
{
    public class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {
            Padding = new Thickness(0,Device.OS == TargetPlatform.Android ?  10 : 0,0,0);
            Master = new MyMenu();
            Detail = new MyTabbedPage();  
        }
    }
}
