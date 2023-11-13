using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using EFHOMETASK2.DAL;
using EFHOMETASK2.Models;

namespace EFHOMETASK2.Services
{
    internal class StudentService
    {
        private static AppDbContext _context = new AppDbContext();

        public List<Student> GetAll()
        {
            return _context.Students.ToList();  
        }
        public Student GetById(int id)
        {
            Student student = _context.Students.FirstOrDefault(s => s.Id == id) ;
            if (student==null)
            {
                Console.WriteLine("Bele telebe tapilmadi :(");

            }
            return student;
        }

        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Update(int id, string name, string surname, decimal Avgpoint)
        {
            Student student=_context.Students.FirstOrDefault(s => s.Id == id);
            if (student!=null)
            {
                student.Name = name;
                student.Surname = surname;
                student.AvgPoint = Avgpoint;
                _context.SaveChanges();
            }
            
        }
         
        public void Delete(int id)
        {
            Student student=_context.Students.FirstOrDefault(s => s.Id == id);
            if (student!=null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();

            }
        }


    }
}
