using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Molotok34.Models;

namespace Molotok34.Controllers
{
    public class CatalogController : Controller
    {
        private db_a87a62_gsmolotok34Entities db = new db_a87a62_gsmolotok34Entities();

        // GET: Catalog
        public ActionResult Index()
        {
            var products = db.Services.Include(p => p.Categoris);
            return View(products.ToList());
        }

        // GET: Catalog/Details/5
        //public ActionResult Product(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Products products = db.Products.Find(id);
        //    if (products == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(products);
        //}

        public ActionResult Product(int? id, [Bind(Include = "FullName,Phone,Email")] Clients clients)
        {
            if (String.IsNullOrEmpty(clients.Fullname) == false)
            {
                var clientsTmp = db_a87a62_gsmolotok34Entities.GetContext().Clients.ToList();
                clientsTmp = clientsTmp.Where(p => p.Phone.Contains(clients.Phone)).ToList();

                var client = clientsTmp.LastOrDefault();

                if (client == null)
                {
                    db.Clients.Add(clients);
                    db.SaveChanges();

                    var clientsTmp2 = db_a87a62_gsmolotok34Entities.GetContext().Clients.ToList();
                    clientsTmp2 = clientsTmp2.Where(p => p.Phone.Contains(clients.Phone)).ToList();
                    client = clientsTmp2.LastOrDefault();
                }

                ClientService sales = new ClientService();

                sales.IdClient = client.Id;
                sales.IdService = Convert.ToInt32(id);
                sales.Date = DateTime.Now;

                db.ClientService.Add(sales);
                db.SaveChanges();

                TempData["notice"] = "Вы успешно оплатили товар, вся информация отправлена на Вашу электронную почту, которую Вы указали";

                Services products = db.Services.Find(sales.IdService);
                if (products == null)
                {
                    return HttpNotFound();
                }
                return View(products);
            }
            else
            {
                Services products = db.Services.Find(id);
                if (products == null)
                {
                    return HttpNotFound();
                }
                return View(products);
            }
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
