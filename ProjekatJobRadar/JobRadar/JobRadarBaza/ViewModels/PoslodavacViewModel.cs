using JobRadar.Helper;
using JobRadar.JobRadarBaza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace JobRadar.JobRadarBaza.ViewModels
{
    public class PoslodavacViewModel : INotifyPropertyChanged
    {
        private string ime;

        private string username;
        private string password;
        private string passwordConfirm;

        public ICommand Dodaj { get; set; }
        public Poslodavac osoba { get; set; }


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
        public string PasswordConfirm
        {
            get { return passwordConfirm; }
            set
            {
                passwordConfirm = value;
                NotifyPropertyChanged("PasswordConfirm");
            }
        }

        public PoslodavacViewModel()
        {

            Dodaj = new RelayCommand<object>(unosKorisnika);

        }

        private async void unosKorisnika(object obj)
        {
            if (Ime == null || Password == null || PasswordConfirm == null)
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

                osoba = new Poslodavac(username, null, password, ime, null, null, new List<Konkurs>(), true);
                using (var db = new JobRadarDBContext())
                {
                    db.Poslodavac.Add(osoba);
                }



                Ime = string.Empty;
                Username = string.Empty;
                Password = string.Empty;
                PasswordConfirm = string.Empty;

                NavigationServis = new NavigationService();
                NavigationServis.Navigate(typeof(HomePage));

            }
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
