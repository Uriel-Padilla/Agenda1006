using Agenda1006.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Threading.Tasks;

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

        async void clickSubirImagen(object sender, EventArgs e)
        {
            var pickResult = FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Selecciona una imagen"
            });
            if (pickResult != null)
            { 
                var stream = await pickResult.O;
                resultImage.Source = ImageSource.FromStream(() => stream);
            }
        }
    }
}