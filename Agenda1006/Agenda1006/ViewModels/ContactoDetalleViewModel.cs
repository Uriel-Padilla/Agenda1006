using Agenda1006.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda1006.ViewModels
{
    public class ContactoDetalleViewModel : Base
    {
        public ContactoModel Contacto { get; set; }
        public ContactoDetalleViewModel(ContactoModel contacto = null)
        {
            Titulo = contacto?.nombreContacto;
            Contacto = contacto;
        }
    }
}
