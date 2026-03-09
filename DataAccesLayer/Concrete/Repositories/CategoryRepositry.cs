using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccesLayer.Concrete.Repositories
{
    public class CategoryRepositry : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;

        public void Delete(Category p)
        {
            _object.Remove(p); // Silme işlemi için Remove metodu kullanılır. object.remove = bir şeyi kaldıracaksın.  !!NEYİ KALDIRACAKSIN: object.remove(p) = p'yi kaldıracaksın.
            c.SaveChanges(); // Değişiklikleri kaydetmek için SaveChanges metodu kullanılır. SaveChanges = değişiklikleri kaydet.
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}
