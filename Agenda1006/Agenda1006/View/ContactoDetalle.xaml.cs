using Agenda1006.Models;
using Agenda1006.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda1006.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
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