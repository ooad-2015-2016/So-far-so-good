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
using Windows.UI.Popups;
using JobRadar.Helper;

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


    public class KorisnikViewModel:INotifyPropertyChanged
    {
        private string ime;
        private string prezime;
        private string username;
        private string password;
        private string passwordConfirm;
        private DateTime datumRodjenja;
        private string email;
        //  public Korisnik CreateUposlenik { get; set; }
        //  ExterniServis eksterniServis;
        public CameraHelper Camera { get; set; }

        //    public ICommand DodajUposlenika { get; set; }
        public ICommand Uslikaj { get; set; }
        public ICommand Dodaj { get; set; }
        public OsobaKojaTraziPosao osoba { get; set; }

        private SoftwareBitmapSource slika;
        public INavigacija NavigationServis { get; set; }

        public string Ime
        {
            get { return ime; }
            set
            {
                ime = value;
                NotifyPropertyChanged("Ime");
            }
        }
        public string Prezime
        {
            get { return prezime; }
            set
            {
                prezime = value;
                NotifyPropertyChanged("Prezime");
            }
        }
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                NotifyPropertyChanged("Username");
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                NotifyPropertyChanged("Password");
            }
        }
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set
            {
                datumRodjenja = value;
                NotifyPropertyChanged("DatumRodjenja");
            }
        }
        public string EMail
        {
            get { return email; }
            set
            {
                email = value;
                NotifyPropertyChanged("EMail");
            }
        }
        public string PasswordConfirm
        {
            get { return passwordConfirm; }
            set
            {
                passwordConfirm = value;
                NotifyPropertyChanged("PasswordConfirm");
            }
        }
        
       

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
        public KorisnikViewModel()
        {

            //     eksterniServis = new ExterniServis();
          
            Dodaj = new RelayCommand<object>(unosKorisnika);
            DatumRodjenja = DateTime.Now;
            Camera = new CameraHelper(Registracija3Forma.Control);
            Camera.InitializeCameraAsync();
            
            Uslikaj = new RelayCommand<object>(uslikaj, (object parametar) => true);

        }

        private async void unosKorisnika(object obj)
        {
            if (Ime == null || Prezime == null || EMail == null || Password == null || PasswordConfirm == null)
            {
                var poruka = new MessageDialog("Input data is not complete", "Error!");
                await poruka.ShowAsync();
            }

            else if (Password != PasswordConfirm)
            {
                var poruka = new MessageDialog("Entered password don't match", "Error!");
                await poruka.ShowAsync();
            }
           
            else
            {

                osoba = new OsobaKojaTraziPosao(Username, EMail, Password, Ime, Prezime, DatumRodjenja, DateTime.Now, false, new List<Konkurs>(), true);

                using (var db = new JobRadarDBContext())
                {
                    db.OsobaKojaTraziPosao.Add(osoba);
                }


               
                Ime = string.Empty;
                Prezime = string.Empty;
                Username = string.Empty;
                Password = string.Empty;
                PasswordConfirm = string.Empty;
                DatumRodjenja = DateTime.Today;
                EMail = string.Empty;
                NavigationServis = new NavigationService();
                NavigationServis.Navigate(typeof(Registracija2Forma));
            }
        }

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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }


}

