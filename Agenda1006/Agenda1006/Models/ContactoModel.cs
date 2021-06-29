using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Agenda1006.Models
{
    public class ContactoModel
    {
        [PrimaryKey,AutoIncrement]
        public int contactoID { get; set; }
        public string nombreContacto { get; set; }
        public string apellidos { get; set; }
        public string numeroTelefono { get; set; }
        public string tipoNumero { get; set; }
        public string correoElectronico { get; set; }
        public string direccion { get; set; }
        

    }
}
