using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace Iglesia.Models
{

    public class Control_Celulas
    {
        [Key]
        public int Id_Iglesia { get; set; }
        public int Celula { get; set; }
        public DateTime Fecha { get; set; }
        public int Visitas { get; set; }
        public int NC { get; set; }
        public int Ninos { get; set; }
        public int HC { get; set; }
        

    }

}