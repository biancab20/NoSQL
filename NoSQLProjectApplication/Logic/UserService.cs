using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Security.Cryptography;


namespace Logic
{
    public class UserService
    {
        UserDAO userDAO;

        User currentUser;

        public void SetCurrentUser(User user)
        {
            currentUser = user;
        }

        public string GetCurrentUserRole()
        {
            if (currentUser != null)
            {
                return currentUser.Role.ToString();
            }

            return null;
        }

        public UserService()
        {
            userDAO = new UserDAO();

            currentUser = new User
            {
                FirstName = "John",
                LastName = "Doe",
                Username = "john.doe",
                Password = "hashed_password",
                Role = Role.ServiceDesk
            };

        }
        public List<User> GetAllUsers()
        {
            return userDAO.GetAllUsers();
        }
        public void CreateUser(User user)
        {
            userDAO.CreateUser(user);
        }
        public void UpdateUser(string userId, UpdateDefinition<User> updateDefinition)
        {
            userDAO.UpdateUser(userId, updateDefinition);
        }
        public void DeleteUser(string userId)
        {
            userDAO.DeleteUser(userId);
        }
        public string Hash(string password)
        {
            return userDAO.Hash(password);
        }
        public User GetUserByUserName(string username) => userDAO.GetUserByUserName(username);
        public User GetUserByPassword(string password) => userDAO.GetUserByPassword(password);

        public string GetCurrentUsername()
        {
            return currentUser?.Username;
        }
    }
}
