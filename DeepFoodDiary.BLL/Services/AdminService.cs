using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.DAL;
using DeepFoodDiary.DAL.AddDbContext;
using DeepFoodDiary.DAL.RepositoryInterface;
using DeepFoodDiary.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.BLL.Services;

public class AdminService : IAdminService
{
   
    public bool LogIn(string username, string password)
    {
        return UnitOfWork.Instance.AdminRepository.Any(x=>x.AdminName == username && x.Password == password);
    }
}

