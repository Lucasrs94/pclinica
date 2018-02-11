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
    public class PacienteMap : EntityTypeConfiguration<Paciente>
    {

        public PacienteMap()
        {
            ToTable("Paciente", "dbo");
            HasKey(x => x.IdPaciente);

            Property(x => x.IdPaciente).HasColumnName("IdPaciente")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption
                .Identity);


            Property(x => x.nome).HasColumnName("nome")

                .HasMaxLength(50)
                .IsRequired();



            Property(x => x.numsus).HasColumnName("numsus")

                .HasMaxLength(50)
                .IsRequired();


            Property(x => x.telefone).HasColumnName("telefone")

                .HasMaxLength(50)
                .IsRequired();





            Property(x => x.cidade).HasColumnName("cidade")

                .HasMaxLength(50)
                .IsRequired();



            Property(x => x.estado).HasColumnName("estado")

                .HasMaxLength(50)
                .IsRequired();


            Property(x => x.cpf).HasColumnName("cpf")
  

                .HasMaxLength(50)
                .IsRequired();


            Property(x => x.email).HasColumnName("email")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();








        }
    }
}
