using System;
using System.Collections.Generic;

namespace ODataSample.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public SchoolModel School { get; set; }

        public Student(string name, int score, string nameSchool)
        {
            Id = Guid.NewGuid();
            Name = name;
            Score = score;

            School = new SchoolModel(nameSchool);
        }

        public static IEnumerable<Student> GetStudents()
        {
            var list = new List<Student>
            {
                new Student("Cody Allen", 130, "MIT"),
                new Student("Todd Ostermeier", 160, "Oxford"),
                new Student("Chris Pandya", 140, "MIT"),
                new Student("John Murdock", 200, "Oxford"),
                new Student("Stephan Gates", 190, "Oxford"),
            };

            return list;
        }
    }
}
