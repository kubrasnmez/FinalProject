
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//namespace, classların interfaceleri belirli bir isim uzayına koyuyoruz ki rahat bir şekilde ulaşalım.
namespace Core.DataAccess
{   //Core katmanı diğer katmanları referans almaz.
    //Generic Constraint
    //class : referans tip
    //IEntity : IEntity olabilir ya da IEntity implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalıdır.
   public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
