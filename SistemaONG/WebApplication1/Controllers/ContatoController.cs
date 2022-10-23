using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class ContatoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContatoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var objContatoList = _context.Contatos.ToList();
            return View();
        }
    }
}
