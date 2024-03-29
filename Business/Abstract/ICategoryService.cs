﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        Category Get(int categoryId);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
