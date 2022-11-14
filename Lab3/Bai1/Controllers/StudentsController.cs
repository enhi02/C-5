using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bai1.Models;

namespace Bai1.Controllers
{
    public class StudentsController : Controller
    {
       /* private readonly DataContext _context;

        public StudentsController(DataContext context)
        {
            _context = context;
        }*/

        // GET: Students
        public async Task<IActionResult> Index()
        {
            using(var _context=new DataContext())
            {
                return View(await _context.Students.ToListAsync());
            }    
            
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            using (var _context = new DataContext())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var student = await _context.Students
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (student == null)
                {
                    return NotFound();
                }

                return View(student);
            }    
                
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Gender,BirthDay,BatchTime,PhoneNo,EmailAdd,Url,PassWord,RetypePass")] Student student)
        {
            using(var _context=new DataContext())
            {
                if (ModelState.IsValid)
                {
                    _context.Add(student);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(student);
            }    
           
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            using(var _context=new DataContext())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var student = await _context.Students.FindAsync(id);
                if (student == null)
                {
                    return NotFound();
                }
                return View(student);
            }    
           
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Gender,BirthDay,BatchTime,PhoneNo,EmailAdd,Url,PassWord,RetypePass")] Student student)
        {
            using(var _context=new DataContext())
            {
                if (id != student.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(student);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!StudentExists(student.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(student);
            }    
            
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            using( var _context=new DataContext())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var student = await _context.Students
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (student == null)
                {
                    return NotFound();
                }

                return View(student);
            }    
            
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using(var _context= new DataContext())
            {
                var student = await _context.Students.FindAsync(id);
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }    
            
        }

        private bool StudentExists(int id)
        {
            using(var _context=new DataContext())
            {
                return _context.Students.Any(e => e.Id == id);
            }     
        }
    }
}
