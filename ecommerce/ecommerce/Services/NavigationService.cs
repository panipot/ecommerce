using ecommerce.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Services
{
    public  class NavigationService
    {
        public async Task Navigate(string pageName)
        {
            App.Master.IsPresented = false;
            switch (pageName)
            {
                case "CustomerPage":
                    await App.Navigator.PushAsync(new CustomerPage());
                    break;
                case "EntregasPage":
                    await App.Navigator.PushAsync(new EntregasPage());
                    break;
                case "OrderPage":
                    await App.Navigator.PushAsync(new OrderPage());
                    break;
                case "ProductsPage":
                    await App.Navigator.PushAsync(new ProductsPage());
                    break;
                case "SetupPage":
                    await App.Navigator.PushAsync(new SetupPage());
                    break;
                case "SincroPage":
                    await App.Navigator.PushAsync(new SincroPage());
                    break;
                case "UserPage":
                    await App.Navigator.PushAsync(new UserPage());
                    break;
                default:
                    break;
            }
        }

        internal void SetMainPage()
        {
            App.Current.MainPage = new MasterPage();
        }
    }
}
