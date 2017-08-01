using SampleWebApp.Domain.BusinessLogic;
using SampleWebApp.Domain.Core;
using SampleWebApp.Domain.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebApp.Controllers {
    public class HomeController : Controller {

        private IPermitsManager manager;
        public HomeController() {
            var dbContext = new SampleContext();
            IGenericRepository<TblPermits> DI_Repository = new GenericAdoNetRepository<TblPermits>(dbContext);
            IUnitOfWork DI_uow = new UnitOfWork(dbContext);


            this.manager = new PermitsManager(DI_Repository, DI_uow);
        }

        public ActionResult Index() {

            var model = manager.GetPermitLists();
            return View(model);
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}