using ecommerce.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ecommerce.ViewModels
{
    public class MenuItemViewModel
    {
        #region properties
        public string Icon { get; set; }

        public string Title { get; set; }

        public string PageName { get; set; }

        private NavigationService navigationservice;
        #endregion

        public MenuItemViewModel()
        {
            navigationservice = new NavigationService();
        }



        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); } }

        private async void Navigate()
        {
            await navigationservice.Navigate(PageName);
        }



    }
}
