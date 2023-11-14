using EntityFrameworkCore1.DAL;
using EntityFrameworkCore1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore1.Services
{
    internal class StudentService
    {
        AppDbContext context = new AppDbContext();
        private List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            if (student != null)
            {
                context.Students.Add(student);
                context.SaveChanges();
            }

        }
        public void Delete(int studentId)
        {
            var studentRemove = context.Students.Find(studentId);
            if (studentRemove != null)
            {
                context.Students.Remove(studentRemove);
                context.SaveChanges();
            }
        }

        public void Update(Student updateStudent)
        {
            var oldStudent = context.Students.Find(updateStudent.Id);
            if (oldStudent != null)
            {
                oldStudent.Name = updateStudent.Name;
                context.SaveChanges();
            }

        }

        public List<Student> GetAll()
        {
            return students;
        }


    }
}
