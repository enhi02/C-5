using Lab_6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_6.Repository
{
    public class UserService : IUserService
    {
        private readonly ReservationDBContext _context;
        public UserService(ReservationDBContext context)
        {
            _context = context;
        }
        public async Task<UserInfo> GetUser(string email,string password)
        {
            var userData = await _context.UserInfos.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
            return userData;
        }
    }
}
