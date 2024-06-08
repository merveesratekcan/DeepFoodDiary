using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.DAL;
using DeepFoodDiary.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.BLL.Services
{
    public class UserService : IUserService
    {
        public bool Add(User user)
        {
            if (user != null)
            {
                var result = UnitOfWork.Instance.UserRepository.Add(user);
                if (result != null)
                {
                    return true;

                }
                return false;
            }
            return false;
        }

        public bool Delete(int userID)
        {
            if (userID == 0)
            {
                return false;
            }
            var result = UnitOfWork.Instance.UserRepository.Delete(userID);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public List<User> GetAll()
        {
            return UnitOfWork.Instance.UserRepository.GetAll();
        }

        public User GetById(int userID)
        {
            if (userID == 0)
            {
                return null;
            }
            return UnitOfWork.Instance.UserRepository.GetById(userID);
        }

        public string HashPassword(string password)
        {
            var hash = SHA256.Create();

            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] hasBytes = hash.ComputeHash(inputBytes);
            var result = BitConverter.ToString(hasBytes).Replace("-", "").ToLower();
            return result;
        }

        //Login
        public User Login(string email, string password)
        {
            var user = UnitOfWork.Instance.UserRepository.FirstOrDefault(x => x.UserName == email && x.Password == HashPassword(password));
            return user;
        }
        //Register
        public bool RegisterControl(string email)
        {
            return UnitOfWork.Instance.UserRepository.Any(x => x.UserName == email);
        }

        public bool Update(User user)
        {

            if (user == null)
            {
                return false;
            }
            var result = UnitOfWork.Instance.UserRepository.Update(user);
            if (result == null)
            {
                return false;
            }
            return true;
        }
    }
}
