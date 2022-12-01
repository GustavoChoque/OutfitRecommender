using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OutfitRecommender.Models;

namespace OutfitRecommender.Controllers
{
    public class LoginController : Controller
    {
        string userName = "Admin";
        string userPass = "qwerty";
        int id = 1;

        private readonly OutfitRecommenderContext _context;

        public LoginController(OutfitRecommenderContext context) { 
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string user, string pass)
        {

            var usu = await _context.Usuario.FirstOrDefaultAsync(u=>u.userName == user && u.password==pass);

           

            if (usu != null)
            {

                HttpContext.Session.SetString("userName", usu.userName);
                HttpContext.Session.SetInt32("id", usu.Id);

                
                return RedirectToAction(nameof(Index), "Home");
            }

            return RedirectToAction(nameof(Index));


        }

        public async Task<IActionResult> Logout()
        {

            HttpContext.Session.Clear();

            return RedirectToAction(nameof(Index));
        }
    }
}
