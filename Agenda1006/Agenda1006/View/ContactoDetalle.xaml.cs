using Agenda1006.Models;
using Agenda1006.ViewModels;
using System;
using Xamarin.Forms;

namespace Agenda1006.View
{
    public partial class ContactoDetalle : ContentPage
    {
        ContactoDetalleViewModel viewModel;
        public ContactoDetalle(ContactoDetalleViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;

        }
        public ContactoDetalle()
        {
            InitializeComponent();
            var contacto = new ContactoModel
            {
                nombreContacto = "",
                apellidos = "",
                numeroTelefono = null,
                tipoNumero = null,
                correoElectronico = "",
                direccion = ""
            };
            viewModel = new ContactoDetalleViewModel(contacto);
            BindingContext = viewModel;
        }

        async void clicModificar(object sender, EventArgs e)
        {
            await DisplayAlert("Proximamente", "Este módulo aun no se ha desarrollado", "OK");

        }
        async void clicEliminar(object sender, EventArgs e)
        {
            await DisplayAlert("Proximamente", "Este módulo aun no se ha desarrollado", "OK");
        }
    }
}