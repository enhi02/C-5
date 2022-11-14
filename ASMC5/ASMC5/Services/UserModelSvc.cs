using WebMonAn.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonAn.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebMonAn.Models.ViewModels;

namespace WebMonAn.Services
{
    public interface IUserModelSvc
    {
        List<UserModel> GetUserModelAll();

        UserModel GetUserModel(int id);

        int AddUserModel(UserModel userModel);

        int EditUserModel(int id, UserModel userModel);

        SelectList GetSelectList(UserModel userModel);

        SelectList GetSelectList();



        public UserModel Login(ViewLogin viewLogin);
    }

    public class UserModelSvc : IUserModelSvc
    {
        protected DataContext _context;
        protected IMahoaHelper _mahoaHelper;

        public UserModelSvc(DataContext context, IMahoaHelper mahoaHelper)
        {
            _context = context;
            _mahoaHelper = mahoaHelper;
        }

        public List<UserModel> GetUserModelAll()
        {
            List<UserModel> list = new List<UserModel>();
            list = _context.userModels.ToList();
            return list;
        }

        public UserModel GetUserModel(int id)
        {
            UserModel userModel = null;
            userModel = _context.userModels.Find(id);
            //product = _context.Products.Where(e=>e.Id==id).FirstOrDefault();
            return userModel;
        }

        public int AddUserModel(UserModel userModel)
        {
            int ret = 0;
            try
            {
                
                userModel.Role = 3;
                userModel.Password = _mahoaHelper.Mahoa(userModel.Password);
                userModel.ConfirmPassword = _mahoaHelper.Mahoa(userModel.ConfirmPassword);
                _context.Add(userModel);
                _context.SaveChanges();
                ret = userModel.NguoiDungId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditUserModel(int id, UserModel userModel)
        {
            int ret = 0;
            try
            {
                UserModel _userModel = null;
                _userModel = _context.userModels.Find(id);

                _userModel.UserName = userModel.UserName;
                _userModel.FullName = userModel.FullName;
                _userModel.Email = userModel.Email;
                _userModel.Gender = userModel.Gender;
                _userModel.NgaySinh = userModel.NgaySinh;
                _userModel.DiaChi = userModel.DiaChi;
                _userModel.DienThoai = userModel.DienThoai;

                if(userModel.Password != null)
                {
                    userModel.Password = _mahoaHelper.Mahoa(userModel.Password);
                    _userModel.Password = userModel.Password;
                }
                _context.Update(_userModel);
                _context.SaveChanges();
                ret = userModel.NguoiDungId;
            }
            catch
            {
                ret = 0;
            }
            return ret;


        }
        public SelectList GetSelectList()
        {
            return new SelectList(_context.roleModels, "RoleId", "RoleName");
        }

        public SelectList GetSelectList(UserModel userModel)
        {
            return new SelectList(_context.roleModels, "RoleId", "RoleName", userModel.Role);
        }

        public UserModel Login(ViewLogin viewLogin)
        {
            var u = _context.userModels.Where(
                p => p.UserName.Equals(viewLogin.UserName)
                && p.Password.Equals(_mahoaHelper.Mahoa(viewLogin.PassWord))
                ).FirstOrDefault();
            return u;
        }
    }
}
