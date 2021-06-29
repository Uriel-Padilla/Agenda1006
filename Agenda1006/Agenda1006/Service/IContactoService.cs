using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agenda1006.Service
{
    public interface IContactoService<T>
    {
        Task<int> guardarContacto(T Contacto);
        Task<List<T>> obtenerContactos();
        Task<T> obtenerContacto(int id);
        Task<int> eliminarContacto(T Contacto);

    }
}
