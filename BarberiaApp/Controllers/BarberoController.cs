using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarberiaApp.Controllers
{
    public class BarberoController : Controller
    {
        // GET: BarberoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BarberoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BarberoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BarberoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BarberoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BarberoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BarberoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BarberoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
