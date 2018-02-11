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
     public class ExameMap : EntityTypeConfiguration<Exame>
    {


        public ExameMap() {

            ToTable("Exame","dbo");
            HasKey(x => x.IdExame);

            Property(x => x.IdExame).HasColumnName("idExame")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption
                .Identity);


            Property(x => x.nome).HasColumnName("nome")
                
                .HasMaxLength(50)
                .IsRequired();


            Property(x => x.IdPaciente)
                .HasColumnName("IdPaciente")
                .IsRequired();





            HasRequired(p => p.PacienteExame)
                .WithMany(e => e.Exames)
                .HasForeignKey(p => p.IdPaciente);



        }
    }
}
