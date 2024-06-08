using DeepFoodDiary.ENTITY.BaseEntities;
using DeepFoodDiary.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.AddDbContext
{
    public  class DiaryDbContext:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<UserMealFood> UserFoodMeals { get; set; }
        public DbSet<Category> Categories { get; set; }
        

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("" +
            "Server=LEVI;" +
            "Database=DeepFoodDiary001;" +
            "Trusted_Connection=True;" +
            "Encrypt = True;" +
            "TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }


        public override int SaveChanges()
        {

            SetBaseProperties();
            return base.SaveChanges();
        }

        private void SetBaseProperties()
        {
         
            var entries = ChangeTracker.Entries<BaseEntity>();
            foreach (var entry in entries)
            {
                SetIfAdded(entry);
                SetIfModified(entry);
                SetIfDeleted(entry);
            }
        }
        private void SetIfDeleted(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Deleted)
            {
                
                entry.State = EntityState.Modified;
                entry.Entity.Status = ENTITY.Enums.Statu.Deleted;
                entry.Entity.DeletedDate = DateTime.Now;

            }
        }

        private void SetIfModified(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Modified)
            {
                entry.Entity.Status = ENTITY.Enums.Statu.Update;
                entry.Entity.ModifiedDate = DateTime.Now;

            }
        }

        private void SetIfAdded(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.Status = ENTITY.Enums.Statu.Created;
                entry.Entity.CreatedDate = DateTime.Now;

            }
        }



    }
}
