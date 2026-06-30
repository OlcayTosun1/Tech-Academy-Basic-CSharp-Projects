using System;
using System.ComponentModel.DataAnnotations;

namespace OlcayFinalAssignment
{
    // This class becomes a Students table in the database using Code First.
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}
