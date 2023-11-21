namespace WebApplication_FirstAspNetCoreApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public bool IsRegistrationNew { get; set; }

        public string Password { get; set; }
    }
}
