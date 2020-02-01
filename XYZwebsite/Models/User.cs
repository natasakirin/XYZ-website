using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XYZwebsite.Models
{
    public class User
    {
        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Constructors
        public User()
        {
            Id = Guid.NewGuid();
            FirstName = "";
            LastName = "";
            FullName = FirstName + " " + LastName;
        }

        public User(string firstname, string lastname)
        {
            Id = Guid.NewGuid();
            FirstName = firstname;
            LastName = lastname;
            FullName = FirstName + " " + LastName;
        }

        public User(string firstname, string lastname, string email, string password)
        {
            Id = Guid.NewGuid();
            FirstName = firstname;
            LastName = lastname;
            FullName = FirstName + " " + LastName;
            Email = email;
            Password = password;
        }
    }
}
