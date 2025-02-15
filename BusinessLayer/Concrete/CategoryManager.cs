﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categoryDal = categorydal;
        }

        public void CategoryAddBL(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDeleteBL(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdateBL(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetByIDBL(int id)
        {
            return _categoryDal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetListBL()
        {
            return _categoryDal.List();
        }
    }
}