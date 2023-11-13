using EFHOMETASK2.DAL;
using EFHOMETASK2.Models;
using EFHOMETASK2.Services;

namespace EFHOMETASK2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           AppDbContext context= new AppDbContext();
            StudentService studentService = new StudentService();

            Student student = new Student("Shams", "Ragimzada", 100);
            Student student2 = new Student("Fidan", "Behbudova", 90);
            Student student3 = new Student("Jale", "Rustamova", 80);
            Student student4= new Student("Nigar", "Hesenova", 70);

            //CREATE METHOD
            studentService.Create(student);
            studentService.Create(student2);
            studentService.Create(student3);
            studentService.Create(student4);
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~`
            //GETBYID METHOD
            Student student1 = studentService.GetById(2);
            Console.WriteLine(student1.Name + " " + student1.Surname + " " + student1.AvgPoint);
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~`
            //GETALL METHOD
            List<Student> allStu = studentService.GetAll();
            foreach (var Student in allStu)
            {
                Console.WriteLine($"Id:{Student.Id} Name:{Student.Name} Surname:{Student.Surname} AvgPoint:{Student.AvgPoint}");
            }
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~`
            //UPDATE METHOD
            studentService.Update(5, "Sema", "Rehimova", 95.5m);
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~`
            //DELETE METHOD
            studentService.Delete(2);




        }
    }
}