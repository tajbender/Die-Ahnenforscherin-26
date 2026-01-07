using Die_Ahnenforscherin_26.Pages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Diagnostics;
using Windows.Devices.Enumeration;

namespace Die_Ahnenforscherin_26
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.ExtendsContentIntoTitleBar = true;

//            NavigateTo();  // https://stackoverflow.com/questions/74329160/c-sharp-winui-3-frame-navigation-stack

//            var titleBar = this.ContentFrame.XamlRoot.Content as FrameworkElement;
//            this.SetTitleBar(titleBar);

//            this.ContentFrame.Navigate(typeof(WorkbenchPage), null);


            /*(sender as Frame).Navigate(typeof(MainPage), (sender as Frame).XamlRoot);*/
        }

        private void NavigataionView_SelectionChanged(NavigationView _,
            NavigationViewSelectionChangedEventArgs args)
        {
            Debug.WriteLine("NavigationView_SelectionChanged");

            // Play the default animation ContentFrame
            //ContentFrame.Navigate(typeof(WorkbenchPage), null);
            //bool v = this.ContentFrame.Navigate(WorkbenchPage);
        }
    }
}
