using Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Services
{
    public interface ITeacherSvc
    {
        List<Teacher> GetTeacherAll();

        Teacher GetTeacher(int id); 

        int AddTeacher(Teacher teacher);

        int EditTeacher(int id, Teacher teacher);

        int DeleteTeacher(int id);

        bool TeacherExists(int id);
    }
    public class TeacherSvc : ITeacherSvc
    {
        protected DataContext _context;
        public TeacherSvc(DataContext context)
        {
            _context = context;
        }

        public List<Teacher> GetTeacherAll()
        {
            List<Teacher> list = new List<Teacher>();
            list = _context.Teachers.ToList();
            return list;
        }

        public Teacher GetTeacher(int id)
        {
            Teacher teacher = null;
            teacher = _context.Teachers.Find(id);
            return teacher;
        }
        
        public int AddTeacher(Teacher teacher)
        {
            int ret = 0;
            try
            {
                _context.Add(teacher);
                _context.SaveChanges();
                ret = teacher.TeacherId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditTeacher(int id, Teacher teacher)
        {
            int ret = 0;
            try
            {
                _context.Update(teacher);
                _context.SaveChanges();
                ret = teacher.TeacherId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int DeleteTeacher(int id)
        {
            int ret = 0;
            try
            {
                var teacher = _context.Teachers.Find(id);
                _context.Remove(teacher);
                _context.SaveChanges();
                ret = teacher.TeacherId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public bool TeacherExists(int id)
        {
            return _context.Teachers.Any(e => e.TeacherId == id);
        }
    }
}
