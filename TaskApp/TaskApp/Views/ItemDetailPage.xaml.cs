using System.ComponentModel;
using TaskApp.ViewModels;
using Xamarin.Forms;

namespace TaskApp.Views
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