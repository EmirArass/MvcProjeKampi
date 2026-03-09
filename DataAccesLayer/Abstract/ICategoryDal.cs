using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccesLayer.Abstract
{
    public interface ICategoryDal :IRepository<Category>
    {


        ////CRUD Operations
        ////Type Name();
        //List<Category> List();
        //void Insert(Category p);
        //void Update(Category p);
        //void Delete(Category p);
    }
}
