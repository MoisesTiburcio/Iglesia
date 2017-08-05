using Iglesia.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Iglesia.DAL
{
    public class IglesiaContext : DbContext
    {

        public IglesiaContext()
            : base("IglesiaContext")
        {
        }

        public DbSet<Iglesias> Iglesiax { get; set; }
        public DbSet<Celula> Celula { get; set; }
        public DbSet<Control_Celulas> Control { get; set; }
        //public DbSet<Formulario_Bendicion> Formulario_Bendicion { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
