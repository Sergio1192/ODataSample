using System;

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
    }
}
