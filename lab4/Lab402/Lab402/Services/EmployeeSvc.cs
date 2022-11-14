using Lab402.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab402.Services
{
    public interface IEmployeeSvc
    {
        List<Employee> GetEmployeeAll();
        Employee GetEmployee(int id);
        int AddEmployee(Employee employee);
        int EditEmployee(int id, Employee employee);

        int DeleteEmployee(int id);

        bool EmployeeExists(int id);
    }
    public class EmployeeSvc : IEmployeeSvc
    {
        protected DataContext _context;
        public EmployeeSvc(DataContext context)
        {
            _context = context;
        }

        public List<Employee> GetEmployeeAll()
        {
            List<Employee> list = new List<Employee>();
            list = _context.Employees.ToList();
            return list;
        }

        public Employee GetEmployee(int id)
        {
            Employee employee = null;
            employee = _context.Employees.Find(id);
            return employee;
        }

        public int AddEmployee(Employee employee)
        {
            int ret = 0;
            try
            {
                _context.Add(employee);
                _context.SaveChanges();
                ret = employee.EmployeeId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditEmployee(int id, Employee employee)
        {
            int ret = 0;
            try
            {
                _context.Update(employee);
                _context.SaveChanges();
                ret = employee.EmployeeId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int DeleteEmployee(int id)
        {
            int ret = 0;
            try
            {
                var employee = _context.Employees.Find(id);
                _context.Remove(employee);
                _context.SaveChanges();
                ret = employee.EmployeeId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
