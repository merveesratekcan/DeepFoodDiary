using DeepFoodDiary.DAL.RepositoryInterface;
using DeepFoodDiary.ENTITY.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly DbSet<T> _table;
        protected readonly DbContext _context;
        public BaseRepository()
        {
            _table = ApplicationDataBase.Context.Set<T>();
            _context = ApplicationDataBase.Context;
        }
        public T Add(T entity)
        {
            //Entity --> T yi döndürmek için Entity koyduk. Entity konrol ediyoruz. Ekledikten sonra başarılımı değilmi kontrolünü sağlıcaz.
            var entry = _table.Add(entity);
            _context.SaveChanges();
            return entry.Entity;
            

        }

        public T Find(Func<T, bool> predicate)
        {
            // Tüm aktif öğeleri filtrele
            var activeItems = GetAllActives();

            // Verilen koşulu sağlayan ilk öğeyi döndür
            return activeItems.FirstOrDefault(predicate);
        }

        public void AddRange(List<T> entities)
        {
            _table.AddRange(entities);
        }
        //Statüsü deleted olmayanlarla çalışmamız lazım. Sildiklerimizi biyerde görmek istemiyorsak sürekli statüsü deleted olmayanları getirirz.
        //Sadece burada kullanıcaz. o yüzden protected.
        //Listeye bu şekilde bir expression atamıyoruz o yüzden IQueryable yaptık !!!
        public bool Any(Expression<Func<T, bool>>? expression = null)
        {

            if (expression == null)
            {
                return GetAllActives().Any();
            }
            else
            {
                return GetAllActives().Any(expression);
            }
        }

        public T Delete(int id)
        {
            //var entity = _table.Remove(GetById(id)).Entity;
            //_context.SaveChanges();
            //return entity;
            var entity = GetAllActives().FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                var removedEntity = _table.Remove(entity).Entity;
                _context.SaveChanges();
                return removedEntity;
            }
            return null; // Eğer entity null ise, bir şey silinmemiştir.
        }
        public void DeleteRange(List<T> entities)
        {
            _table.RemoveRange(entities);
        }
        public T Get(Expression<Func<T, bool>> expression)
        {
            // tabledan tüm veriler geldi --> bunun yerine içerdeki expresine göre  tüm tabloda yapmadık ilgili koşula göre verilere ulaştık.( aktiflerde yapıcaz ?)
            return GetAllActives().FirstOrDefault(expression);
        }
        // TKey --> Yazdıgımız TKey yerine   bool  yazarisek  quearyable olur  TKey yazarsak orderable olur. Bu bir sabittir. Bir sıralama yapacak isek TKeyi kullanmak zorundayız.
        //B
        public List<T> GetAll<TKey>(Expression<Func<T, TKey>> orderby, bool orderDes = false)
        {
            var values = GetAllActives();
            return orderDes ? values.OrderByDescending(orderby).ToList() : values.OrderBy(orderby).ToList();
        }
        //A+B
        public List<T> GetAll<TKey>(Expression<Func<T, bool>> expression, Expression<Func<T, TKey>> orderby, bool orderDes = false)
        {
            var values = GetAllActives().Where(expression);
            return orderDes ? values.OrderByDescending(orderby).ToList() : values.OrderBy(orderby).ToList();
        }
       //A
        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return GetAllActives().Where(expression).ToList();
        }

        public List<T> GetAll()
        {

            return GetAllActives().ToList();
        }

        public T GetById(int id)
        {
            return GetAllActives().FirstOrDefault(x => x.Id == id);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public T Update(T entity)
        {
            var entityResult = _table.Update(entity).Entity;
            _context.SaveChanges();
            return entityResult;
        }
        protected IQueryable<T> GetAllActives()
        {
            return _table.Where(x => x.Status != ENTITY.Enums.Statu.Deleted);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return GetAllActives().FirstOrDefault(expression);
        }

    }
}
