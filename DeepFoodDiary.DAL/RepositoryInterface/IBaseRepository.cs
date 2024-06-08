using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.RepositoryInterface;

public interface IBaseRepository<T> where T : class
{
    int SaveChanges();
    T Add(T entity);
    void AddRange(List<T> entities);
    T Update(T entity);
    T Delete(int Id);
    void DeleteRange(List<T> entities);
    T Get(Expression<Func<T, bool>> expression);
    T GetById(int id);
    bool Any(Expression<Func<T, bool>>? expression = null);
    List<T> GetAll<TKey>(Expression<Func<T, TKey>> orderby, bool orderDes = false);
    List<T> GetAll<TKey>(Expression<Func<T, bool>> expression, Expression<Func<T, TKey>> orderby, bool orderDes = false);
    List<T> GetAll(Expression<Func<T, bool>> expression);
    List<T> GetAll();
    T FirstOrDefault(Expression<Func<T, bool>> expression);

    T Find(Func<T, bool> predicate);
}
