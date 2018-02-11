using Dominio.Clinica.Entidades;
using Dominio.Clinica.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinica
{
    public class BancoDb : DbContext
    {



        public BancoDb() : base("name=cli")
        {
            Database.SetInitializer<BancoDb>(new CreateDatabaseIfNotExists<BancoDb>());
        }

        public virtual DbSet<Resultado> Resultados { get; set; }



        public virtual DbSet<Paciente> Paciente { get; set; }

        public virtual DbSet<Exame> Exames { get; set; }

        public virtual DbSet<Recepcao> Recepcao { get; set; }

        public virtual DbSet<Fixa> Fixas { get; set; }

        public virtual DbSet<Medico> Medicos { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //    modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.Add(new FixaMap());
            modelBuilder.Configurations.Add(new RecepcaoMap());
            modelBuilder.Configurations.Add(new ExameMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            modelBuilder.Configurations.Add(new ResultadoMap());
            modelBuilder.Configurations.Add(new MedicoMap());

            //redefinir convenções padrão do entityframework..
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);


            //}


        }
    }
}
