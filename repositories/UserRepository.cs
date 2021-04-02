using System.Collections.Generic;
using System.Linq;
using appjwt.Models;

namespace appjwt.repositories
{
    public static class UserRepository
    {
        public static User GetUser(string username, string password)
        {
            var users = new List<User>();
            users.Add(
                new User
                {
                    Id = 1,
                    Username = "batman",
                    Password = "batman",
                    Role = "manager"
                });
            users.Add(
                new User
                {
                    Id = 2,
                    Username = "robin",
                    Password = "robin",
                    Role = "employee"
                });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}