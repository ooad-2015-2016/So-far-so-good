using JobRadar.JobRadarBaza.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace JobRadar.JobRadarBaza.ViewModels
{
    public class LoginViewModel:INotifyPropertyChanged
    {
        private string username { get; set; }
        private string password { get; set; }
        public Korisnik Korisnik { get; set; }
        public ICommand LoginKorisnik { get; set; }
        

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

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        ObservableCollection<Korisnik> Korisnici { get; set; }

        public LoginViewModel()
        {
            LoginKorisnik = new RelayCommand<object>(loginKorisnik, mozeLi);
            using (var db = new JobRadarDBContext())
            {
                Korisnici = new ObservableCollection<Korisnik>();

                foreach (Poslodavac p in db.Poslodavac)
                    Korisnici.Add(p);
                foreach (OsobaKojaTraziPosao o in db.OsobaKojaTraziPosao)
                    Korisnici.Add(o);
            }
        }

        private bool mozeLi(object arg)
        {
            return true;
        }

        public async void loginKorisnik(object obj)
        {
            Korisnik = Korisnici.FirstOrDefault(k => k.userName == Username && k.passwordHash == Password);

            if (Username == null || Password == null)
            {
                var message = new MessageDialog("Nisu uneseni svi podaci!", "Neuspješna prijava");
                await message.ShowAsync();
            }

           
            else if (Korisnik == null)
            {
                var message = new MessageDialog("Podaci nisu tačni!", "Neuspješna prijava");
                await message.ShowAsync();
            }
            

        }
    }
}