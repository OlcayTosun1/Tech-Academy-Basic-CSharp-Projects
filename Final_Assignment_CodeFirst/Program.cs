using System;
using System.Data.Entity;
using System.Linq;

namespace OlcayFinalAssignment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Code First creates the database if it does not already exist.
            Database.SetInitializer(new CreateDatabaseIfNotExists<SchoolContext>());

            using (var db = new SchoolContext())
            {
                const string studentEmail = "olcay.student@example.com";

                var existingStudent = db.Students.FirstOrDefault(s => s.Email == studentEmail);

                if (existingStudent == null)
                {
                    var student = new Student
                    {
                        FirstName = "Olcay",
                        LastName = "Student",
                        Email = studentEmail,
                        EnrollmentDate = DateTime.Today
                    };

                    db.Students.Add(student);
                    db.SaveChanges();

                    Console.WriteLine("Database created and one student was added successfully.");
                }
                else
                {
                    Console.WriteLine("The student already exists in the database.");
                }

                Console.WriteLine();
                Console.WriteLine("Students currently saved in the database:");

                foreach (var student in db.Students.OrderBy(s => s.StudentId).ToList())
                {
                    Console.WriteLine($"ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}, Email: {student.Email}, Enrollment Date: {student.EnrollmentDate:d}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }
    }
}
