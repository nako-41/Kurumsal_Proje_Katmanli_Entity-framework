using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Core.DataAccess
{
    //burada kısıtlama koydum interface
    //sadece class olabilir 
    //sadece IEntity varlıklarını kabul edebilir
    //ve sadece new lenebilen yapıları kabul edebilir.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //bu yapı ile sadece şunu getir diyoruz.filtreleme yapıyor LINQ ile gelen bir durum
        //buredaki filter null olması filter vermeyebilrisin demek.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        //buradaki filter zorunlu hale getirdik.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
