using Aplicao.Clinica.PacienteForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.mvc.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IServicosPacientes _servicosPaciente;

        public PacienteController(IServicosPacientes _servicosPacient)
        {

            this._servicosPaciente = _servicosPacient;




        }


      
        // GET: Paciente
        public ActionResult Index()
        {




            FormPaciente cadastrar = new FormPaciente();

            return View("Create", cadastrar);
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





                _servicosPaciente.cadastrar(cadastrar);

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
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
    }
}
