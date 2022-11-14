using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBaoVeMVC.Models;

namespace TestBaoVeMVC.Services
{
    public interface IRoot
    {
        Root GetRootId(int id);
        IEnumerable<Root> GetAll();
        void AddRoot(List<Root> root);

        void DeleteRoot();
    }
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

            if (root == null)
            {
                return null;
            }
            return root;
        }

        public IEnumerable<Root> GetAll()
        {
            return _context.Roots.ToList();
        }

        public void AddRoot(List<Root> root)
        {
            try
            {
                //root.RootID = 0;
                _context.AddRange(root);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public void DeleteRoot()
        {
            _context.RemoveRange(GetAll());
            _context.SaveChanges();
        }
    }
}
