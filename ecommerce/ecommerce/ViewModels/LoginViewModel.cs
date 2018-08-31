using ecommerce.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ecommerce.ViewModels
{
   public  class LoginViewModel
    {
        private NavigationService navigationService;
        private DialogService dialogservice;

        public LoginViewModel()
        {
            navigationService = new NavigationService();
            dialogservice = new DialogService();
            IsRemembered = true;
        }
        #region Properties

        public string User { get; set; }

        public string Password { get; set; }

        public bool IsRemembered { get; set; }


        #endregion

        #region comandos
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(User))
            {
                await dialogservice.ShowMessage("Error", "Debes ingresar usuario");
                return;
            }
            if (string.IsNullOrEmpty(Password))
            {
                await dialogservice.ShowMessage("Error", "Debes ingresar contraseña");
                return;
            }
            navigationService.SetMainPage() ;
        } 
        #endregion
    }
}
