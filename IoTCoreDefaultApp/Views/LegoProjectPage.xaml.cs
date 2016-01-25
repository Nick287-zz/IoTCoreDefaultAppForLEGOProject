using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IoTCoreDefaultApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LegoProjectPage : Page
    {
        public LegoProjectPage()
        {
            this.InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                foreach (var item in rootFrame.BackStack)
                {
                    if (item.SourcePageType == typeof(LegoProjectPage))
                    {
                        rootFrame.BackStack.Remove(item);
                    }
                }
                rootFrame.GoBack();
            }
            else
                NavigationUtils.NavigateToScreen(typeof(MainPage));
        }

        private async void PMMMonitor_Click(object sender, RoutedEventArgs e)
        {
            //var options = new LauncherOptions
            //{
            //    TargetApplicationPackageFamilyName = "ba94b267-af8f-4bb8-8ad7-aedf210f566b_4y7h3rbg3dz24"
            //};
            var result = await Launcher.LaunchUriAsync(new Uri("pmhome://"));
        }

        private async void MonitorHome_Click(object sender, RoutedEventArgs e)
        {
            var result = await Launcher.LaunchUriAsync(new Uri("monitorhome://"));
        }

        private async void Voltmeter_Click(object sender, RoutedEventArgs e)
        {
            var result = await Launcher.LaunchUriAsync(new Uri("voltmeter://"));
        }

        private async void Temperature_Click(object sender, RoutedEventArgs e)
        {
            var result = await Launcher.LaunchUriAsync(new Uri("temperature://"));
        }

        private async void Switcher_Click(object sender, RoutedEventArgs e)
        {
            var result = await Launcher.LaunchUriAsync(new Uri("relay://"));
        }

        private async void lightsensation_Click(object sender, RoutedEventArgs e)
        {
            var result = await Launcher.LaunchUriAsync(new Uri("lightsensation://"));
        }
    }
}
