using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2020AM601_2020CT601.Models;

namespace P2_2020AM601_2020CT601.Controllers
{
    public class equiposController : Controller
    {
        private readonly covidcontext _covidcontext;
        public IActionResult Index()
        {
            var listadoDepartamentos = (from d in _covidcontext.Departamentos select d).ToList();

            ViewData["listadoDepartamentos"] = new SelectList(listadoDepartamentos, "Iddepartamento", "nombreDepartamento");

            return View();
        }
    }
}
    