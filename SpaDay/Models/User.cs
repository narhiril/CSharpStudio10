using System;

namespace SpaDay.Models
{
    public class User
    {
        private static int nextId = 1;
        public readonly DateTime DateCreated;
        public int Id { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public User()
        {
            Id = nextId;
            nextId++;
            DateCreated = DateTime.Now;
        }

        public User(string username, string password, string email) : base()
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }
}
