using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Iglesia.Models;
using Iglesia.DAL;

namespace Iglesia.Controllers
{
    public class IglesiaController : Controller
    {
        private IglesiaContext db = new IglesiaContext();

        // GET: /Iglesia/
        public ActionResult Index()
        {
            return View(db.Iglesiax.ToList());
        }

        // GET: /Iglesia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Iglesias iglesias = db.Iglesiax.Find(id);
            if (iglesias == null)
            {
                return HttpNotFound();
            }
            return View(iglesias);
        }

        // GET: /Iglesia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Iglesia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id_Iglesia,Nombre_Iglesia,Telefono,Celular,Direccion,Provincia,Sector,Pais,Fecha")] Iglesias iglesias)
        {
            if (ModelState.IsValid)
            {
                db.Iglesiax.Add(iglesias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iglesias);
        }

        // GET: /Iglesia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Iglesias iglesias = db.Iglesiax.Find(id);
            if (iglesias == null)
            {
                return HttpNotFound();
            }
            return View(iglesias);
        }

        // POST: /Iglesia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id_Iglesia,Nombre_Iglesia,Telefono,Celular,Direccion,Provincia,Sector,Pais,Fecha")] Iglesias iglesias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iglesias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iglesias);
        }

        // GET: /Iglesia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Iglesias iglesias = db.Iglesiax.Find(id);
            if (iglesias == null)
            {
                return HttpNotFound();
            }
            return View(iglesias);
        }

        // POST: /Iglesia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Iglesias iglesias = db.Iglesiax.Find(id);
            db.Iglesiax.Remove(iglesias);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
