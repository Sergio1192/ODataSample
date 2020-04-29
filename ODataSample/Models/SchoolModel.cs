using System;

namespace ODataSample.Models
{
    public class SchoolModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public SchoolModel(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
