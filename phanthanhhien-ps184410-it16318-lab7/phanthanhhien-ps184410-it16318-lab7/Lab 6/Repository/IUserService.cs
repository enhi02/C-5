using Lab_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_6.Repository
{
    public interface IUserService
    {
        Task<UserInfo> GetUser(string email, string password);
    }
}
