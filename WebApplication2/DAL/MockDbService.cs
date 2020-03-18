using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class MockDbService: IdbService
    {
        private static List<Student> studentList = new List<Student>()
        {
            new Student()
            {
                id = 0, name = "Jan", surname = "Kowalski"
            }
        };


        public IEnumerable<Student> GetStudents()
        {
          return  studentList;
        }
    }
}