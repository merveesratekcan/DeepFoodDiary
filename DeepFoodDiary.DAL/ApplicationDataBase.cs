using DeepFoodDiary.DAL.AddDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL
{
    public class ApplicationDataBase
    {
        private static DiaryDbContext context;

        public static DiaryDbContext Context
        {
            get
            {
                if (context == null)
                {
                    context = new DiaryDbContext();
                }
                return context;
            }
        }
    }
}
