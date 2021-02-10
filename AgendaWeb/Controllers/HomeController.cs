using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AgendaWeb.Models;

namespace AgendaWeb.Controllers
{
    public class HomeController : Controller
    {
        private ContatoContext db = new ContatoContext();

        // GET: Home
        public ActionResult Index(string searchString)
        {
            var contatos = from c in db.contatos
                           orderby c.nome
                           select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                var pesquisa = searchString.ToUpper();
                contatos = (IOrderedQueryable<Contato>)contatos.Where(s => s.nome.ToUpper().Contains(pesquisa)).Union(contatos.Where(s => s.cidade.ToUpper().Contains(pesquisa))).Union(contatos.Where(s => s.telefone.ToUpper().Contains(pesquisa))).Union(contatos.Where(s => s.celular.ToUpper().Contains(pesquisa)));

            }
            return View(contatos.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contato contato = db.contatos.Find(id);
            if (contato == null)
            {
                return HttpNotFound();
            }
            return View(contato);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "contato_id,nome,telefone,celular,endereco,bairro,cidade,estado,cep")] Contato contato)
        {
            if (ModelState.IsValid)
            {
                db.contatos.Add(contato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contato);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contato contato = db.contatos.Find(id);
            if (contato == null)
            {
                return HttpNotFound();
            }
            return View(contato);
        }

        // POST: Home/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "contato_id,nome,telefone,celular,endereco,bairro,cidade,estado,cep")] Contato contato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contato);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contato contato = db.contatos.Find(id);
            if (contato == null)
            {
                return HttpNotFound();
            }
            return View(contato);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contato contato = db.contatos.Find(id);
            db.contatos.Remove(contato);
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
