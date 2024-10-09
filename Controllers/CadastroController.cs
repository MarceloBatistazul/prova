using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Avaliçãoc_.Controllers
{
    public class CadastroController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}

