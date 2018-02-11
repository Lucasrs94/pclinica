using Dominio.Clinica.Entidades;
using Infra.Clinica;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Aplicao.Clinica.PacienteForm
{
    public  interface IServicosPacientes  
    {

        Paciente cadastrar(FormPaciente form);
        List<Paciente> GetTarefas();

        //IEnumerable<SelectListItem> Accounts();


    }
}
