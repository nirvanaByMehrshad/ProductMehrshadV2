using DataLeyer.MyDbContext;
using DataLeyer.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLeyer.Services
{
    public class CatgeoryRepository : ICategoryRepository
    {
        public void CreateCategory( CreateCategoryVm categoryVm )
        {
            using ( var db = new MyDb())
            {
                var category = new Category()
                {
                    Code = categoryVm.Code,
                    Title = categoryVm.Title
                };

                db.Categories.Add(category);
                db.SaveChanges();
            }
        }
        public bool IsCategoryCodeExist( int categoryId)
        {
            using( var db = new MyDb())
            {
                return db.Categories.Any(x => x.CategoryID == categoryId);
            }
        }
        public bool IsCategoryHasrepation( int categoryId)
        {
            using(var db = new MyDb())
            {
                var numberOfRelation = db.Categories.FirstOrDefault(x => x.CategoryID == categoryId).Products.Count;

                if(numberOfRelation != 0)
                {
                    return true;
                }

                return false;
            }
        }
        public void DeleteCategory( int categoryId)
        {
            using(var db = new MyDb())
            {
                var category = db.Categories.FirstOrDefault(x => x.CategoryID == categoryId);
                db.Categories.Remove(category);
                db.SaveChanges();
            }
        }
        public IList<Category> GetDataTest()
        {
            using (var db = new MyDb())
            {
                return db.Categories.ToList();
            }
        }
    }
}
