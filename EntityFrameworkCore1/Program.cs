using EntityFrameworkCore1.Models;
using EntityFrameworkCore1.Services;

namespace EntityFrameworkCore1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            Student student1 = new Student()
            {
                Name = "Khadija",
                Age= 19
            };

            Student student2 = new Student()
            {
                Name = "Aysel",
                Age= 21
            };

            Student student3 = new Student()
            {
                Name = "Sebine",
                Age = 24
            };

            studentService.Add(student1);
            studentService.Add(student2);
            studentService.Add(student3);


            GroupService groupService = new GroupService();
            Group group1 = new Group()
            {
                Name = "BB205"
            };

            Group group2 = new Group()
            {
                Name = "BB204"
            };

            Group group3 = new Group()
            {
                Name = "BB203"
            };

            groupService.Add(group1);
            groupService.Add(group2);
            groupService.Add(group3);
        }
    }
}