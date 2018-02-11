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
     public  class MedicoMap : EntityTypeConfiguration<Medico>
    {

        public MedicoMap()
        {




            ToTable("Medico", "dbo");
            HasKey(x => x.IdMedico);

            Property(x => x.IdMedico).HasColumnName("IdMedico")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption
                .Identity);


            Property(x => x.nome).HasColumnName("nome")
            
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.IdExame)
               .HasColumnName("idExame")
               .IsRequired();




            HasRequired(e => e.ExamesMedicos)
               .WithMany(c => c.Medicos)
               .HasForeignKey(p => p.IdExame);


        }
    }
}
