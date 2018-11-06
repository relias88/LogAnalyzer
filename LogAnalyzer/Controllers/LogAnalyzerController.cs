using LogAnalyzer.Models;
using LogAnalyzer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace LogAnalyzer.Controllers
{
    public class LogAnalyzerController : Controller
    {
        LogListingService listing;
        LogAnalyzerModel model;
        ///[HttpPost]
        // GET: LogAnalyzer
        public ActionResult Index()
        {
            string path = WebConfigurationManager.AppSettings["logsDirectory"];
            listing = new LogListingService(path);
            model = listing.LoadModel();
            return View(model);
        }

        //[HttpPost]
        public ActionResult Load()
        {
            model = LogAnalyzerModel.GetModel();
            LogReaderService reader = new LogReaderService();
            foreach (var key in Request.Form.AllKeys)
            {
                if (Request.Form[key].Contains("true"))
                {
                    model.ContentListDict.Add(key, reader.Read(model.LogsDict[key]));
                }
            }

            return View("LogView", model);
        }
    }
}
