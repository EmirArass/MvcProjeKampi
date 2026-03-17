using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryMenager : ICategoryService
    {

        ICategoryDal _categorydal;

        public CategoryMenager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }




        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllDL()
        //{
        //    return repo.List();
        //}

        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryDescription == "" || p.CategoryName.Length <= 3 || p.CategoryName.Length >= 51)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}
        public List<Category> GetList()
        {
            return _categorydal.List();
        }
    }
}
