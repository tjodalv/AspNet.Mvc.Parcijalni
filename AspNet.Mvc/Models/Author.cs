using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace AspNet.Mvc.Models
{
    public class Author
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string DisplayName { get; }

        public DateOnly DOB { get; }

        public string Bio { get; set; }

        public Author(string firstName, string lastName, DateOnly dob, string displayName = null, string bio = "")
        {
            FirstName = firstName;
            LastName = lastName;
            DOB = dob;
            Bio = bio;
            DisplayName = displayName;
        }

        public override string ToString()
        {
            return DisplayName ?? $"{FirstName} {LastName}";
        }
    }
}
