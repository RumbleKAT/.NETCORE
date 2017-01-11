using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ideacore.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ideacore.Controllers
{
    public class ideacontroller : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var repo = new ideaRepository();
            return View(repo.getAll());
        }

        [HttpPost]
        public IActionResult Index(idea model)
        {
            var repo = new ideaRepository();
            repo.add(model);
            return RedirectToAction("Index");
        }
    }
}
