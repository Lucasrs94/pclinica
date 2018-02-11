using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clinica.Entidades
{
     public  class Fixa
    {

        public int IdFixa { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        
        public string cpf { get; set; }

        public string numsus { get; set; }

        public string telefone { get; set; }

        public string email { get; set; }

        public string estado { get; set; }

        public string cidade { get; set; }

        public DateTime data { get; set; }

        public int IdPaciente { get; set; }

        public Paciente Pacientes { get; set; }

   

    }
}
