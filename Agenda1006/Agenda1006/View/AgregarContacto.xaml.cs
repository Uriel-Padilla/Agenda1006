﻿using Agenda1006.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Agenda1006.View
{
    public partial class AgregarContacto : ContentPage
    {

        public ContactoModel contactoModel { get; set; }

        public AgregarContacto()
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