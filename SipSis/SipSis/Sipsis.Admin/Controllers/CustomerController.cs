using Sipsis.Admin.Attribute;
using Sipsis.Admin.Models;
using SipSis.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sipsis.Admin.Controllers
{
    [Auth]
    public class CustomerController : BaseController
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View(service.CustomerService.GetAll());
        }

        public ActionResult Insert()
        {
            return View(service.MarketService.GetAll());
        }

        [HttpPost]
        public ActionResult Insert(CustomerVM gelen)
        {
            Customer customer = new Customer()
            {
                CustomerName = gelen.CustomerName,
                CustomerPhone = gelen.CustomerPhone,
                CustomerAddress = gelen.CustomerAddress,
                MarketID = gelen.MarketID,
                UserID = ((SessionContext)Session["SessionContext"]).ID,
            };
            service.CustomerService.Insert(customer);
            return Redirect("/Customer/Index");
        }

        public ActionResult CustomerSearch(string Phone)
        {
            var result = service.CustomerService.PhoneSearch(Phone);

            if (result.ID != 0)
            {
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}