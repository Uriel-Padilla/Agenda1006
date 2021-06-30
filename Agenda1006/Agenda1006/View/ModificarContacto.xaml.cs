using System;
using System.Collections.Generic;
using Agenda1006.Models;
using Xamarin.Forms;

namespace Agenda1006.View
{
    public partial class ModificarContacto : ContentPage
    {
        public ContactoModel contactoModel { get; set; }

        public ModificarContacto(ContactoModel contacto)
        {
            InitializeComponent();
            contactoModel = contacto;
            BindingContext = this;
        }

        public ModificarContacto()
        {
            InitializeComponent();
            contactoModel = new ContactoModel
            {
                nombreContacto = "",
                apellidos = "",
                numeroTelefono = null,
                tipoNumero = null,
                correoElectronico = "",
                direccion = ""
            };
            BindingContext = this;
        }

        async void clickCancelar(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        async void clickGuardar(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "Agregarcontacto", contactoModel);
            await Navigation.PopModalAsync();
        }

        public IList<string> TiposTelefono
        {
            get
            {
                return new List<string> { "Móvil", "Casa", "Trabajo" };
            }
        }
    }
}
