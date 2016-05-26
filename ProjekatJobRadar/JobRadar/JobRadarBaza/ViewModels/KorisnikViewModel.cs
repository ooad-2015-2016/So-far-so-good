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
using JobRadar.JobRadarBaza.Models;

namespace JobRadar.JobRadarBaza.ViewModels
{
    public class RelayCommand : ICommand
    {
        readonly Action<object> execute;
        readonly Predicate<object> canExecute;

        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }

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
            Uslikaj = new RelayCommand(uslikaj, (object parametar) => true);

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

