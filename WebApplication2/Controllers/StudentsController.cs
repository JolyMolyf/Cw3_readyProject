using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IdbService _dbService;


        public StudentsController(IdbService dbService)
        {
            _dbService = dbService; 
        }

        // private static List<Student> studentList = new List<Student>()
        // {
        //     new Student()
        //     {
        //         id = 0, name = "Jan", surname = "Kowalski"
        //     }
        // };

        
        

        [HttpGet]
        public IActionResult GetStudent()
        {
            return Ok(_dbService.GetStudents());
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {

            return _dbService.GetStudents().FirstOrDefault(st => st.id == id);
        }

        [HttpPut( "{id}")]
        public IActionResult PutStudent(int id , [FromBody] Student student)
        {
            return Ok(student + " aktualizacja dokonczona"); 
        }

        
        [HttpDelete("{id}")]
        public IActionResult deleteStudent(int id) {
            
            return Ok("usuniento rekord: " + id); 
        }


        [HttpPost]
        public void PostStudent([FromBody] string value)
        {
            
            Console.WriteLine(value + " my value");
        }
    }
}