using DTP_HTML_ASP_Web_core_app.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.ComponentModel.DataAnnotations;

namespace DTP_HTML_ASP_Web_core_app.Controllers
{
    public class CourseController : Controller
    {
        // GET: CourseController
        public ActionResult Index()
        {
            List<Course> courses = new List<Course>
            {
                new Course { Id = 1, Title = "Introduction to ASP.NET Core", Teacher = "John Doe", DurationInWeeks = 6 },
                new Course { Id = 2, Title = "Advanced C# Programming", Teacher = "Jane Smith", DurationInWeeks = 8 },
                new Course { Id = 3, Title = "Web Development with MVC", Teacher = "Mike Johnson", DurationInWeeks = 5 }
            };
            return View(courses);
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
