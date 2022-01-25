using AccoutingWebApplication.Domain;
using AccoutingWebApplication.Domain.Models;
using AccoutingWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AccoutingWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.Employes.AllEmployes());
        }


        public IActionResult EditEmploye(Guid id)
        {
            var employe = id == default ? new Employe() : dataManager.Employes.GetById(id);
            return View(employe);
        }

        [HttpPost]
        public IActionResult EditEmploye(Employe employe)
        {
            if (ModelState.IsValid)
            {
                dataManager.Employes.AddEmploye(employe);

                return RedirectToAction("Index", "Home");
            }

            return View(employe);
        }

        [HttpPost]
        public IActionResult DeleteEmploye(Guid id)
        {
            dataManager.Employes.RemoveEmploye(id);

            return RedirectToAction("Index", "Home");

        }

        #region Dop

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #endregion
    }
}
