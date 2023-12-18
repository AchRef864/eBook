using System.ComponentModel;
using Xamarin.Forms;
using eBook.ViewModels;

namespace eBook.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}