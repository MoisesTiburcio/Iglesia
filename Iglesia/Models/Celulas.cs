using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Iglesia.Models
{

  public class Celula

  { 
      [Key]
  public int  Id_Iglesia{ get; set; }
  public int  Id_celula { get; set; }
  public DateTime   Fecha { get; set; }
  public string  Redes { get; set; }
  public string   Lideres { get; set; }
  public string   Anfitrion { get; set; }
  public string   Supervisor { get; set; }
  public string   Provincia { get; set; }
  public string   Sector { get; set; }

  public virtual ICollection<Control_Celulas> Control_Cel { get; set; }
  }
 

   
   

}
