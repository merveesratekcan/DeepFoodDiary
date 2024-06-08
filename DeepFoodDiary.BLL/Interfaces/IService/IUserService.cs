using DeepFoodDiary.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.BLL.Interfaces.IService;

public interface IUserService
{
    bool Add(User user);
    bool Update(User user);
    bool Delete(int userID);
    User GetById(int userID);
    List<User> GetAll();
    User Login(string email, string password);
    bool RegisterControl(string email); // aynı mailde varmı ?
    string HashPassword(string password);

}
