using Dominio.Clinica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clinica.Map
{
     public  class RecepcaoMap : EntityTypeConfiguration<Recepcao>
    {
        public RecepcaoMap()
        {

            ToTable("Recepcao","dbo");
            HasKey(c => c.IdRecepcao);

            Property(c => c.IdRecepcao)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.IdFixa).HasColumnName("IdFixa")
                .HasColumnType("int")
                .IsRequired();


            HasRequired(x => x.FixaRecepcao)
              .WithMany()
                .HasForeignKey(x => x.IdFixa);



        }
    }
}
