using System.Collections.Generic;

namespace CourseApp.Models
{
    public static class RepositoryMemtext
    {
        private static List<SutunMemtext> _sutunlar = new List<SutunMemtext>();

        // Repository.Students

        public static List<SutunMemtext> Sutunlar
        {
            get
            {
                return _sutunlar;
            }
        }

        //Repository.AddStudent(student);
        public static void AddSutunMemtext(SutunMemtext satir)
        {
            _sutunlar.Add(satir);
        }

    }
}