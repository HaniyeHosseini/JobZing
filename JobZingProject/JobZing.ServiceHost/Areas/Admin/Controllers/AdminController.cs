using JobZing.Core.Interfaces.Job;
using Microsoft.AspNetCore.Mvc;

namespace JobZing.ServiceHost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly IJobCategoryService _jobCategoryService;

        public AdminController(IJobCategoryService jobCategoryService)
        {
            _jobCategoryService = jobCategoryService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetJobCategories()
        {
            var categories = _jobCategoryService.GetJobCategories().Result;
            return View("/Views/Admin/JobCategory/Index",categories);
        }
    }
}
