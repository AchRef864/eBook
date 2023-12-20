using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eBook.Models;


namespace eBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeAdmin : ContentPage
    {
        public HomeAdmin()
        {
            InitializeComponent();
            
        }
        private ProductInfoViewModel viewModel;
        private void btnAfficher_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var product = menuItem.CommandParameter as ProductInfo;
            DisplayAlert("Details: \n", product.ProductName + product.Description+ "\n "+product.Price+ "dt" , "OK");

        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var product = menuItem.CommandParameter as ProductInfo;

            if (product != null && viewModel != null && viewModel.ItemList.Contains(product))
            {
                viewModel.ItemList.Remove(product);
            }


        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Add());
        }
    }
}