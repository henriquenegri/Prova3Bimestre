using Microsoft.AspNetCore.Mvc;
using Prova3Bimestre.Data;

namespace Prova3Bimestre.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly AppCont _appCont;

        public FornecedorController(AppCont appCont)
        {
            _appCont = appCont;
        }
        public IActionResult Index()
        {
            var allFornec = _appCont.Fornecedores.ToList();
            return View(allFornec);
        }
    }
}
