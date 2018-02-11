using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Dominio.Clinica.Entidades
{
   public  class Paciente
    {

        public Paciente()
        {
            AvailableCountries = new List<SelectListItem>();
        }

        public int IdPaciente { get; set; }

        public string nome { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }

        public string cpf { get; set; }

        public string numsus { get; set; }

        public string telefone { get; set; }

     
        public string email { get; set; }

   
        public string estado { get; set; }

        public string cidade { get; set; }

        public virtual ICollection<Fixa> PacienteFixa { get; set; }
        public virtual ICollection<Exame> Exames { get; set; }
        public IEnumerable<SelectListItem> Accounts { get; set; }

    }
}
