using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using JobRadar.JobRadarBaza.ViewModels;
using JobRadar.JobRadarBaza.Models;
using System.Collections.ObjectModel;
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
namespace JobRadar
{
    public partial class HomePage : Page
    {
        public ObservableCollection<Konkurs> Konkursi { get; set; }

        public HomePage()
        {
            this.InitializeComponent();

        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            using (var db = new JobRadarDBContext())
            {
                listBoxKonkurs.ItemsSource = db.Konkursi.ToList();
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            HomePageViewModel kupovinaViewModel = e.Parameter as HomePageViewModel;
            DataContext = kupovinaViewModel;
        }
    }



}
