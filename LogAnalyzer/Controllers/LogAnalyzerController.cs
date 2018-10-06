using LogAnalyzer.Models;
using LogAnalyzer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogAnalyzer.Controllers
{
    public class LogAnalyzerController : Controller
    {
        // GET: LogAnalyzer
        public ActionResult Index(string path)
        {
            
            
            return View();
        }

        public ActionResult Load()
        {
            LogReaderService reader = new LogReaderService();
            reader.Read("from");

            return View();
        }
    }
}
