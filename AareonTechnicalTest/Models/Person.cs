using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AareonTechnicalTest.Models
{
    public class Person
    {
        [Key]
        public int Id { get; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public bool IsAdmin { get; set; }

        public List<Note> Notes { get; set; }

    }
}
