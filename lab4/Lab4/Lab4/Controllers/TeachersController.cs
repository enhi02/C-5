using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab4.Models;
using Lab4.Services;

namespace Lab4.Controllers
{
    public class TeachersController : Controller
    {
        private ITeacherSvc _teacherSvc;

        public TeachersController( ITeacherSvc teacherSvc)
        {
            _teacherSvc = teacherSvc;
        }

        public IActionResult Index()
        {
            return View(_teacherSvc.GetTeacherAll());
        }

        public IActionResult Details(int id)
        {
            return View(_teacherSvc.GetTeacher(id));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _teacherSvc.AddTeacher(teacher);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Edit(int id)
        {

            var teacher = _teacherSvc.GetTeacher(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,Teacher teacher)
        {
           

            if (ModelState.IsValid)
            {
                _teacherSvc.EditTeacher(id, teacher);
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        public IActionResult Delete(int id)
        {

            var teacher = _teacherSvc.GetTeacher(id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _teacherSvc.DeleteTeacher(id);
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherExists(int id)
        {
            return _teacherSvc.TeacherExists(id);
        }
    }
}
