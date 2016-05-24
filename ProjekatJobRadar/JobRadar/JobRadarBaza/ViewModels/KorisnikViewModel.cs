using JobRadar.JobRadarBaza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace JobRadar.JobRadarBaza.ViewModels
{
    class KorisnikViewModel:INotifyPropertyChanged
    {
        
      //  public Korisnik CreateUposlenik { get; set; }
        ExterniServis eksterniServis;
        public CameraHelper Camera { get; set; }

    //    public ICommand DodajUposlenika { get; set; }
        public ICommand Uslikaj { get; set; }
     
        private SoftwareBitmapSource slika;
        public SoftwareBitmapSource Slika
        {
            get { return slika; }
            set
            {
                slika = value;
                OnNotifyPropertyChanged("Slika");
            }
        }
     
        CaptureElement previewControl;
        public KorisnikViewModel(CaptureElement previewControl)
        {
            
            eksterniServis = new ExterniServis();
           // CreateUposlenik = new Uposlenik();
           
            Camera = new CameraHelper(previewControl);
            Camera.InitializeCameraAsync();
           // DodajUposlenika = new RelayCommand<object>(dodajUposlenika, (object parametar) => true);
           // Uslikaj = new RellayCommand<object>(uslikaj, (object parametar) => true);
        }
        //komanda koja inicira slikanje
        public async void uslikaj(object parametar)
        {
            await Camera.TakePhotoAsync(SlikanjeGotovo);
        }
       /*
        public void dodajUposlenika(object parametar)
        {
            eksterniServis.dodajKorisnika(CreateUposlenik);
            CreateUposlenik = new Uposlenik();
        }*/
      
        public void SlikanjeGotovo(SoftwareBitmapSource slikica)
        {
            Slika = slikica;
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")
        {
            //? je skracena verzija ako nije null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}

