using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBaoVe01.Models;

namespace TestBaoVe01.Interfaces
{
    public interface IRoot
    {
        Root GetRootId(int id);
        IEnumerable<Root> GetAll();
        Root AddRoot(Root root);
        void DeleteRoot(Root root);
    }
}
