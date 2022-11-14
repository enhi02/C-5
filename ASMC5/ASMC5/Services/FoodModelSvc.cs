using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonAn.Models;
using WebMonAn.Models.ViewModels;

namespace WebMonAn.Services
{
    public interface IFoodModelSvc
    {       
        List<FoodModel> GetFoodModelAll();

        FoodModel GetFoodModel(int id);

        int AddFoodModel(FoodModel foodModel);

        int EditFoodModel(int id, FoodModel foodModel);

        int DeleteFoodModel(int id);

        bool ExistsFoolModel(int id);

        SelectList GetSelectList();

        SelectList GetSelectList(FoodModel foodModel);
        IQueryable<FoodModel> GetFoodAll();
    }
    public class FoodModelSvc : IFoodModelSvc
    {
        protected DataContext _context;

        public FoodModelSvc(DataContext context)
        {
            _context = context;
        }

        public List<FoodModel> GetFoodModelAll()
        {
            List<FoodModel> list = new List<FoodModel>();
            list = _context.foodModels.ToList();
            return list;
        }

        public IQueryable<FoodModel> GetFoodAll()
        {
            //List<FoodModel> list = new List<FoodModel>();
            //list = _context.foodModels;
            return _context.foodModels.AsQueryable();
        }

        public FoodModel GetFoodModel(int id)
        {
            FoodModel foodModel = null;
            foodModel = _context.foodModels.Find(id);
            //product = _context.Products.Where(e=>e.Id==id).FirstOrDefault();
            return foodModel;
        }    

        public int AddFoodModel(FoodModel foodModel)
        {
            int ret = 0;
            try
            {
                _context.Add(foodModel);
                _context.SaveChanges();
                ret = foodModel.MonAnId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditFoodModel(int id, FoodModel foodModel)
        {
            int ret = 0;

            try
            {
                _context.Update(foodModel);
                _context.SaveChanges();
                ret = foodModel.MonAnId;
            }
            catch(Exception e)
            {
                ret = 0;
            }
            return ret;
        }

        public int DeleteFoodModel(int id)
        {
            int ret = 0;
            try
            {
                var food = _context.foodModels.Find(id);
                _context.Remove(food);
                _context.SaveChanges();
                ret = food.MonAnId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public bool ExistsFoolModel(int id)
        {
            return _context.foodModels.Any(e => e.MonAnId == id);
        }

        public SelectList GetSelectList()
        {
            return new SelectList(_context.categoryModels, "CategoryId", "CategoryName");
        }

        public SelectList GetSelectList(FoodModel foodModel)
        {
            return new SelectList(_context.categoryModels, "CategoryId", "CategoryName", foodModel.Category);
        }

  
    }
}
