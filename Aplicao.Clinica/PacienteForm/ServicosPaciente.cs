using System;
using System.Collections.Generic;
using Dominio.Clinica.Entidades;
using Infra.Clinica;
using System.Linq;
using System.Web.Mvc;

namespace Aplicao.Clinica.PacienteForm
{
    public class ServicosPaciente :  IServicosPacientes
    {



        BancoDb contexto = new BancoDb();


        //atributo para inversão de dependencia..

        private IDomainServiceBase<Paciente> repository;
      
        //construtor para injeção de dependencia..

        public ServicosPaciente(IDomainServiceBase<Paciente> repository)
           

        {
        
            this.repository = repository;

        }

        public Paciente cadastrar(FormPaciente form)
        {


            var result = preencher(form);
            repository.Adicionar(result);
           
            return preencher(form);




        

      

        }

        public List<Paciente> GetTarefas()
        {

            //var query = from countries in repository.ListarTodos<()
            //            select countries;
            //var content = query.ToList<Paciente>();
            //return content;
            //var result = (from regs in contexto.Paciente select regs).Count();
            //var c = result;

            var result = from regs in contexto.Paciente.ToList() select regs;


            return            result.ToList();
        }


        private Paciente preencher(FormPaciente  pre) {
             

            var Paciente = new Paciente()
            {


                nome = pre.nome,
                cidade = pre.cidade,
                cpf = pre.cpf,
                email = pre.email,
                estado = pre.estado,
                telefone = pre.telefone,
                numsus = pre.numsus,
                
            };
            return Paciente;


        }
    }
}
