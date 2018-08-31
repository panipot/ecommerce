using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ecommerce.ViewModels
{
   public  class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        public LoginViewModel NewLogin { get; set; }


        #endregion

        #region Constructors
        public MainViewModel()
        {

            Menu = new ObservableCollection<MenuItemViewModel>();
            NewLogin = new LoginViewModel();
            LoadMenu();

        }

        #endregion


        #region metodos
        private void LoadMenu()
        {
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_product.png",
                PageName = "ProductsPage",
                Title = "Productos"

            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_customer.png",
                PageName = "CustomerPage",
                Title = "Clientes"

            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_entregas.png",
                PageName = "EntregasPage",
                Title = "Entregas"

            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_order.png",
                PageName = "OrderPage",
                Title = "Pedidos"

            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_setup.png",
                PageName = "SetupPage",
                Title = "Config."

            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_sincro.png",
                PageName = "SincroPage",
                Title = "Sincroniza"

            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_exit.png",
                PageName = "LogoutPage",
                Title = "Salida"

            });

        }

        #endregion



    }
}
