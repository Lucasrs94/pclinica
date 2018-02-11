using Aplicao.Clinica.PacienteForm;
using Dominio.Clinica.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clinica.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IServicosPacientes _servicosPaciente;

        public PacienteController(IServicosPacientes _servicosPacient)
        {

            this._servicosPaciente = _servicosPacient;




        }



        // GET: Paciente
        public ActionResult Index(Paciente cadastrare)
        {





            Paciente model = new Paciente();
            model.AvailableCountries.Add(new SelectListItem { Text = "-Please select-", Value = "Selects items" });
            var countries = _servicosPaciente.GetTarefas();
            foreach (var country in countries)
            {
                model.AvailableCountries.Add(new SelectListItem()
                {
                    Text = country.nome,
                    Value = country.IdPaciente.ToString()
                });
            }
        

            //    var pre =  new List<SelectListItem>
            //{
            //    new SelectListItem { Text = "Selecione", Value="", Selected = true},
            //    new SelectListItem { Text = "Cidade 1", Value="1"},
            //    new SelectListItem { Text = "Cidade 2", Value="2"},
            //    new SelectListItem { Text = "Cidade 3", Value="3"},
            //    new SelectListItem { Text = "Cidade 4", Value="4"},
            //    new SelectListItem { Text = "Cidade 5", Value="5"}
            //};

            //ViewData["Cidades"] = pre;






        






            return View("Index", model);
        }

        // GET: Paciente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Paciente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Paciente/Create
        [HttpPost]
        public ActionResult Create(FormPaciente cadastrar)
        {
            try
            {
                FormPaciente cadastrarr = new FormPaciente();




                _servicosPaciente.cadastrar(cadastrar);

                // TODO: Add insert logic here

                return View("Create"); }
            catch
            {
                return View("Create");
            }
        }

        // GET: Paciente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Paciente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Paciente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Paciente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        //[HttpPost]

        //[HttpGet]
        //public JsonResult ObterInsumo(string insumo)
        //{

        //    IList i = _servicosPaciente.GetTarefas()

        //    .Select(x => new
        //    {
        //        x. nome,
        //        x.IdPaciente
        //    })
        //    .ToList();




        //    return Json(i, JsonRequestBehavior.AllowGet);
        //}


      

    }


}
