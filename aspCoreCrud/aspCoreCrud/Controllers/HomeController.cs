using System.Diagnostics;
using aspCoreCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aspCoreCrud.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDBContext studentDB;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(StudentDBContext studentDB)
        {
            this.studentDB = studentDB;
        }

        public async Task<IActionResult> Index()
        {
            var list_of_std = await studentDB.Students.ToListAsync();
            return View(list_of_std);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {
            if(ModelState.IsValid)
            {
                await studentDB.Students.AddAsync(std);
                await studentDB.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }
            return View(std);
        }
        public async Task<IActionResult> Details(int id)
        {
            var list_of_std = await studentDB.Students.FirstOrDefaultAsync(x=>x.Id==id);
            return View(list_of_std);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var list_of_std = await studentDB.Students.FindAsync(id);
            return View(list_of_std);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,Student std)
        {
            
            if (ModelState.IsValid)
            {
                studentDB.Students.Update(std);
                await studentDB.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(std);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var list_of_std = await studentDB.Students.FirstOrDefaultAsync(x => x.Id == id);
            return View(list_of_std);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> Deleteconfimed(int id)
        {
            var list_of_std = await studentDB.Students.FindAsync(id);
            if(list_of_std != null)
            {
                studentDB.Students.Remove(list_of_std);
            }
            await studentDB.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
