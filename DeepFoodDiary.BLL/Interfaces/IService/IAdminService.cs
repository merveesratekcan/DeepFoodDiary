using DeepFoodDiary.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.BLL.Interfaces.IService;

public interface IAdminService
{
    bool LogIn(string adminName, string password);

    
}



