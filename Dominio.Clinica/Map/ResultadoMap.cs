using Dominio.Clinica.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dominio.Clinica.Map
{
    public  class ResultadoMap : EntityTypeConfiguration<Resultado>
    {

        public ResultadoMap()
        {




            ToTable("Resultado", "dbo");
            HasKey(x => x.IdResultado);

            Property(x => x.IdResultado).HasColumnName("IdResultado")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption
                .Identity);


            Property(x => x.nome).HasColumnName("nome")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();


            Property(x => x.IdExame)
                .HasColumnName("IdExame")
                .IsRequired();

            Property(x => x.IdMedico)
                .HasColumnName("IdMedico")
                .IsRequired();


            HasRequired(p => p.ExameResultado)
            .WithMany(e => e.ExameResultados)
            .HasForeignKey(p => p.IdExame);



            HasRequired(p => p.MedicoResultado)
            .WithMany()
            .HasForeignKey(p => p.IdMedico);


        }
    }
}
