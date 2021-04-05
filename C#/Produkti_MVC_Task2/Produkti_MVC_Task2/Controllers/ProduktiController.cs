using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using Produkti_MVC_Task2.Models;

namespace Produkti_MVC_Task2.Controllers
{
    public class ProduktiController : Controller
    {

        private ProduktiContext db = new ProduktiContext();
        // GET: Produkti
        public ActionResult Index()
        {
            return View(db.Produkti.ToList());
        }

        // GET: Produkti/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produkti/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produkti/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Kods,Nosaukums,Skaits,Cena,Datums,Attels")] Produkti pr)
        {
            if (ModelState.IsValid)
            {
                db.Produkti.Add(pr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pr);
        }

 
        // GET: Produkti/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
