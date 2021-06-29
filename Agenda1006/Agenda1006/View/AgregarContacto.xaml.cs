using Agenda1006.Models;
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
    public partial class AgregarContacto : ContentPage
    {

        ContactoModel contactoModel { get; set; }
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

        }
        async void clickGuardar(object sender, EventArgs e)
        {

        }

        public IList<string> TiposTelefono {
            get
            {
                return new List<string> { "Móvil", "Casa", "Trabajo" };
            }
        }

    }
}