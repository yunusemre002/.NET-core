using System;
using System.Collections.Generic;

namespace CourseApp.Models
{
    public static class Repository
    {
        private static List<Student> _students = new List<Student>();

        // Reposştory.Students
        public static List<Student> Students
        {
            get
            {
                return _students;
            }
        }
        
        //repository.AddStudent(student);
        public static void AddStudent(Student student)
        {
            _students.Add(student);
        }

        internal static IEnumerable<object> GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}