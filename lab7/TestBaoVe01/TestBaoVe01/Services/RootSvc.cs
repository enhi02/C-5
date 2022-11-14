using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBaoVe01.Interfaces;
using TestBaoVe01.Models;

namespace TestBaoVe01.Services
{
    public class RootSvc : IRoot
    {
        private readonly DataContext _context;

        public RootSvc(DataContext context)
        {
            _context = context;
        }

        public Root GetRootId(int id)
        {
            var root = _context.Roots.Find(id);

            if(root == null)
            {
                return null;
            }
            return root;
        }

        public IEnumerable<Root> GetAll()
        {
            return _context.Roots.ToList();
        }

        public Root AddRoot(Root root)
        {
            try
            {
                root.RootID = 0;
                _context.Add(root);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            
            return root;
        }

        public void DeleteRoot(Root root)
        {
            _context.Roots.Remove(root);
            _context.SaveChanges();
        }
    }
}
