using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebMonAn.Helpers;
using WebMonAn.Models;
using WebMonAn.Models.ViewModels;
using WebMonAn.Services;

namespace WebMonAn.Controllers
{
    public class FoodModelController : Controller
    {
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private IFoodModelSvc _foodModelSvc;
        private IUploadHelper _uploadHelper;
        private int countPage;
        private int currentPage;

        public double ITEM_PER_PAGE { get; private set; }

        public FoodModelController(IWebHostEnvironment webHostEnvironment, IFoodModelSvc foodModelSvc, IUploadHelper uploadHelper)
        {
            _WebHostEnvironment = webHostEnvironment;
            _foodModelSvc = foodModelSvc;
            _uploadHelper = uploadHelper;
        }
        
        public async Task<IActionResult> Index()
        {
            int totalPage = _foodModelSvc.GetFoodModelAll().Count();
            countPage = (int)Math.Ceiling((double)totalPage / ITEM_PER_PAGE);


            if (currentPage < 1)
                currentPage = 1;
            if (currentPage > countPage)
                currentPage = countPage;

            var pagingModel = new PagingModel()
            {
                currentpage = currentPage,
                countpages = countPage,
                generateUrl = (int? p) => Url.Page("/Product/Index", new { p = p }),
            };

            ViewData["PagingModel"] = pagingModel;

            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            ViewBag.FullName = HttpContext.Session.GetString("FullName");
            ViewBag.Role =  HttpContext.Session.GetInt32("Role");
            
            return View  (_foodModelSvc.GetFoodModelAll().Skip(currentPage).Take(10));
        }

        //public IActionResult Index()
        //{
        //    ViewBag.UserName = HttpContext.Session.GetString("UserName");
        //    ViewBag.FullName = HttpContext.Session.GetString("FullName");
        //    ViewBag.Role = HttpContext.Session.GetInt32("Role");
        //    return View(_foodModelSvc.GetFoodModelAll());
        //}
        // GET: FoodModelController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: FoodModelController/Details/5
        public IActionResult Details(int id)
        {
            var foodModel = _foodModelSvc.GetFoodModel(id);
            if ( foodModel == null)
            {
                return NotFound();
            }
            return View(foodModel);
        }

        // GET: FoodModelController/Create
        public IActionResult Create()
        {
            ViewData["Category"] = _foodModelSvc.GetSelectList();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FoodModel foodViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (foodViewModel.ImageFile != null)
                    {
                        _uploadHelper.UpLoadFile(foodViewModel.ImageFile);
                        foodViewModel.Image = foodViewModel.ImageFile.FileName;
                    }
                    _foodModelSvc.AddFoodModel(foodViewModel);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            ViewData["Category"] = _foodModelSvc.GetSelectList(foodViewModel);
            return View(foodViewModel);

            //if (ModelState.IsValid)
            //{
            //    string uniqueFileName = ProcessUploadedFile(foodViewModel);
            //    FoodModel foodModel = new FoodModel()
            //    {
            //        TenMonAn = foodViewModel.TenMonAn,
            //        TrangThai = foodViewModel.TrangThai,
            //        GiaMonAn = foodViewModel.GiaMonAn,
            //        SoLuong = foodViewModel.SoLuong,
            //        Category = foodViewModel.Category,

            //        Image = uniqueFileName,
            //        MonAnId = foodViewModel.MonAnId,
            //        IsDelete = foodViewModel.IsDelete,
            //        categoryModel = foodViewModel.categoryModel,
            //        MoTa = foodViewModel.MoTa
            //    };
            //    foodViewModel.ExistingImage = uniqueFileName;
            //    _foodModelSvc.AddFoodModel(foodViewModel);
            //    ViewData["Category"] = _foodModelSvc.GetSelectList(foodViewModel);
            //    await _foodModelSvc.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(foodViewModel);

        }

        //private string ProcessUploadedFile(FoodViewModel foodViewModel)
        //{
        //    string uniqueFileName = null;

        //    if (foodViewModel.Image != null)
        //    {
        //        string uploadsFolder = Path.Combine(Startup.webHostEnvironment.WebRootPath, "Uploads");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + foodViewModel.Image.FileName;
        //        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            foodViewModel.Image.CopyTo(fileStream);
        //        }
        //    }

        //    return uniqueFileName;
        //}

        public IActionResult Update(int id)
        {
            var foodModel = _foodModelSvc.GetFoodModel(id);
            if (foodModel == null)
            {
                return NotFound();
            }
            ViewData["Category"] = _foodModelSvc.GetSelectList();
            return View(foodModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, FoodModel foodModel)
        {
            if (id != foodModel.MonAnId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (foodModel.ImageFile != null)
                    {
                        _uploadHelper.UpLoadFile(foodModel.ImageFile);
                        foodModel.Image = foodModel.ImageFile.FileName;
                    }
                    _foodModelSvc.EditFoodModel(id, foodModel);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodModelExists(foodModel.MonAnId))
                    {
                        return NotFound();
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Category"] = _foodModelSvc.GetSelectList(foodModel);
            return View(foodModel);

            //if (foodViewModel == null)
            //{
            //    return NotFound();
            //}
            //var viewModel = new FoodViewModel()
            //{
            //    TenMonAn = foodViewModel.TenMonAn,
            //    TrangThai = foodViewModel.TrangThai,
            //    GiaMonAn = foodViewModel.GiaMonAn,
            //    SoLuong = foodViewModel.SoLuong,
            //    Category = foodViewModel.Category,


            //    MonAnId = foodViewModel.MonAnId,
            //    IsDelete = foodViewModel.IsDelete,
            //    categoryModel = foodViewModel.categoryModel,
            //    MoTa = foodViewModel.MoTa,
            //};

            //return View(foodViewModel);
        }

        private bool FoodModelExists(int id)
        {
            return _foodModelSvc.ExistsFoolModel(id);
        }



        // POST: FoodModelController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: FoodModelController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: FoodModelController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: FoodModelController/Delete/5
        public ActionResult Delete(int id)
        {
            var foodModel = _foodModelSvc.GetFoodModel(id);
            if (foodModel == null )
            {
                return NotFound();
            }    
            return View(foodModel);
        }

        // POST: FoodModelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var foodModel = _foodModelSvc.DeleteFoodModel(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
