using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    public class ChoiceController : Controller
    {
        private readonly IChoiceRepository _choiceRepo;
        private readonly ILogger<ChoiceController> _log;

        public ChoiceController(IChoiceRepository choiceRepo, ILogger<ChoiceController> log)
        {
            _choiceRepo = choiceRepo;
            _log = log;
        }

        // GET: Choice
        public ActionResult Index()
        {
            return View();
        }

        // GET: Choice/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Choice/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Choice/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Choice/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Choice/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Choice/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Choice/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}