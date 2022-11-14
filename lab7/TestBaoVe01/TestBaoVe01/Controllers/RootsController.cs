using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TestBaoVe01.Interfaces;
using TestBaoVe01.Models;

namespace TestBaoVe01.Controllers
{
    public class RootsController : Controller
    {
        private readonly IRoot _rootSvc;

        public RootsController(IRoot rootSvc)
        {
            _rootSvc = rootSvc;
        }

        // GET: Roots
        public async Task<IActionResult> Index()
        {
            var url = "https://localhost:44389/api/";
            List<Root> list = new List<Root>();
            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.BaseAddress = new Uri(url);
                using (var response = await client.GetAsync("Root"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<Root>>(apiResponse);
                }
            }
            return View(list);
            //return View(await _context.Roots.ToListAsync());
        }

        //// GET: Roots/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var root = await _context.Roots
        //        .FirstOrDefaultAsync(m => m.ArticleID == id);
        //    if (root == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(root);
        //}

        //// GET: Roots/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Roots/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ArticleID,Title,TextID,Head,PublishTime,HitCount,CommentCount,URL,ChannelID,HeadImageUrl,ArticleType,ThumbImageUrl,Name")] Root root)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(root);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(root);
        //}

        //// GET: Roots/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var root = await _context.Roots.FindAsync(id);
        //    if (root == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(root);
        //}

        //// POST: Roots/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ArticleID,Title,TextID,Head,PublishTime,HitCount,CommentCount,URL,ChannelID,HeadImageUrl,ArticleType,ThumbImageUrl,Name")] Root root)
        //{
        //    if (id != root.ArticleID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(root);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!RootExists(root.ArticleID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(root);
        //}

        //// GET: Roots/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var root = await _context.Roots
        //        .FirstOrDefaultAsync(m => m.ArticleID == id);
        //    if (root == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(root);
        //}

        //// POST: Roots/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var root = await _context.Roots.FindAsync(id);
        //    _context.Roots.Remove(root);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool RootExists(int id)
        //{
        //    return _context.Roots.Any(e => e.ArticleID == id);
        //}
    }
}
