using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBScraper.Domain;

namespace BBScraper.Infra
{
    public class Contexto : DbContext
    {
        public Contexto(): base ("Banco")
        {

        }

        public DbSet<UsuarioRepositorio> UsuarioRepositorio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
