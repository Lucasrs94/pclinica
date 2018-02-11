using System.Collections.Generic;

namespace Dominio.Clinica.Entidades
{
    public class Exame
    {



        public int IdExame { get; set; }
        public string nome { get; set; }

     
        public int IdPaciente { get; set; }

        public virtual Paciente PacienteExame { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
      
        public virtual ICollection<Paciente> Pacientes { get; set; }
        public virtual ICollection<Resultado> ExameResultados { get; set; }



        
    }
}
