using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Cadastro_de_Clientes.Data;


namespace Cadastro_de_Clientes.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppCont _appCont;

        public ClienteController(AppCont appCont)
        {
            _appCont = appCont;
        }

         public IActionResult Index()
        {
            var allClients = _appCont.Clientes.ToList();
            return View(allClients);
        }
    }
}
