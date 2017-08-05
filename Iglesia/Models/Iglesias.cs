using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Iglesia.Models
{

    public class Iglesias
    {
        [Key]
        public int Id_Iglesia { get; set; }
        public string Nombre_Iglesia { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Provincia { get; set; }
        public string Sector { get; set; }
        public string Pais { get; set; }
        public DateTime Fecha { get; set; }


        public virtual ICollection<Control_Celulas> Control_Cel { get; set; }

    }

}
