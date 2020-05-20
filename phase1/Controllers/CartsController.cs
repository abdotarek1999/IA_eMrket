using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace phase1.Controllers
{
    public class CartsController : Controller
    {
        // GET: Carts
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddToCart(int id)
        {
            var cart = new cart();
            DateTime localDate = DateTime.Now;
            cart.added_at = localDate;
            cart.product_Id = id;
            var cart2 = db.carts.Find(id);
            if (cart2 != null)
            {
                return RedirectToAction("Filter", "products");
            }
            else
            {
                db.carts.Add(cart1);
                db.SaveChanges();
                return RedirectToAction("Filter", "products");
            }
        }
        public ActionResult Remove(int id)
        {
            var _cart = db.carts.Find(id);
            if (_cart != null)
            {
                db.carts.Remove(_cart);
            }
            db.SaveChanges();
            return RedirectToAction("Filter", "products");
        }

    }
}