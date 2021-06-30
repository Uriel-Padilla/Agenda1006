using Agenda1006.Models;
using Agenda1006.Service;
using Agenda1006.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agenda1006.ViewModels
{
    public class ContactoViewModel : Base
    {
        public ObservableCollection<ContactoModel> Contactos { get; set; }
        public Command CargarContactos{ get; set;}
        public static ContactoService servicio;
        public ContactoViewModel()
        {
            Titulo = "Agenda de contactos";
            Contactos = new ObservableCollection<ContactoModel>();
            CargarContactos = new Command(async () => await ExecuteLoadItemsCommand());
            MessagingCenter.Subscribe<AgregarContacto, ContactoModel>(this, "Agregarcontacto", async (obj, item) =>
            {
                var newItem = item as ContactoModel;
                Contactos.Add(newItem);
                await ContactoViewModel.ContactoService.guardarContacto(newItem);
            });
        }
        public static ContactoService ContactoService {
            get{ 
                if(servicio == null)
                {
                    servicio = new ContactoService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Contactos.db3"));
                }
                return servicio;
            }
        }
        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;
            try
            {
                Contactos.Clear();
                var Items = await ContactoViewModel.ContactoService.obtenerContactos();
                foreach(var item in Items)
                {
                    Contactos.Add(item);
                }
                var contacto = new ContactoModel
                {
                    nombreContacto = "Jose",
                    apellidos = "Gomez",
                    numeroTelefono = "9510101011",
                    tipoNumero = "Movil",
                    correoElectronico = "benito@gmail.com",
                    direccion = "Miahuatlan"
                };
                Contactos.Add(contacto);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
            }
            finally
            {
                IsBusy = false;
            }
            
        }

    }
}
