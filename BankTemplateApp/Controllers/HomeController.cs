using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankTemplateApp.ViewModels;

namespace BankTemplateApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var records = ClientRecords.CreateRecords(
                new List<ClientRecord>
                {
                    ClientRecord.CreateNewRecord("record 1", "address 1"),
                    ClientRecord.CreateNewRecord("record 2", "address 2"),
                    ClientRecord.CreateNewRecord("record 3", "address 3")
                });
               
            return PartialView("Index",records);
        }
    }
}