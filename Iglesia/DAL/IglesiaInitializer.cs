 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Iglesia.Models;
 

  
namespace Iglesia.DAL
{
    public class IglesiaInitializer :  System.Data.Entity.DropCreateDatabaseAlways<IglesiaContext>
    {
        protected override void Seed(IglesiaContext context)
        {

            var Iglesiaw = new List<Iglesias>
            {
            new Iglesias{Id_Iglesia=1, Nombre_Iglesia="Iglesia Cristiana",Telefono = "8092212624",Celular="8096854060", Direccion= "Calle Paseo de Los Periodistas, Santo Domingo ", Provincia="1" ,Sector ="10203", Pais="1", Fecha= DateTime.Parse("2017-08-01")}
            };

            Iglesiaw.ForEach(s => context.Iglesiax.Add(s));
            context.SaveChanges();
            
            var Celulaw = new List<Celula>
            {
            new Celula{Id_Iglesia=1,Id_celula=1, Fecha= DateTime.Parse("2017-08-01"),Redes= "1", Lideres="1", Anfitrion="1",Supervisor="1",Provincia="1", Sector="1"}
             
            };
            Celulaw.ForEach(s => context.Celula.Add(s));
            context.SaveChanges();

            var Control_Cel = new List<Control_Celulas>
            {
            new Control_Celulas{Id_Iglesia= 1, Fecha= DateTime.Parse("2017-08-01"), Celula=1, Visitas= 3,NC=10, Ninos= 4, HC= 26},
            
            };
            Control_Cel.ForEach(s => context.Control.Add(s));
            context.SaveChanges();
        }
    }
}
