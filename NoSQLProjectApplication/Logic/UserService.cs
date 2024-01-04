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

        public UserService()
        {
            userDAO = new UserDAO();

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

        public void UpdatePassword(string userEmail, string password)
        {
            userDAO.UpdatePassword(userEmail, password);
        }
        public bool VerifyResetToken(string email, string token)
        { 
            return userDAO.VerifyResetToken(email, token); 
        }
        public void StorePasswordResetToken(string email, string resetToken)
        {
            userDAO.StorePasswordResetToken(email, resetToken); 
        }

    }
}
