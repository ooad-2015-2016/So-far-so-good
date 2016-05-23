using JobRadar.JobRadarBaza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace JobRadar.JobRadarBaza.ViewModels
{
    class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Korisnik Korisnik { get; set; }
        public ICommand LoginKorisnik { get; set; }

        public LoginViewModel()
        {
            //LoginKorisnik = new RelayCommand<object>(loginKorisnik, true);
        }

        private async void loginKorisnik(object obj)
        {
            if (Username == "" || Password == "")
            {
                var message = new MessageDialog("Nisu uneseni svi podaci!", "Neuspješna prijava");
                await message.ShowAsync();
            }

            //provjera postoji li u bazi, ako postoji->otvori Home

        }
    }
}