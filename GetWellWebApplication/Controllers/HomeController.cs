using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetWellWebApplication.Models;
using CliassLibrary;
using static CliassLibrary.BussinessLogic.PatientProcessor;
using static CliassLibrary.BussinessLogic.MedecinProcessor;

using Newtonsoft.Json;

namespace GetWellWebApplication.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        

        //public JsonResult GetAllLocation()
        //{
        //    var data = context.medecin.ToList().First();
        //    return Json(data, JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult GetAllLocationById(int id)
        //{
        //    var data = context.medecin.Where(x => x.Id_doc == id).SingleOrDefault();
        //    return Json(data, JsonRequestBehavior.AllowGet);
        //}
        
        [HttpGet]
        public ActionResult TeleConsultation()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult TeleConsultation(TelcPatient telc)
        {
            if (ModelState.IsValid)
            {
                CreateTelPatient(telc.patient.CIN,
                     telc.patient.Nom,
                     telc.patient.Prenom,
                     Convert.ToDateTime(telc.patient.Date_naissance),
                     telc.patient.Tel,
                     telc.patient.Email,
                     telc.teleconsultation.Description);
            }
            ViewBag.Data = "Exists";
            return View();
        }

        [HttpGet]
        public ActionResult PrendreRendezvous()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult PrendreRendezvous(patient patient)
        {
            bool result;
            if (ModelState.IsValid)
            {
                result = CreatePatient(patient.CIN,
                     patient.Nom,
                     patient.Prenom,
                     Convert.ToDateTime(patient.Date_naissance),
                     patient.Tel,
                     patient.Email);
                if (result)
                {
                    ViewBag.Data = null;
                    return RedirectToAction("JourRendezvous");
                }
                else
                {
                    ViewBag.Data = "Exists";
                    return View();
                }
            }
            return new EmptyResult();
        }

        [HttpGet]
        public ActionResult AlreadyExistMessage()
        {
            return PartialView();
        }

        public ActionResult AlreadyExistMessageForTeleconsultation()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult AlreadyExistMessagePost()
        {
            return RedirectToAction("JourRendezvous");
        }

        [HttpGet]
        public ActionResult JourRendezvous()
        {
            return View();
        }

        [HttpPost]
        public ActionResult JourRendezvous(rendezvous rendezvous)
        {

            return View();
        }
        [HttpGet]
        public ActionResult information_medecin()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult information_medecin(medecin medecin)
        {
            bool result;
            if (ModelState.IsValid)
            {
                result = CreateMedecin(medecin.Username,
                    medecin.cin,
                    medecin.Nom,
                    medecin.Prenom,
                    Convert.ToByte( medecin.Image),
                    medecin.Tel,
                    medecin.Email,
                    medecin.password,
                    medecin.ville,
                    medecin.Adresse,
                    Convert.ToDouble(medecin.longitude),
                    Convert.ToDouble(medecin.latitude),
                    medecin.Linkeden,
                    medecin.Facebook,
                    medecin.Whatsapp,
                    medecin.Instagram,
                    medecin.Twitter);
                if (result)
                {
                    ViewBag.Data = null;
                    return RedirectToAction("Accueil");
                }
                else
                {
                    ViewBag.Data = "Exists";
                    return View();
                }
            }
            return new EmptyResult();
        }
        public ActionResult Accueil()
        {
            return View();
        }

    }
}