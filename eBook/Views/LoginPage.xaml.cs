using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBook.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                Navigation.PushAsync(new HomeAdmin());
            }
            else
            {
                DisplayAlert("Ops..", "Username or password is incorrect!", "ok");
            }
        }
    }
}