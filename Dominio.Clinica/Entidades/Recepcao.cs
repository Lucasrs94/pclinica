using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clinica.Entidades
{
     public class Recepcao
    {

        public int IdRecepcao { get; set; }

        public int IdFixa { get; set; }

        public Fixa FixaRecepcao { get; set; }


    }
}
