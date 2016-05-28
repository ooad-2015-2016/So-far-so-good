using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Windows.Media;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using JobRadar.JobRadarBaza.Models;

namespace JobRadar.JobRadarBaza.ViewModels
{
    public class RelayCommand<T> : ICommand
    {
        private readonly Func<T, bool> _canExecuteMethod;
        private readonly Action<T> _executeMethod;

        #region Constructors

        public RelayCommand(Action<T> executeMethod):this(executeMethod, null)
            { }

        public RelayCommand(Action<T> executeMethod, Func<T,bool> canExecuteMethod)
        {
            _executeMethod = executeMethod;
            _canExecuteMethod = canExecuteMethod;
        }

        #endregion

        #region ICommand Members

        public event EventHandler CanExecuteChanged;

        bool ICommand.CanExecute(object parameter)
        {
            try
            {
                return CanExecute((T)parameter);
            } catch { return false; }
        }

        void ICommand.Execute(object parameter)
        {
            Execute((T)parameter);
        }

        #endregion ICommand Members

        #region Public Methods
        public bool CanExecute(T parameter)
        {
            return ((_canExecuteMethod == null) || _canExecuteMethod(parameter));
        }

        public void Execute(T parameter)
        {
            if (_executeMethod != null)
                _executeMethod(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            OnCanExecuteChanged(EventArgs.Empty);
        }
        #endregion Public Methods

        #region Protected Methods

        protected virtual void OnCanExecuteChanged(EventArgs e)
        {
            var handler = CanExecuteChanged;
            if(handler != null)
            {
                handler(this, e);
            }
        }

        #endregion

    }


    class KorisnikViewModel:INotifyPropertyChanged
    {
        
      //  public Korisnik CreateUposlenik { get; set; }
      //  ExterniServis eksterniServis;
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

       //     eksterniServis = new ExterniServis();
            // CreateUposlenik = new Uposlenik();

            Camera = new CameraHelper(previewControl);
            Camera.InitializeCameraAsync();
            // DodajUposlenika = new RelayCommand<object>(dodajUposlenika, (object parametar) => true);
            Uslikaj = new RelayCommand<object>(uslikaj, (object parametar) => true);

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

