using Xamarin.Forms;
using Agenda1006.Models;
using Agenda1006.ViewModels;
using System;

namespace Agenda1006.View
{
    public partial class ContactoPage : ContentPage
    {
        ContactoViewModel viewModel;

        public ContactoPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ContactoViewModel();
            refreshPage();

        }
        async void refreshPage()
        {
            _ = await Navigation.PopAsync(true);
        }

        async void nuevoContacto(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new AgregarContacto()));
        }

        async void OnItemSelected(object sender, EventArgs e)
        {
            var layaut = (BindableObject)sender;
            var item = (ContactoModel)layaut.BindingContext;
            await Navigation.PushAsync(new ContactoDetalle(new ContactoDetalleViewModel(item)));
        }

        async void clicModificar(object sender, EventArgs e)
        {
            var layaut = (BindableObject)sender;
            var item = (ContactoModel)layaut.BindingContext;
            await Navigation.PushModalAsync(new NavigationPage(new ModificarContacto(item)));
        }

        //Eliminar contacto
        async void clicEliminar(object sender, EventArgs e)
        {
            var layaut = (BindableObject)sender;
            var item = (ContactoModel)layaut.BindingContext;
            MessagingCenter.Send(this, "Eliminarcontacto", item);
            await Navigation.PopAsync(true);
        }
    }
}