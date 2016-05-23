using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace JobRadar
{
    public partial class RegistracijaPoslodavca:Page
    {

        public RegistracijaPoslodavca()
        {
            this.InitializeComponent();
            //DataContext
            NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        private void btnRegisterPoslodavac_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
           
        }



    }
}
