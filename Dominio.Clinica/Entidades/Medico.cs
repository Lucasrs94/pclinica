using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clinica.Entidades
{
     public  class Medico
    {
        public int IdMedico { get; set; }

        public string nome { get; set; }

        public int IdExame { get; set; }

        public  virtual Exame ExamesMedicos { get; set; }

        //Outros atributos da classe
        public virtual ICollection<Exame>Exames { get; set; }
    }
}
