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
     public class FixaMap : EntityTypeConfiguration<Fixa>
    {

        public FixaMap()
        {

            ToTable("Fixa", "dbo");
            HasKey(x => x.IdFixa);

            Property(x => x.IdFixa).HasColumnName("IdFixa")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption
                .Identity);


            Property(x => x.nome).HasColumnName("nome")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();


            Property(x => x.endereco).HasColumnName("endereco")
              .HasColumnType("varchar")
              .HasMaxLength(50)
              .IsRequired();



            Property(x => x.data).HasColumnName("data")
              .HasColumnType("date")
            
              .IsRequired();




            Property(x => x.telefone).HasColumnName("telefone")
              .HasColumnType("varchar")
              .HasMaxLength(50)
              .IsRequired();


            Property(x => x.cidade).HasColumnName("cidade")
              .HasColumnType("varchar")
              .HasMaxLength(50)
              .IsRequired();



            Property(x => x.estado).HasColumnName("estado")
              .HasColumnType("varchar")
              .HasMaxLength(50)
              .IsRequired();

            Property(x => x.cpf).HasColumnName("cpf")
              .HasColumnType("varchar")
              .HasMaxLength(50)
              .IsRequired();

            Property(x => x.numsus).HasColumnName("numsus")
              .HasColumnType("varchar")
              .HasMaxLength(50)
              .IsRequired();


            Property(x => x.email).HasColumnName("email")
              .HasColumnType("varchar")
              .HasMaxLength(50)
              .IsRequired();



;

            Property(x => x.IdPaciente)
                .HasColumnName("IdPaciente")
                .IsRequired();



            HasRequired(p => p.Pacientes)
            .WithMany(e => e.PacienteFixa)
            .HasForeignKey(p => p.IdPaciente);


        }



    }
}
