using Microsoft.AspNetCore.Mvc;
using AlohaTestAPI.Models.ORM;
using Microsoft.EntityFrameworkCore;
using AlohaTestAPI.Models.Dto;


namespace AlohaTestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        
        AlohaContext context;
        public StudentController()
        {
            context = new AlohaContext();
        }
        [HttpGet]
        public List<Student> GetAll()
        {
            return context.Students.ToList();   
        }
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return context.Students.Find(id);
        }
        [HttpPost]
        public Student Post(StudentPostRequestDto model)
        {
            Student student = new Student();
            student.Name = model.Name.Trim();
            student.Surname = model.Surname.Trim();
            student.Email = model.Email.Trim().ToLower();
            student.Phone = model.Phone.Trim();

            context.Students.Add(student);
            context.SaveChanges();

            return student;
        }
        [HttpDelete]
        public Student Delete(int id)
        {
            Student student = context.Students.Find(id);
            context.Students.Remove(student);
            context.SaveChanges();
            return student;
        }

    }
}
