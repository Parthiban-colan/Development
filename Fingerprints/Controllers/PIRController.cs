using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FingerprintsModel;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Globalization;
using FingerprintsData;




namespace Fingerprints.Controllers
{
    public class PIRController : Controller
    {

        string userid = "ee850d45-cd00-41a1-b311-99e70d28d79e";
        //this roleid (2d9822cd-85a3-4269-9609-9aabb914d792) is for HRManager testing
        //this roleid (2d9822cd-85a3-4269-9609-9aabb914d725) is made up for staff testing since
        //it doesn't matter what it is. only matters that it's not HR Manager.
        string roleid = "2d9822cd-85a3-4269-9609-9aabb914d725";
        string agencyid = "C40BB313-BAC6-44E3-A746-C34B03979797";
        [HttpGet]
        public ActionResult PIRSummary()
        {

            return View(new PIRData().GetPIR(Session["UserID"].ToString(), Session["AgencyID"].ToString()));

        }



    }
}
