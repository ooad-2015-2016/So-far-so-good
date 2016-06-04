using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using JobRadar.JobRadarBaza.Models;
using JobRadar.JobRadarBaza.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.UI.Popups;
//using JobRadarWeb;

namespace JobRadar
{
    public partial class LogInForma : Page
    {

        public LoginViewModel parent = new LoginViewModel();
        public ICommand LoginKorisnik { get; set; }

        public LogInForma()
        {
            this.InitializeComponent();
            
            DataContext = new LoginViewModel();


        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

        }

        private void newUserHyperLinkBtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PocetnaRegistracija));
        }
        
       

    }
}
