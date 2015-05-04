using RequestPortalDemo.Domain;
using RequestPortalDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequestPortalDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            

            return View(new RequestFormVM());
        }
        public JsonResult GetRequestor(string Id)
            {
            try
            {
                //TODO: Get all requestors and filter in DAL
                // Add code here to get based on ID
                var RequestorList = new List<Requestor>()
            {
                new Requestor{Id="388849",Name="sasithar",Email="sasithar.v@tcs.com",Manager="anthony@tcs.com",Phone="123456789"},
                new Requestor{Id="388850",Name="sudesh",Email="sudesh.shenoyb@tcs.com",Manager="hari.baskar@tcs.com",Phone="7795678589"},
                new Requestor{Id="388883",Name="sudhir",Email="sudhir.kamath@tcs.com",Manager="mark.spencer@tcs.com",Phone="714456789"}
            };
                if (!string.IsNullOrEmpty(Id) && !string.IsNullOrWhiteSpace(Id))
                {
                    var requestor = RequestorList.FirstOrDefault(x => x.Id.Equals(Id));
                    if (requestor != null)
                        return Json(new { status = true, requestor = requestor });
                }
                return Json(new { status = false, errorMessage = "Please provide a valid existing ID" });
            }
            catch (Exception ex)
            {
                return Json(new { status = false, errorMessage = "There has been certain technical issues.Kindly contact us" });
            }
        }
    }
}
