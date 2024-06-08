using DeepFoodDiary.DAL.RepositoryInterface;
using DeepFoodDiary.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.Repositories;

public class FoodRepository : BaseRepository<Food>, IFoodRepository
{
}
