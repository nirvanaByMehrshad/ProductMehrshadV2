using DataLeyer.MyDbContext;
using DataLeyer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLeyer.Services
{
    public interface ICategoryRepository
    {
        bool IsCategoryCodeExist(int categoryId);
        void CreateCategory(CreateCategoryVm categoryVm);
        void DeleteCategory(int categoryId);
        bool IsCategoryHasrepation(int categoryId);
        IList<Category> GetDataTest();
    }
}
