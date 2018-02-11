using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Aplicao.Clinica.PacienteForm
{
    public  class FormPaciente 
    {
        public int? IdPaciente { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        [Display(Name = "Name")]
        public string nome { get; set; }

        [Required(ErrorMessage = "O cpf é obrigatório")]
        [Display(Name = "cpf")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "Numero do sus é obrigatório.")]
        [Display(Name = "Numero sus")]
        public string numsus { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório .")]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Required(ErrorMessage = "Email é obrigatório ")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Estado é obrigatorio")]
        [Display(Name = "Name")]
        public string estado { get; set; }

        [Required(ErrorMessage = "cidade é obrigatório")]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        public IEnumerable<SelectListItem> Accounts { get; set; }
        public virtual FormPaciente Topico { get; set; }


        public class FormExame 
        {



            public int id { get; set; }
            public string  nome { get; set; }


        }
    }
}
