using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task_Manager_Application.Mvc.Entities.Repositories;
using Task_Manager_Application.Mvc.Models;

namespace Task_Manager_Application.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITaskRepository _taskRepository;

        public HomeController(ILogger<HomeController> logger, ITaskRepository taskRepository)
        {
            _logger = logger;
            _taskRepository = taskRepository;
        }

        public async Task<IActionResult> Index()
        {
            DateTime dateTime = DateTime.Now;
            ViewBag.Dates = dateTime;
            var tasks = await _taskRepository.GetAllAsync();
            return View(tasks);
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
