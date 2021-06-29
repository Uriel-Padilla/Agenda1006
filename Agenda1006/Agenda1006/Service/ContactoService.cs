using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Agenda1006.Models;
using SQLite;

namespace Agenda1006.Service
{
    public class ContactoService : IContactoService<ContactoModel>
    {
        public SQLiteAsyncConnection db;

        public ContactoService(string url)
        {
            db = new SQLiteAsyncConnection(url);
            db.CreateTableAsync<ContactoModel>().Wait();
        }

        public Task<int> eliminarContacto(ContactoModel Contacto)
        {
            return db.DeleteAsync(Contacto);
        }

        public Task<int> guardarContacto(ContactoModel Contacto)
        {
            if(Contacto.contactoID == 0)
            {
                return db.InsertAsync(Contacto);
            }
            else
            {

                return db.UpdateAsync(Contacto);
            }

        }

        public Task<ContactoModel> obtenerContacto(int id)
        {
            return db.Table<ContactoModel>().Where(i => i.contactoID == id).FirstOrDefaultAsync();
        }

        public Task<List<ContactoModel>> obtenerContactos()
        {
            return db.Table<ContactoModel>().ToListAsync();
        }
    }
}
