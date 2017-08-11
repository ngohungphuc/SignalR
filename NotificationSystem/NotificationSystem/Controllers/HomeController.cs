using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NotificationSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetNotificationContacts()
        {
            var notificationRegisterTime = Session["LastUpdated"] != null
                ? Convert.ToDateTime(Session["LastUpdated"])
                : DateTime.Now;
            NotificationComponent ncComponent = new NotificationComponent();
            var list = ncComponent.GetContacts(notificationRegisterTime);
            Session["LastUpdated"] = DateTime.Now;
            return new JsonResult{Data=list,JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }
    }
}