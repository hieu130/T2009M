using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2009M
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AppllicationLayout : Page
    {
        public AppllicationLayout()
        {
            this.InitializeComponent();
        }

        private void MyNavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            MyNavView.IsBackEnable = true;
            MyNavView.IsBackButtonVisible = NavigationViewButtonVisible.Visible;
            if (args.IsSettingsInvoked)
            {
                //xử lý khi click vào nút setting
                ContentPage.Navigate(typeof(Page), args.RecommendedNavigationTransitionInfo);
                return;
            }

            var tag = args.InvokedItemContainer.Tag.ToString();
            switch (tag)
            {
                case "home":
                    ContentPage.Navigate(typeof(Page),args.RecommendedNavigationTransitionInfo);
                    break;
                case "createSong":
                    ContentPage.Navigate(typeof(Page), args.RecommendedNavigationTransitionInfo);
                    break;
                case "login":
                    ContentPage.Navigate(typeof(Page), args.RecommendedNavigationTransitionInfo);
                    break;
                case "register":
                    ContentPage.Navigate(typeof(Page), args.RecommendedNavigationTransitionInfo);
                    break;
            }
        }

        private void MyNavView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (ContentPage.CanGoBack)
            {
                ContentPage.GoBack();
            }
        }
    }
}
