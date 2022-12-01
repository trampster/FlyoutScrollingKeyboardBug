using System.ComponentModel;
using Xamarin.Forms;
using FlyoutScrollingKeyboardBug.ViewModels;

namespace FlyoutScrollingKeyboardBug.Views
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
