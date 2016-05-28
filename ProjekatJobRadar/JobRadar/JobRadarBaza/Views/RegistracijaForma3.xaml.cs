using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace JobRadar
{
    public partial class Registracija3Forma:Page
    {
        public JobRadarBaza.ViewModels.KorisnikViewModel kwm;
        public Registracija3Forma()
        {
            
            this.InitializeComponent();

            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += ThisPage_BackRequested;
            kwm = new JobRadarBaza.ViewModels.KorisnikViewModel(PreviewControl);
            
        }

        private void ThisPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
                e.Handled = true;
            }
        }

        private void btnFinish_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
          //  this.Frame.Navigate(typeof(Registracija3Forma));
        }

        
        private void btnUslikaj_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            kwm.uslikaj(sender);
            SlikaControl.Source = kwm.Slika;
        }
    }
}
