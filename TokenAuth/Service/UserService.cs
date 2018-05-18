using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokenAuth.Models;

namespace TokenAuth.Service
{
    public class UserService
    {
        public User ValidateUser(string email, string password)
        {
            // Here you can write the code to validate
            // User from database and return accordingly
            // To test we use dummy list here
            var userList = GetUserList();
            var user = userList.FirstOrDefault(x => x.Email == email && x.Password == password);
            return user;
        }

        // Create the list of user and return 
        public List<User> GetUserList()
        {
            List<User> listUsers = new List<User>();

            var user1 = new User
            {
                Id = 1,
                Name = "parth",
                Email = "parth@gmail.com",
                Password = "parth#123"
            };

            listUsers.Add(user1);

            return listUsers;                      
        }
    }
}