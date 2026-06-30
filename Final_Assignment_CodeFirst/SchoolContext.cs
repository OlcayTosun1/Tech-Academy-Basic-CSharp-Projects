using System.Data.Entity;

namespace OlcayFinalAssignment
{
    // DbContext connects the Student class to the database.
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
