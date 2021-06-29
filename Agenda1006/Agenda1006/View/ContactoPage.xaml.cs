using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Agenda1006.Models;
using Agenda1006.ViewModels;
using System;

namespace Agenda1006.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactoPage : ContentPage
    {
        ContactoViewModel viewModel;
        public ContactoPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ContactoViewModel();

        }
        async void nuevoContacto(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new AgregarContacto()));
        }
    }
}