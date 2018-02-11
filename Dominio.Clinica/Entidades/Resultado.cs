using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clinica.Entidades
{
    public class Resultado
    {
        public int IdResultado { get; set; }

        public string nome { get; set; }

        public int IdExame { get; set; }


        public Exame ExameResultado { get; set; }

        public int IdMedico { get; set; }

        public Medico MedicoResultado { get; set; }

      
    }
}
