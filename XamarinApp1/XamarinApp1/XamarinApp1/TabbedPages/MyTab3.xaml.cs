using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Java.Util;
using Xamarin.Forms;

namespace XamarinApp1.TabbedPages
{
    public partial class MyTab3 : ContentPage
    {
        public MyTab3()
        {
            InitializeComponent();
            Title = "My Tab 3 ";
            StackLayout stackLayout = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
               Children =
               {
                    new Label
                    {
                    Text = "StackLayout",
                    HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                      Text  = "Children stacking center",
                      HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                        Text = "End of the line",
                        HorizontalOptions = LayoutOptions.End
                    },
                    new Label
                    {
                        Text = "by default",
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                        Text = "but horizontal placement",
                        HorizontalOptions = LayoutOptions.Start
                    },
                    new Label
                    {
                        Text = "but horizontal placement",
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                        Text = "the horizontaloption property",
                        HorizontalOptions = LayoutOptions.End
                    },
                    new Label
                    {
                        Text = "An Expand option allows one or more children " +
                   "to occupy the an area within the remaining " +
                   "space of the StackLayout after it's been sized " +
                   "to the height of its parent.",
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.End
                    },

                    new StackLayout
                    {
                        Spacing = 10,
                        Orientation = StackOrientation.Horizontal,

                        Children =
                        {
                            new Label
                            {
                                Text = "Stacking"
                            },
                            new Label
                            {
                                Text = "can also be",
                                HorizontalOptions = LayoutOptions.CenterAndExpand
                            },

                            new Label
                            {
                                Text = "horizontal",
                            },

                        }

                    }

                
               }


            };
            Content = stackLayout;
        }
    }
}
